using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BrightIdeasSoftware;
using log4net;

namespace ElKanzo.TonuinoCardFormatter
{
	public partial class ImportDialog : Form
	{
		// Class variables
		private static readonly ILog m_logger = LogManager.GetLogger(typeof(ImportDialog));


		// Constructor
		public ImportDialog(String[] fileNames)
		{
			InitializeComponent();
			mainOLV.FormatRow += HandleFormatRow;
			mainOLV.DragSource = new SimpleDragSource();
			mainOLV.DropSink = new RearrangingDropSink(false);

			List<ListViewModel> listViewItems = new List<ListViewModel>();
			foreach (String file in fileNames)
			{
				using (TagLib.File fileInfo = TagLib.File.Create(file))
				{
					listViewItems.Add(new ListViewModel { Performer = fileInfo.Tag.JoinedPerformers, Album = fileInfo.Tag.Album, Title = fileInfo.Tag.Title, TrackNo = fileInfo.Tag.Track.ToString() });
				}
			}
			mainOLV.SetObjects(listViewItems);
		}


		// Events

		private void HandleFormatRow(Object sender, FormatRowEventArgs e)
		{
			e.Item.SubItems[0].Text = $"{e.DisplayIndex + 1:000}";
		}

		private void HandlePictureCheckBoxCheckedChanged(Object sender, EventArgs e)
		{
			addPictureButton.Enabled = pictureCheckBox.Checked;

		}
	}

	public class ListViewModel
	{
		public String Performer { get; set; }
		public String TrackNo { get; set; }
		public String Title { get; set; }
		public String Album { get; set; }
	}
}
