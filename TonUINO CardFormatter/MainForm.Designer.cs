namespace ElKanzo.TonuinoCardFormatter
{
	partial class MainForm
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;


		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.importButton = new System.Windows.Forms.Button();
			this.sdDirLabel = new System.Windows.Forms.Label();
			this.sdDirTextBox = new System.Windows.Forms.TextBox();
			this.selectSdDirButton = new System.Windows.Forms.Button();
			this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.activeCardControl = new ElKanzo.TonuinoCardFormatter.CardControl();
			this.newSettingsCardControl = new ElKanzo.TonuinoCardFormatter.CardControl();
			this.writeSettingsButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// importButton
			// 
			this.importButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.importButton.Location = new System.Drawing.Point(575, 406);
			this.importButton.Name = "importButton";
			this.importButton.Size = new System.Drawing.Size(97, 23);
			this.importButton.TabIndex = 4;
			this.importButton.Text = "Importiere MP3s";
			this.importButton.UseVisualStyleBackColor = true;
			this.importButton.Click += new System.EventHandler(this.HandleImportButtonClick);
			// 
			// sdDirLabel
			// 
			this.sdDirLabel.AutoSize = true;
			this.sdDirLabel.Location = new System.Drawing.Point(233, 17);
			this.sdDirLabel.Name = "sdDirLabel";
			this.sdDirLabel.Size = new System.Drawing.Size(53, 13);
			this.sdDirLabel.TabIndex = 3;
			this.sdDirLabel.Text = "SD Karte:";
			// 
			// sdDirTextBox
			// 
			this.sdDirTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.sdDirTextBox.Enabled = false;
			this.sdDirTextBox.Location = new System.Drawing.Point(292, 14);
			this.sdDirTextBox.Name = "sdDirTextBox";
			this.sdDirTextBox.Size = new System.Drawing.Size(277, 20);
			this.sdDirTextBox.TabIndex = 2;
			// 
			// selectSdDirButton
			// 
			this.selectSdDirButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.selectSdDirButton.Location = new System.Drawing.Point(575, 12);
			this.selectSdDirButton.Name = "selectSdDirButton";
			this.selectSdDirButton.Size = new System.Drawing.Size(97, 23);
			this.selectSdDirButton.TabIndex = 1;
			this.selectSdDirButton.Text = "Durchsuchen";
			this.selectSdDirButton.UseVisualStyleBackColor = true;
			this.selectSdDirButton.Click += new System.EventHandler(this.HandleSelectSdDirButtonClick);
			// 
			// activeCardControl
			// 
			this.activeCardControl.Location = new System.Drawing.Point(12, 12);
			this.activeCardControl.Name = "activeCardControl";
			this.activeCardControl.Size = new System.Drawing.Size(165, 178);
			this.activeCardControl.TabIndex = 1;
			// 
			// newSettingsCardControl
			// 
			this.newSettingsCardControl.Location = new System.Drawing.Point(12, 251);
			this.newSettingsCardControl.Name = "newSettingsCardControl";
			this.newSettingsCardControl.Size = new System.Drawing.Size(165, 178);
			this.newSettingsCardControl.TabIndex = 2;
			// 
			// writeSettingsButton
			// 
			this.writeSettingsButton.Location = new System.Drawing.Point(12, 222);
			this.writeSettingsButton.Name = "writeSettingsButton";
			this.writeSettingsButton.Size = new System.Drawing.Size(165, 23);
			this.writeSettingsButton.TabIndex = 3;
			this.writeSettingsButton.Text = "Schreibe auf Karte";
			this.writeSettingsButton.UseVisualStyleBackColor = true;
			this.writeSettingsButton.Click += new System.EventHandler(this.HandleWriteSettingsButtonClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(684, 441);
			this.Controls.Add(this.selectSdDirButton);
			this.Controls.Add(this.sdDirLabel);
			this.Controls.Add(this.sdDirTextBox);
			this.Controls.Add(this.importButton);
			this.Controls.Add(this.writeSettingsButton);
			this.Controls.Add(this.newSettingsCardControl);
			this.Controls.Add(this.activeCardControl);
			this.MinimumSize = new System.Drawing.Size(700, 480);
			this.Name = "MainForm";
			this.Text = "TonUINO Card Formatter";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label sdDirLabel;
		private System.Windows.Forms.TextBox sdDirTextBox;
		private System.Windows.Forms.Button selectSdDirButton;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
		private System.Windows.Forms.Button importButton;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private CardControl activeCardControl;
		private CardControl newSettingsCardControl;
		private System.Windows.Forms.Button writeSettingsButton;
	}
}

