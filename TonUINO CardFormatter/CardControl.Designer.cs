namespace ElKanzo.TonuinoCardFormatter
{
	partial class CardControl
	{
		/// <summary> 
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Komponenten-Designer generierter Code

		/// <summary> 
		/// Erforderliche Methode für die Designerunterstützung. 
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.modeComboBox = new System.Windows.Forms.ComboBox();
			this.versionComboBox = new System.Windows.Forms.ComboBox();
			this.idValueLabel = new System.Windows.Forms.Label();
			this.cardPresentLabel = new System.Windows.Forms.Label();
			this.idLabel = new System.Windows.Forms.Label();
			this.versionLabel = new System.Windows.Forms.Label();
			this.modeLabel = new System.Windows.Forms.Label();
			this.folderLabel = new System.Windows.Forms.Label();
			this.special1Label = new System.Windows.Forms.Label();
			this.special2Label = new System.Windows.Forms.Label();
			this.special1NumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.folderNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.special2NumericUpDown = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.special1NumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.folderNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.special2NumericUpDown)).BeginInit();
			this.SuspendLayout();
			// 
			// modeComboBox
			// 
			this.modeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.modeComboBox.FormattingEnabled = true;
			this.modeComboBox.Location = new System.Drawing.Point(62, 76);
			this.modeComboBox.Name = "modeComboBox";
			this.modeComboBox.Size = new System.Drawing.Size(100, 21);
			this.modeComboBox.TabIndex = 12;
			// 
			// versionComboBox
			// 
			this.versionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.versionComboBox.FormattingEnabled = true;
			this.versionComboBox.Location = new System.Drawing.Point(62, 49);
			this.versionComboBox.Name = "versionComboBox";
			this.versionComboBox.Size = new System.Drawing.Size(100, 21);
			this.versionComboBox.TabIndex = 11;
			// 
			// idValueLabel
			// 
			this.idValueLabel.AutoSize = true;
			this.idValueLabel.Location = new System.Drawing.Point(59, 30);
			this.idValueLabel.Name = "idValueLabel";
			this.idValueLabel.Size = new System.Drawing.Size(64, 13);
			this.idValueLabel.TabIndex = 9;
			this.idValueLabel.Text = "11-22-33-44";
			// 
			// cardPresentLabel
			// 
			this.cardPresentLabel.AutoSize = true;
			this.cardPresentLabel.Location = new System.Drawing.Point(3, 6);
			this.cardPresentLabel.Name = "cardPresentLabel";
			this.cardPresentLabel.Size = new System.Drawing.Size(62, 13);
			this.cardPresentLabel.TabIndex = 8;
			this.cardPresentLabel.Text = "Keine Karte";
			// 
			// idLabel
			// 
			this.idLabel.AutoSize = true;
			this.idLabel.Location = new System.Drawing.Point(3, 30);
			this.idLabel.Name = "idLabel";
			this.idLabel.Size = new System.Drawing.Size(21, 13);
			this.idLabel.TabIndex = 15;
			this.idLabel.Text = "ID:";
			// 
			// versionLabel
			// 
			this.versionLabel.AutoSize = true;
			this.versionLabel.Location = new System.Drawing.Point(3, 52);
			this.versionLabel.Name = "versionLabel";
			this.versionLabel.Size = new System.Drawing.Size(45, 13);
			this.versionLabel.TabIndex = 16;
			this.versionLabel.Text = "Version:";
			// 
			// modeLabel
			// 
			this.modeLabel.AutoSize = true;
			this.modeLabel.Location = new System.Drawing.Point(3, 79);
			this.modeLabel.Name = "modeLabel";
			this.modeLabel.Size = new System.Drawing.Size(42, 13);
			this.modeLabel.TabIndex = 17;
			this.modeLabel.Text = "Modus:";
			// 
			// folderLabel
			// 
			this.folderLabel.AutoSize = true;
			this.folderLabel.Location = new System.Drawing.Point(3, 105);
			this.folderLabel.Name = "folderLabel";
			this.folderLabel.Size = new System.Drawing.Size(42, 13);
			this.folderLabel.TabIndex = 18;
			this.folderLabel.Text = "Ordner:";
			// 
			// special1Label
			// 
			this.special1Label.AutoSize = true;
			this.special1Label.Location = new System.Drawing.Point(3, 131);
			this.special1Label.Name = "special1Label";
			this.special1Label.Size = new System.Drawing.Size(53, 13);
			this.special1Label.TabIndex = 19;
			this.special1Label.Text = "Spezial 1:";
			// 
			// special2Label
			// 
			this.special2Label.AutoSize = true;
			this.special2Label.Location = new System.Drawing.Point(3, 157);
			this.special2Label.Name = "special2Label";
			this.special2Label.Size = new System.Drawing.Size(53, 13);
			this.special2Label.TabIndex = 20;
			this.special2Label.Text = "Spezial 2:";
			// 
			// special1NumericUpDown
			// 
			this.special1NumericUpDown.Location = new System.Drawing.Point(62, 129);
			this.special1NumericUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.special1NumericUpDown.Name = "special1NumericUpDown";
			this.special1NumericUpDown.Size = new System.Drawing.Size(100, 20);
			this.special1NumericUpDown.TabIndex = 21;
			// 
			// folderNumericUpDown
			// 
			this.folderNumericUpDown.Location = new System.Drawing.Point(62, 103);
			this.folderNumericUpDown.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
			this.folderNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.folderNumericUpDown.Name = "folderNumericUpDown";
			this.folderNumericUpDown.Size = new System.Drawing.Size(100, 20);
			this.folderNumericUpDown.TabIndex = 22;
			this.folderNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// special2NumericUpDown
			// 
			this.special2NumericUpDown.Location = new System.Drawing.Point(62, 155);
			this.special2NumericUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.special2NumericUpDown.Name = "special2NumericUpDown";
			this.special2NumericUpDown.Size = new System.Drawing.Size(100, 20);
			this.special2NumericUpDown.TabIndex = 23;
			// 
			// CardControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.special2NumericUpDown);
			this.Controls.Add(this.folderNumericUpDown);
			this.Controls.Add(this.special1NumericUpDown);
			this.Controls.Add(this.special2Label);
			this.Controls.Add(this.special1Label);
			this.Controls.Add(this.folderLabel);
			this.Controls.Add(this.modeLabel);
			this.Controls.Add(this.versionLabel);
			this.Controls.Add(this.idLabel);
			this.Controls.Add(this.modeComboBox);
			this.Controls.Add(this.versionComboBox);
			this.Controls.Add(this.idValueLabel);
			this.Controls.Add(this.cardPresentLabel);
			this.Name = "CardControl";
			this.Size = new System.Drawing.Size(165, 178);
			((System.ComponentModel.ISupportInitialize)(this.special1NumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.folderNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.special2NumericUpDown)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.ComboBox modeComboBox;
		private System.Windows.Forms.ComboBox versionComboBox;
		private System.Windows.Forms.Label idValueLabel;
		private System.Windows.Forms.Label cardPresentLabel;
		private System.Windows.Forms.Label idLabel;
		private System.Windows.Forms.Label versionLabel;
		private System.Windows.Forms.Label modeLabel;
		private System.Windows.Forms.Label folderLabel;
		private System.Windows.Forms.Label special1Label;
		private System.Windows.Forms.Label special2Label;
		private System.Windows.Forms.NumericUpDown special1NumericUpDown;
		private System.Windows.Forms.NumericUpDown folderNumericUpDown;
		private System.Windows.Forms.NumericUpDown special2NumericUpDown;
	}
}
