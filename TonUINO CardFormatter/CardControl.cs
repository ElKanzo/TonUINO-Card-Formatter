using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ElKanzo.TonuinoCardFormatter
{
	public partial class CardControl : UserControl
	{
		public CardControl()
		{
			InitializeComponent();
			InitClassVars();
		}


		public void SetReadOnlyMode()
		{
			cardPresentLabel.Visible = true;
			idLabel.Visible = true;
			idValueLabel.Visible = true;
			modeComboBox.Enabled = false;
			versionComboBox.Enabled = false;
			folderNumericUpDown.Enabled = false;
			special1NumericUpDown.Enabled = false;
			special2NumericUpDown.Enabled = false;
		}

		public void SetValues(TonuinoCard card)
		{
			BeginInvoke((Action)(() =>
			{
				if (card == null)
				{
					cardPresentLabel.Text = "Keine Karte";
					cardPresentLabel.ForeColor = Color.Black;
					idValueLabel.Text = String.Empty;
					ClearData();
				}
				else if (!card.IsValid())
				{
					cardPresentLabel.Text = "Falscher Karten-Typ";
					cardPresentLabel.ForeColor = Color.Red;
					idValueLabel.Text = card.ID;
					ClearData();
				}
				else if (!card.IsFormatted())
				{
					cardPresentLabel.Text = "Unbekannte Karte";
					cardPresentLabel.ForeColor = Color.Red;
					idValueLabel.Text = card.ID;
					ClearData();
				}
				else
				{
					cardPresentLabel.Text = "TonUINO Karte";
					cardPresentLabel.ForeColor = Color.Green;
					idValueLabel.Text = card.ID;
					versionComboBox.SelectedValue = card.Version;
					modeComboBox.SelectedValue = card.Mode;
					folderNumericUpDown.Value = card.Folder;
					special1NumericUpDown.Value = card.Special1;
					special2NumericUpDown.Value = card.Special2;
				}
			}));
		}

		public void GetValues(TonuinoCard card)
		{
			if (!card.IsFormatted())
				card.Format();
			card.Version = (Version)versionComboBox.SelectedValue;
			card.Mode = (Mode)modeComboBox.SelectedValue;
			card.Folder = (Byte)folderNumericUpDown.Value;
			card.Special1 = (Byte)special1NumericUpDown.Value;
			card.Special2 = (Byte)special2NumericUpDown.Value;
		}


		private void InitClassVars()
		{
			cardPresentLabel.Visible = false;
			idLabel.Visible = false;
			idValueLabel.Visible = false;
			idValueLabel.Text = String.Empty;

			List<EnumListEntry<Version>> verisonListEntries = new List<EnumListEntry<Version>>()
			{
				new EnumListEntry<Version>(Version.V1),
			};

			versionComboBox.Items.Clear();
			versionComboBox.DisplayMember = "Description";
			versionComboBox.ValueMember = "Value";
			versionComboBox.DataSource = verisonListEntries;


			List<EnumListEntry<Mode>> modeListEntries = new List<EnumListEntry<Mode>>()
			{
				new EnumListEntry<Mode>(Mode.None),
				new EnumListEntry<Mode>(Mode.Radioplay),
				new EnumListEntry<Mode>(Mode.Album),
				new EnumListEntry<Mode>(Mode.Party),
				new EnumListEntry<Mode>(Mode.SingleTrack),
				new EnumListEntry<Mode>(Mode.Audiobook),
				new EnumListEntry<Mode>(Mode.Admin),
				new EnumListEntry<Mode>(Mode.RadioplayRandom),
				new EnumListEntry<Mode>(Mode.SpezialVonBis),
				new EnumListEntry<Mode>(Mode.PartyRandom),
			};

			modeComboBox.Items.Clear();
			modeComboBox.DisplayMember = "Description";
			modeComboBox.ValueMember = "Value";
			modeComboBox.DataSource = modeListEntries;
		}

		private void ClearData()
		{
			versionComboBox.SelectedIndex = 0;
			modeComboBox.SelectedIndex = 0;
			folderNumericUpDown.Value = 1;
			special1NumericUpDown.Value = 0;
			special2NumericUpDown.Value = 0;
		}
	}

	public class EnumListEntry<T> : IComparable
	{
		// ----- Erzeugen / Zerstören des Objekts -----

		public EnumListEntry(T value)
		{
			this.Value = value;
			this.Description = ResourceHelper.GetText(value);
		}


		// ----- Eigenschaften -----

		public T Value { get; private set; }

		public String Description { get; private set; }


		// ----- Methoden -----

		public override String ToString()
		{
			return this.Description;
		}

		public Int32 CompareTo(Object obj)
		{
			return String.Compare(this.Description, ((EnumListEntry<T>)obj).Description);
		}
	}

}
