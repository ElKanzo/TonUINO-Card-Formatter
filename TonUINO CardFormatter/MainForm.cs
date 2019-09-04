using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using ElKanzo.TonuinoCardFormatter.Properties;
using log4net;
using MiFare;
using MiFare.Classic;
using MiFare.Devices;
using MiFare.PcSc;

namespace ElKanzo.TonuinoCardFormatter
{
	public enum Version : Byte
	{
		V1 = 1,
	}

	public enum Mode : Byte
	{
		/// <summary>Kein Modus</summary>
		None = 0,
		/// <summary>Hörspiel -> eine zufällige Datei aus dem Ordner</summary>
		Radioplay = 1,
		/// <summary>Kompletten Ordner spielen</summary>
		Album = 2,
		/// <summary>Ordner in zufälliger Reihenfolge</summary>
		Party = 3,
		/// <summary>EinzelTitel -> eine Datei aus dem Ordner abspielen</summary>
		SingleTrack = 4,
		/// <summary>Hörbuch -> kompletten Ordner spielen und Fortschritt merken</summary>
		Audiobook = 5,
		/// <summary>Admin Modus</summary>
		Admin = 6,
		/// <summary>Hörspiel -> Spezialmodus Von-Bis: Hörspiel: eine zufällige Datei aus dem Ordner</summary>
		RadioplayRandom = 7,
		/// <summary>Spezialmodus Von-Bis: Album: alle Dateien zwischen Start und Ende spielen</summary>
		SpezialVonBis = 8,
		/// <summary>Spezialmodus Von-Bis: Party Ordner in zufälliger Reihenfolge</summary>
		PartyRandom = 9,
	}


	public partial class MainForm : Form
	{
		// Class variables
		private static readonly ILog m_logger = LogManager.GetLogger(typeof(MainForm));
		private SmartCardReader m_reader;
		private TonuinoCard m_touinoCard;
		private MiFareCard m_miFareCard;


		// Constructor
		public MainForm()
		{
			InitializeComponent();
			InitClassVars();
		}



		// Events

		private void HandleCardRemoved(Object sender, EventArgs e)
		{
			m_logger.Debug("Card removed.");
			m_touinoCard = null;
			m_miFareCard?.Dispose();
			m_miFareCard = null;
			activeCardControl.SetValues(null);
			SetEnabledState(writeSettingsButton, false);
		}

		private async void HandleCardAdded(Object sender, CardEventArgs args)
		{
			m_logger.Debug("Card Added");
			try
			{
				m_touinoCard = new TonuinoCard();
				SetEnabledState(writeSettingsButton, true);
				await ReadCard(args);
			}
			catch (Exception ex)
			{
				m_logger.Error("Error handling new card! ", ex);
			}
			finally
			{
				activeCardControl.SetValues(m_touinoCard);
			}
		}

		private void HandleSelectSdDirButtonClick(Object sender, EventArgs e)
		{
			if (folderBrowserDialog.ShowDialog(this) == DialogResult.OK)
			{
				sdDirTextBox.Text = folderBrowserDialog.SelectedPath;
				Settings.Default.SdCardFolder = folderBrowserDialog.SelectedPath;
				Settings.Default.Save();
			}
		}

		private void HandleImportButtonClick(Object sender, EventArgs e)
		{
			if (openFileDialog.ShowDialog(this) == DialogResult.OK)
			{
				PopupMessage(String.Join(", ", openFileDialog.FileNames));
			}
		}

		private void HandleWriteSettingsButtonClick(Object sender, EventArgs e)
		{
			SectorKeySet set = new SectorKeySet();
			set.KeyType = KeyType.KeyB;
			set.Sector = 1;
			set.Key = new Byte[] { 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF };
			m_miFareCard.AddOrUpdateSectorKeySet(set);
			newSettingsCardControl.GetValues(m_touinoCard);
			m_miFareCard.SetData(1, 0, m_touinoCard.ToByteArray());
			m_miFareCard.Flush();
			activeCardControl.SetValues(m_touinoCard);
		}


		// Private helperfunctions
		/// <summary>Read newly found card data.</summary>
		private async Task ReadCard(CardEventArgs args)
		{
			try
			{
				m_miFareCard = args.SmartCard.CreateMiFareCard();
				var cardIdentification = await m_miFareCard.GetCardInfo();

				if (cardIdentification.PcscDeviceClass == DeviceClass.StorageClass && (cardIdentification.PcscCardName == CardName.MifareStandard1K || cardIdentification.PcscCardName == CardName.MifareStandard4K))
				{
					Byte[] uid = await m_miFareCard.GetUid();
					Byte[] data = await m_miFareCard.GetData(TonuinoCard.Sector, TonuinoCard.StartIndex, TonuinoCard.Length);
					m_touinoCard = new TonuinoCard(uid, data);
				}
			}
			catch (Exception ex)
			{
				m_logger.Error("Error while reading new card!", ex);
			}
		}

