using System;

namespace ElKanzo.TonuinoCardFormatter
{
	partial class MainForm
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		protected override void Dispose(Boolean disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.tabControl = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.importButton = new System.Windows.Forms.Button();
			this.sdDirLabel = new System.Windows.Forms.Label();
			this.sdDirTextBox = new System.Windows.Forms.TextBox();
			this.selectSdDirButton = new System.Windows.Forms.Button();
			this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.activeCardControl = new ElKanzo.TonuinoCardFormatter.CardControl();
			this.newSettingsCardControl = new ElKanzo.TonuinoCardFormatter.CardControl();
			this.writeSettingsButton = new System.Windows.Forms.Button();
			this.tabControl.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl
			// 
			this.tabControl.Controls.Add(this.tabPage1);
			this.tabControl.Controls.Add(this.tabPage2);
			this.tabControl.Location = new System.Drawing.Point(364, 0);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(376, 489);
			this.tabControl.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(368, 463);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "RFID Card";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.importButton);
			this.tabPage2.Controls.Add(this.sdDirLabel);
			this.tabPage2.Controls.Add(this.sdDirTextBox);
			this.tabPage2.Controls.Add(this.selectSdDirButton);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(368, 463);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "SD Card";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// importButton
			// 
			this.importButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.importButton.Location = new System.Drawing.Point(627, 432);
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
			this.sdDirLabel.Location = new System.Drawing.Point(8, 12);
			this.sdDirLabel.Name = "sdDirLabel";
			this.sdDirLabel.Size = new System.Drawing.Size(64, 13);
			this.sdDirLabel.TabIndex = 3;
			this.sdDirLabel.Text = "Verzeichnis:";
			// 
			// sdDirTextBox
			// 
			this.sdDirTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.sdDirTextBox.Enabled = false;
			this.sdDirTextBox.Location = new System.Drawing.Point(78, 8);
			this.sdDirTextBox.Name = "sdDirTextBox";
			this.sdDirTextBox.Size = new System.Drawing.Size(543, 20);
			this.sdDirTextBox.TabIndex = 2;
			// 
			// selectSdDirButton
			// 
			this.selectSdDirButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.selectSdDirButton.Location = new System.Drawing.Point(627, 6);
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
			this.newSettingsCardControl.Location = new System.Drawing.Point(12, 254);
			this.newSettingsCardControl.Name = "newSettingsCardControl";
			this.newSettingsCardControl.Size = new System.Drawing.Size(165, 178);
			this.newSettingsCardControl.TabIndex = 2;
			// 
			// writeSettingsButton
			// 
			this.writeSettingsButton.Location = new System.Drawing.Point(12, 225);
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
			this.ClientSize = new System.Drawing.Size(740, 470);
			this.Controls.Add(this.writeSettingsButton);
			this.Controls.Add(this.newSettingsCardControl);
			this.Controls.Add(this.activeCardControl);
			this.Controls.Add(this.tabControl);
			this.Name = "MainForm";
			this.Text = "TonUINO Card Formatter";
			this.tabControl.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
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

