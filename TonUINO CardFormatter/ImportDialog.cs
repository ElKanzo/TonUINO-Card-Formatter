using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using BrightIdeasSoftware;
using log4net;

namespace ElKanzo.TonuinoCardFormatter
{
	public partial class ImportDialog : Form
	{
		// Class variables
		private static readonly ILog m_logger = LogManager.GetLogger(typeof(ImportDialog));
		private Album m_album;


		// Constructor
		public ImportDialog(String[] fileNames)
		{
			InitializeComponent();
			mainOLV.MultiSelect = false;
			mainOLV.FormatRow += HandleFormatRow;
			mainOLV.DragSource = new SimpleDragSource();
			mainOLV.DropSink = new RearrangingDropSink(false);

			List<ListViewModel> listViewItems = new List<ListViewModel>();
			foreach (String file in fileNames)
			{
				using (TagLib.File fileInfo = TagLib.File.Create(file))
				{
					listViewItems.Add(new ListViewModel { Performer = fileInfo.Tag.JoinedPerformers, Album = fileInfo.Tag.Album, Track = fileInfo.Tag.Title, TrackNo = fileInfo.Tag.Track.ToString(), FileName = file });
				}
			}

			mainOLV.SetObjects(listViewItems);
			performerTextBox.Text = String.Join(",", listViewItems.Select(t => t.Performer).Distinct());
			albumTextBox.Text = String.Join(",", listViewItems.Select(t => t.Album).Distinct());
		}


		// Events

		private void HandleFormatRow(Object sender, FormatRowEventArgs e)
		{
			e.Item.SubItems[0].Text = $"{e.DisplayIndex + 1:000}";
			((ListViewModel)e.Model).DisplayIndex = e.DisplayIndex;
		}

		private void HandlePictureCheckBoxCheckedChanged(Object sender, EventArgs e)
		{
			addPictureButton.Enabled = pictureCheckBox.Checked;
		}

		private void HandleRemoveButtonClick(Object sender, EventArgs e)
		{
			mainOLV.RemoveObject(mainOLV.SelectedObject);
		}

		private void HandleMainOLVSelectedIndexChanged(Object sender, EventArgs e)
		{
			removeButton.Enabled = mainOLV.SelectedObject != null;
		}

		private void HandleOkButtonClick(Object sender, EventArgs e)
		{
			m_album = new Album
			{
				Performer = performerTextBox.Text,
				Title = albumTextBox.Text,
				Tracks = new List<Track>(),
			};

			foreach (var item in mainOLV.Objects.Cast<ListViewModel>().OrderBy(t => t.DisplayIndex))
				m_album.Tracks.Add(new Track { Album = m_album, Title = item.Track, Data = File.ReadAllBytes(item.FileName) });
		}


		// Public Methods

		public Album GetAlbum()
		{
			return m_album;
		}
	}

	public class ListViewModel
	{
		public Int32 DisplayIndex { get; set; }
		public String Performer { get; set; }
		public String Album { get; set; }
		public String Track { get; set; }
		public String TrackNo { get; set; }
		public String FileName { get; set; }
	}
}