		/// <summary>Display message via dialogue box</summary>
		private void PopupMessage(String message)
		{
			var ignored = BeginInvoke((Action)(() => { MessageBox.Show(message); }));
		}

		private void SetEnabledState(Control control, Boolean enabled)
		{
			BeginInvoke((Action)(() => { control.Enabled = enabled; }));
		}

		/// <summary>Init MainForm.</summary>
		private void InitClassVars()
		{
			sdDirTextBox.Text = Settings.Default.SdCardFolder;
			folderBrowserDialog.Description = "Verzeichnis des SD Kartenabbilds auswählen";
			folderBrowserDialog.SelectedPath = sdDirTextBox.Text;
			folderBrowserDialog.ShowNewFolderButton = true;
			openFileDialog.Title = "Zu importierende Dateien auswählen";
			openFileDialog.Multiselect = true;
			openFileDialog.Filter = "MP3 Dateien (*.mp3)|*.mp3";

			writeSettingsButton.Enabled = false;
			activeCardControl.SetReadOnlyMode();

			// Init NFC Reader
			InitReader();
		}

		/// <summary>Finds first (or best fitting) NFC reader and registers event handlers for card added/removed</summary>
		private async void InitReader()
		{
			try
			{
				m_reader = await CardReader.FindAsync();
				if (m_reader != null)
				{
					m_reader.CardAdded += HandleCardAdded;
					m_reader.CardRemoved += HandleCardRemoved;
				}
			}
			catch (Exception ex)
			{
				m_logger.Error("Unhandled Exception while initializing card readers!", ex);
			}
		}
	}

	public class SdCard
	{
		public String Name { get; set; }
		public String Directory { get; set; }
		public List<Folder> Folders { get; set; }
	}

	public class Folder
	{
		public Byte Number { get; set; }
		public List<Album> Albums { get; set; }
	}

	public class Album
	{
		public String Title { get; set; }
		public Byte[] Image { get; set; }
		public Byte Folder { get; set; }
		public List<Track> Tracks { get; set; }
	}

	public class Track
	{
		public String Title { get; set; }
		public Int16 TrackNo { get; set; }
	}

	public class TonuinoCard
	{
		public const UInt32 Cookie = 0x1337b347;
		public const Int32 Sector = 1;
		public const Int32 StartIndex = 0;
		public const Int32 Length = 9;

		private const Int32 VersionIndex = 4;
		private const Int32 FolderIndex = 5;
		private const Int32 ModeIndex = 6;
		private const Int32 Special1Index = 7;
		private const Int32 Special2Index = 8;

		private readonly Byte[] m_id;  // Holds the raw data from the card.
		private Byte[] m_data;  // Holds the raw data from the card.


		public TonuinoCard()
		{
			m_id = null;
			m_data = null;
		}

		public TonuinoCard(Byte[] uid, Byte[] data)
		{
			m_id = uid;
			m_data = data;
		}


		public String ID
		{
			get
			{
				if (m_id?.Length > 0)
					return BitConverter.ToString(m_id);
				return "?";
			}
		}

		public Version Version
		{
			get
			{
				if (m_data?.Length > VersionIndex)
					return (Version)m_data[VersionIndex];
				return 0;
			}
			set
			{
				if (m_data?.Length > VersionIndex)
					m_data[VersionIndex] = (Byte)value;
			}
		}

		public Byte Folder
		{
			get
			{
				if (m_data?.Length > FolderIndex)
					return m_data[FolderIndex];
				return 0;
			}
			set
			{
				if (m_data?.Length > FolderIndex)
					m_data[FolderIndex] = value;
			}
		}

		public Mode Mode
		{
			get
			{
				if (m_data?.Length > ModeIndex)
					return (Mode)m_data[ModeIndex];
				return 0;
			}
			set
			{
				if (m_data?.Length > ModeIndex)
					m_data[ModeIndex] = (Byte)value;
			}
		}

		public Byte Special1
		{
			get
			{
				if (m_data?.Length > Special1Index)
					return m_data[Special1Index];
				return 0;
			}
			set
			{
				if (m_data?.Length > Special1Index)
					m_data[Special1Index] = value;
			}
		}

		public Byte Special2
		{
			get
			{
				if (m_data?.Length > Special2Index)
					return m_data[Special2Index];
				return 0;
			}
			set
			{
				if (m_data?.Length > Special2Index)
					m_data[Special2Index] = value;
			}
		}



		public Boolean IsValid()
		{
			if (m_data?.Length >= Length) // At least 9 Bytes are used.
				return (m_data[0] << 24) + (m_data[1] << 16) + (m_data[2] << 8) + m_data[3] == Cookie;

			return false;
		}

		public void Format(Byte version = 1, Byte folder = 0, Byte mode = 0, Byte special1 = 0, Byte special2 = 0)
		{
			m_data = new Byte[] { 0x13, 0x37, 0xb3, 0x47, version, folder, mode, special1, special2 };
		}

		public Byte[] ToByteArray()
		{
			return m_data;
		}
	}
}
