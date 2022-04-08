
namespace Life.FRNS
{
    partial class FormSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSettings));
            this.buttonAccept = new System.Windows.Forms.Button();
            this.numericUpDownResolution = new System.Windows.Forms.NumericUpDown();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.numericUpDownDensity = new System.Windows.Forms.NumericUpDown();
            this.labelDensity = new System.Windows.Forms.Label();
            this.labelResolution = new System.Windows.Forms.Label();
            this.buttonDefault = new System.Windows.Forms.Button();
            this.comboBoxBackgroundColor = new System.Windows.Forms.ComboBox();
            this.comboBoxCellColor = new System.Windows.Forms.ComboBox();
            this.buttonUpload = new System.Windows.Forms.Button();
            this.checkBoxImage = new System.Windows.Forms.CheckBox();
            this.labelSettings = new System.Windows.Forms.Label();
            this.labelCellColor = new System.Windows.Forms.Label();
            this.labelBackgroundСolor = new System.Windows.Forms.Label();
            this.buttonHelpCellColor = new System.Windows.Forms.Button();
            this.buttonHelpBackgroundColor = new System.Windows.Forms.Button();
            this.buttonHelpResolution = new System.Windows.Forms.Button();
            this.buttonHelpDensity = new System.Windows.Forms.Button();
            this.buttonHelpImage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownResolution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDensity)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAccept
            // 
            this.buttonAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAccept.Location = new System.Drawing.Point(182, 200);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(140, 24);
            this.buttonAccept.TabIndex = 12;
            this.buttonAccept.Text = "Accept";
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // numericUpDownResolution
            // 
            this.numericUpDownResolution.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownResolution.Location = new System.Drawing.Point(182, 155);
            this.numericUpDownResolution.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericUpDownResolution.Minimum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numericUpDownResolution.Name = "numericUpDownResolution";
            this.numericUpDownResolution.ReadOnly = true;
            this.numericUpDownResolution.Size = new System.Drawing.Size(109, 22);
            this.numericUpDownResolution.TabIndex = 7;
            this.numericUpDownResolution.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownResolution.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numericUpDownResolution.ValueChanged += new System.EventHandler(this.numericUpDownResolution_ValueChanged);
            // 
            // buttonMenu
            // 
            this.buttonMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMenu.Location = new System.Drawing.Point(182, 260);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(140, 24);
            this.buttonMenu.TabIndex = 14;
            this.buttonMenu.Text = "Close";
            this.buttonMenu.UseVisualStyleBackColor = true;
            this.buttonMenu.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // numericUpDownDensity
            // 
            this.numericUpDownDensity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownDensity.Location = new System.Drawing.Point(182, 101);
            this.numericUpDownDensity.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDownDensity.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownDensity.Name = "numericUpDownDensity";
            this.numericUpDownDensity.ReadOnly = true;
            this.numericUpDownDensity.Size = new System.Drawing.Size(109, 22);
            this.numericUpDownDensity.TabIndex = 5;
            this.numericUpDownDensity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownDensity.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownDensity.ValueChanged += new System.EventHandler(this.numericUpDownDensity_ValueChanged);
            // 
            // labelDensity
            // 
            this.labelDensity.AutoSize = true;
            this.labelDensity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDensity.Location = new System.Drawing.Point(179, 85);
            this.labelDensity.Name = "labelDensity";
            this.labelDensity.Size = new System.Drawing.Size(53, 16);
            this.labelDensity.TabIndex = 11;
            this.labelDensity.Text = "Density";
            // 
            // labelResolution
            // 
            this.labelResolution.AutoSize = true;
            this.labelResolution.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResolution.Location = new System.Drawing.Point(179, 138);
            this.labelResolution.Name = "labelResolution";
            this.labelResolution.Size = new System.Drawing.Size(72, 16);
            this.labelResolution.TabIndex = 13;
            this.labelResolution.Text = "Resolution";
            // 
            // buttonDefault
            // 
            this.buttonDefault.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDefault.Location = new System.Drawing.Point(182, 230);
            this.buttonDefault.Name = "buttonDefault";
            this.buttonDefault.Size = new System.Drawing.Size(140, 24);
            this.buttonDefault.TabIndex = 13;
            this.buttonDefault.Text = "Default";
            this.buttonDefault.UseVisualStyleBackColor = true;
            this.buttonDefault.Click += new System.EventHandler(this.buttonDefault_Click);
            // 
            // comboBoxBackgroundColor
            // 
            this.comboBoxBackgroundColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBackgroundColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxBackgroundColor.FormattingEnabled = true;
            this.comboBoxBackgroundColor.Location = new System.Drawing.Point(19, 155);
            this.comboBoxBackgroundColor.Name = "comboBoxBackgroundColor";
            this.comboBoxBackgroundColor.Size = new System.Drawing.Size(109, 24);
            this.comboBoxBackgroundColor.TabIndex = 3;
            this.comboBoxBackgroundColor.SelectedIndexChanged += new System.EventHandler(this.comboBoxBackgroundColor_SelectedIndexChanged);
            // 
            // comboBoxCellColor
            // 
            this.comboBoxCellColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCellColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxCellColor.Location = new System.Drawing.Point(19, 101);
            this.comboBoxCellColor.Name = "comboBoxCellColor";
            this.comboBoxCellColor.Size = new System.Drawing.Size(109, 24);
            this.comboBoxCellColor.TabIndex = 1;
            this.comboBoxCellColor.SelectedIndexChanged += new System.EventHandler(this.comboBoxCellColor_SelectedIndexChanged);
            // 
            // buttonUpload
            // 
            this.buttonUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUpload.Location = new System.Drawing.Point(18, 260);
            this.buttonUpload.Name = "buttonUpload";
            this.buttonUpload.Size = new System.Drawing.Size(140, 24);
            this.buttonUpload.TabIndex = 11;
            this.buttonUpload.Text = "Upload";
            this.buttonUpload.UseVisualStyleBackColor = true;
            this.buttonUpload.Click += new System.EventHandler(this.buttonUpload_Click);
            // 
            // checkBoxImage
            // 
            this.checkBoxImage.AutoSize = true;
            this.checkBoxImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxImage.Location = new System.Drawing.Point(18, 230);
            this.checkBoxImage.Name = "checkBoxImage";
            this.checkBoxImage.Size = new System.Drawing.Size(110, 20);
            this.checkBoxImage.TabIndex = 9;
            this.checkBoxImage.Text = "Use image?";
            this.checkBoxImage.UseVisualStyleBackColor = true;
            this.checkBoxImage.CheckedChanged += new System.EventHandler(this.checkBoxImage_CheckedChanged);
            // 
            // labelSettings
            // 
            this.labelSettings.AutoSize = true;
            this.labelSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 44F, System.Drawing.FontStyle.Bold);
            this.labelSettings.ForeColor = System.Drawing.Color.Black;
            this.labelSettings.Location = new System.Drawing.Point(7, 9);
            this.labelSettings.Name = "labelSettings";
            this.labelSettings.Size = new System.Drawing.Size(331, 67);
            this.labelSettings.TabIndex = 21;
            this.labelSettings.Text = "SETTINGS";
            // 
            // labelCellColor
            // 
            this.labelCellColor.AutoSize = true;
            this.labelCellColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCellColor.Location = new System.Drawing.Point(16, 85);
            this.labelCellColor.Name = "labelCellColor";
            this.labelCellColor.Size = new System.Drawing.Size(64, 16);
            this.labelCellColor.TabIndex = 22;
            this.labelCellColor.Text = "Cell color";
            // 
            // labelBackgroundСolor
            // 
            this.labelBackgroundСolor.AutoSize = true;
            this.labelBackgroundСolor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBackgroundСolor.Location = new System.Drawing.Point(16, 138);
            this.labelBackgroundСolor.Name = "labelBackgroundСolor";
            this.labelBackgroundСolor.Size = new System.Drawing.Size(114, 16);
            this.labelBackgroundСolor.TabIndex = 23;
            this.labelBackgroundСolor.Text = "Background color";
            // 
            // buttonHelpCellColor
            // 
            this.buttonHelpCellColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.buttonHelpCellColor.Location = new System.Drawing.Point(134, 101);
            this.buttonHelpCellColor.Name = "buttonHelpCellColor";
            this.buttonHelpCellColor.Size = new System.Drawing.Size(24, 24);
            this.buttonHelpCellColor.TabIndex = 2;
            this.buttonHelpCellColor.Text = "?";
            this.buttonHelpCellColor.UseVisualStyleBackColor = true;
            this.buttonHelpCellColor.Click += new System.EventHandler(this.buttonHelpCellColor_Click);
            // 
            // buttonHelpBackgroundColor
            // 
            this.buttonHelpBackgroundColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.buttonHelpBackgroundColor.Location = new System.Drawing.Point(134, 155);
            this.buttonHelpBackgroundColor.Name = "buttonHelpBackgroundColor";
            this.buttonHelpBackgroundColor.Size = new System.Drawing.Size(24, 24);
            this.buttonHelpBackgroundColor.TabIndex = 4;
            this.buttonHelpBackgroundColor.Text = "?";
            this.buttonHelpBackgroundColor.UseVisualStyleBackColor = true;
            this.buttonHelpBackgroundColor.Click += new System.EventHandler(this.buttonHelpBackgroundColor_Click);
            // 
            // buttonHelpResolution
            // 
            this.buttonHelpResolution.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.buttonHelpResolution.Location = new System.Drawing.Point(298, 154);
            this.buttonHelpResolution.Name = "buttonHelpResolution";
            this.buttonHelpResolution.Size = new System.Drawing.Size(24, 24);
            this.buttonHelpResolution.TabIndex = 8;
            this.buttonHelpResolution.Text = "?";
            this.buttonHelpResolution.UseVisualStyleBackColor = true;
            this.buttonHelpResolution.Click += new System.EventHandler(this.buttonHelpResolution_Click);
            // 
            // buttonHelpDensity
            // 
            this.buttonHelpDensity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.buttonHelpDensity.Location = new System.Drawing.Point(298, 100);
            this.buttonHelpDensity.Name = "buttonHelpDensity";
            this.buttonHelpDensity.Size = new System.Drawing.Size(24, 24);
            this.buttonHelpDensity.TabIndex = 6;
            this.buttonHelpDensity.Text = "?";
            this.buttonHelpDensity.UseVisualStyleBackColor = true;
            this.buttonHelpDensity.Click += new System.EventHandler(this.buttonHelpDensity_Click);
            // 
            // buttonHelpImage
            // 
            this.buttonHelpImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.buttonHelpImage.Location = new System.Drawing.Point(134, 228);
            this.buttonHelpImage.Name = "buttonHelpImage";
            this.buttonHelpImage.Size = new System.Drawing.Size(24, 24);
            this.buttonHelpImage.TabIndex = 10;
            this.buttonHelpImage.Text = "?";
            this.buttonHelpImage.UseVisualStyleBackColor = true;
            this.buttonHelpImage.Click += new System.EventHandler(this.buttonHelpImage_Click);
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 304);
            this.ControlBox = false;
            this.Controls.Add(this.buttonHelpImage);
            this.Controls.Add(this.buttonHelpDensity);
            this.Controls.Add(this.buttonHelpResolution);
            this.Controls.Add(this.buttonHelpBackgroundColor);
            this.Controls.Add(this.buttonHelpCellColor);
            this.Controls.Add(this.labelBackgroundСolor);
            this.Controls.Add(this.labelCellColor);
            this.Controls.Add(this.labelSettings);
            this.Controls.Add(this.checkBoxImage);
            this.Controls.Add(this.buttonUpload);
            this.Controls.Add(this.comboBoxCellColor);
            this.Controls.Add(this.comboBoxBackgroundColor);
            this.Controls.Add(this.buttonDefault);
            this.Controls.Add(this.labelResolution);
            this.Controls.Add(this.numericUpDownDensity);
            this.Controls.Add(this.labelDensity);
            this.Controls.Add(this.buttonMenu);
            this.Controls.Add(this.numericUpDownResolution);
            this.Controls.Add(this.buttonAccept);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game \"Cell\" - Settings";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownResolution)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDensity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button buttonAccept;
        public System.Windows.Forms.NumericUpDown numericUpDownResolution;
        private System.Windows.Forms.Button buttonMenu;
        public System.Windows.Forms.NumericUpDown numericUpDownDensity;
        private System.Windows.Forms.Label labelDensity;
        private System.Windows.Forms.Label labelResolution;
        public System.Windows.Forms.Button buttonDefault;
        public System.Windows.Forms.ComboBox comboBoxBackgroundColor;
        public System.Windows.Forms.ComboBox comboBoxCellColor;
        private System.Windows.Forms.Button buttonUpload;
        public System.Windows.Forms.CheckBox checkBoxImage;
        private System.Windows.Forms.Label labelSettings;
        private System.Windows.Forms.Label labelCellColor;
        private System.Windows.Forms.Label labelBackgroundСolor;
        private System.Windows.Forms.Button buttonHelpCellColor;
        private System.Windows.Forms.Button buttonHelpBackgroundColor;
        private System.Windows.Forms.Button buttonHelpResolution;
        private System.Windows.Forms.Button buttonHelpDensity;
        private System.Windows.Forms.Button buttonHelpImage;
    }
}