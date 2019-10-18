namespace ElKanzo.TonuinoCardFormatter
{
	partial class ImportDialog
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.mainOLV = new BrightIdeasSoftware.ObjectListView();
			this.rowNoOlvCol = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.performerOlvCol = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.albumOlvCol = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.trackOlvCol = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.titleOlvCol = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.pictureBox = new System.Windows.Forms.PictureBox();
			this.okButton = new System.Windows.Forms.Button();
			this.cancelButton = new System.Windows.Forms.Button();
			this.addPictureButton = new System.Windows.Forms.Button();
			this.performerTextBox = new System.Windows.Forms.TextBox();
			this.albumTextBox = new System.Windows.Forms.TextBox();
			this.removeButton = new System.Windows.Forms.Button();
			this.mp3Label = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.performerLabel = new System.Windows.Forms.Label();
			this.albumLabel = new System.Windows.Forms.Label();
			this.pictureCheckBox = new System.Windows.Forms.CheckBox();
			this.fileNameolvCol = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			((System.ComponentModel.ISupportInitialize)(this.mainOLV)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// mainOLV
			// 
			this.mainOLV.AllColumns.Add(this.rowNoOlvCol);
			this.mainOLV.AllColumns.Add(this.performerOlvCol);
			this.mainOLV.AllColumns.Add(this.albumOlvCol);
			this.mainOLV.AllColumns.Add(this.trackOlvCol);
			this.mainOLV.AllColumns.Add(this.titleOlvCol);
			this.mainOLV.AllColumns.Add(this.fileNameolvCol);
			this.mainOLV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.mainOLV.CellEditUseWholeCell = false;
			this.mainOLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.rowNoOlvCol,
            this.performerOlvCol,
            this.albumOlvCol,
            this.trackOlvCol,
            this.titleOlvCol,
            this.fileNameolvCol});
			this.mainOLV.Cursor = System.Windows.Forms.Cursors.Default;
			this.mainOLV.FullRowSelect = true;
			this.mainOLV.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.mainOLV.HideSelection = false;
			this.mainOLV.Location = new System.Drawing.Point(12, 25);
			this.mainOLV.Name = "mainOLV";
			this.mainOLV.ShowGroups = false;
			this.mainOLV.Size = new System.Drawing.Size(729, 242);
			this.mainOLV.TabIndex = 0;
			this.mainOLV.UseCompatibleStateImageBehavior = false;
			this.mainOLV.View = System.Windows.Forms.View.Details;
			this.mainOLV.SelectedIndexChanged += new System.EventHandler(this.HandleMainOLVSelectedIndexChanged);
			// 
			// rowNoOlvCol
			// 
			this.rowNoOlvCol.Text = "Nr.";
			this.rowNoOlvCol.Width = 30;
			// 
			// performerOlvCol
			// 
			this.performerOlvCol.AspectName = "Performer";
			this.performerOlvCol.Text = "Künstler";
			this.performerOlvCol.Width = 100;
			// 
			// albumOlvCol
			// 
			this.albumOlvCol.AspectName = "Album";
			this.albumOlvCol.Text = "Album";
			this.albumOlvCol.Width = 100;
			// 
			// trackOlvCol
			// 
			this.trackOlvCol.AspectName = "TrackNo";
			this.trackOlvCol.Text = "Track Nr.";
			this.trackOlvCol.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// titleOlvCol
			// 
			this.titleOlvCol.AspectName = "Track";
			this.titleOlvCol.Text = "Titel";
			this.titleOlvCol.Width = 130;
			// 
			// pictureBox
			// 
			this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox.Location = new System.Drawing.Point(102, 306);
			this.pictureBox.Name = "pictureBox";
			this.pictureBox.Size = new System.Drawing.Size(335, 203);
			this.pictureBox.TabIndex = 1;
			this.pictureBox.TabStop = false;
			// 
			// okButton
			// 
			this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.okButton.Location = new System.Drawing.Point(666, 486);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(75, 23);
			this.okButton.TabIndex = 2;
			this.okButton.Text = "&OK";
			this.okButton.UseVisualStyleBackColor = true;
			this.okButton.Click += new System.EventHandler(this.HandleOkButtonClick);
			// 
			// cancelButton
			// 
			this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancelButton.Location = new System.Drawing.Point(747, 486);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(75, 23);
			this.cancelButton.TabIndex = 3;
			this.cancelButton.Text = "&Abbrechen";
			this.cancelButton.UseVisualStyleBackColor = true;
			// 
			// addPictureButton
			// 
			this.addPictureButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.addPictureButton.Enabled = false;
			this.addPictureButton.Location = new System.Drawing.Point(12, 486);
			this.addPictureButton.Name = "addPictureButton";
			this.addPictureButton.Size = new System.Drawing.Size(84, 23);
			this.addPictureButton.TabIndex = 4;
			this.addPictureButton.Text = "Durchsuchen";
			this.addPictureButton.UseVisualStyleBackColor = true;
			// 
			// performerTextBox
			// 
			this.performerTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.performerTextBox.Location = new System.Drawing.Point(497, 309);
			this.performerTextBox.Name = "performerTextBox";
			this.performerTextBox.Size = new System.Drawing.Size(325, 20);
			this.performerTextBox.TabIndex = 6;
			// 
			// albumTextBox
			// 
			this.albumTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.albumTextBox.Location = new System.Drawing.Point(497, 335);
			this.albumTextBox.Name = "albumTextBox";
			this.albumTextBox.Size = new System.Drawing.Size(325, 20);
			this.albumTextBox.TabIndex = 7;
			// 
			// removeButton
			// 
			this.removeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.removeButton.Enabled = false;
			this.removeButton.Location = new System.Drawing.Point(747, 244);
			this.removeButton.Name = "removeButton";
			this.removeButton.Size = new System.Drawing.Size(75, 23);
			this.removeButton.TabIndex = 8;
			this.removeButton.Text = "Entfernen";
			this.removeButton.UseVisualStyleBackColor = true;
			this.removeButton.Click += new System.EventHandler(this.HandleRemoveButtonClick);
			// 
			// mp3Label
			// 
			this.mp3Label.AutoSize = true;
			this.mp3Label.Location = new System.Drawing.Point(12, 9);
			this.mp3Label.Name = "mp3Label";
			this.mp3Label.Size = new System.Drawing.Size(133, 13);
			this.mp3Label.TabIndex = 9;
			this.mp3Label.Text = "Ausgewählte MP3 Dateien";
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 290);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(87, 13);
			this.label1.TabIndex = 10;
			this.label1.Text = "Albuminformation";
			// 
			// performerLabel
			// 
			this.performerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.performerLabel.AutoSize = true;
			this.performerLabel.Location = new System.Drawing.Point(443, 312);
			this.performerLabel.Name = "performerLabel";
			this.performerLabel.Size = new System.Drawing.Size(48, 13);
			this.performerLabel.TabIndex = 11;
			this.performerLabel.Text = "Künstler:";
			// 
			// albumLabel
			// 
			this.albumLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.albumLabel.AutoSize = true;
			this.albumLabel.Location = new System.Drawing.Point(443, 338);
			this.albumLabel.Name = "albumLabel";
			this.albumLabel.Size = new System.Drawing.Size(39, 13);
			this.albumLabel.TabIndex = 12;
			this.albumLabel.Text = "Album:";
			// 
			// pictureCheckBox
			// 
			this.pictureCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pictureCheckBox.AutoSize = true;
			this.pictureCheckBox.Enabled = false;
			this.pictureCheckBox.Location = new System.Drawing.Point(12, 306);
			this.pictureCheckBox.Name = "pictureCheckBox";
			this.pictureCheckBox.Size = new System.Drawing.Size(43, 17);
			this.pictureCheckBox.TabIndex = 13;
			this.pictureCheckBox.Text = "Bild";
			this.pictureCheckBox.UseVisualStyleBackColor = true;
			this.pictureCheckBox.CheckedChanged += new System.EventHandler(this.HandlePictureCheckBoxCheckedChanged);
			// 
			// fileNameolvCol
			// 
			this.fileNameolvCol.AspectName = "FileName";
			this.fileNameolvCol.FillsFreeSpace = true;
			this.fileNameolvCol.Text = "Datei";
			this.fileNameolvCol.Width = 300;
			// 
			// ImportDialog
			// 
			this.AcceptButton = this.okButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.cancelButton;
			this.ClientSize = new System.Drawing.Size(834, 521);
			this.Controls.Add(this.pictureCheckBox);
			this.Controls.Add(this.albumLabel);
			this.Controls.Add(this.performerLabel);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.mp3Label);
			this.Controls.Add(this.removeButton);
			this.Controls.Add(this.albumTextBox);
			this.Controls.Add(this.performerTextBox);
			this.Controls.Add(this.addPictureButton);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.okButton);
			this.Controls.Add(this.pictureBox);
			this.Controls.Add(this.mainOLV);
			this.MinimumSize = new System.Drawing.Size(850, 560);
			this.Name = "ImportDialog";
			this.Text = "ImportDialog";
			((System.ComponentModel.ISupportInitialize)(this.mainOLV)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private BrightIdeasSoftware.ObjectListView mainOLV;
		private BrightIdeasSoftware.OLVColumn rowNoOlvCol;
		private BrightIdeasSoftware.OLVColumn trackOlvCol;
		private BrightIdeasSoftware.OLVColumn titleOlvCol;
		private BrightIdeasSoftware.OLVColumn albumOlvCol;
		private BrightIdeasSoftware.OLVColumn performerOlvCol;
		private System.Windows.Forms.PictureBox pictureBox;
		private System.Windows.Forms.Button okButton;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.Button addPictureButton;
		private System.Windows.Forms.TextBox performerTextBox;
		private System.Windows.Forms.TextBox albumTextBox;
		private System.Windows.Forms.Button removeButton;
		private System.Windows.Forms.Label mp3Label;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label performerLabel;
		private System.Windows.Forms.Label albumLabel;
		private System.Windows.Forms.CheckBox pictureCheckBox;
		private BrightIdeasSoftware.OLVColumn fileNameolvCol;
	}
}