
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
            this.nudResolution = new System.Windows.Forms.NumericUpDown();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.nudDensity = new System.Windows.Forms.NumericUpDown();
            this.labelDensity = new System.Windows.Forms.Label();
            this.labelResolution = new System.Windows.Forms.Label();
            this.buttonDefault = new System.Windows.Forms.Button();
            this.comboBoxDisplay = new System.Windows.Forms.ComboBox();
            this.comboBoxElements = new System.Windows.Forms.ComboBox();
            this.buttonUpload = new System.Windows.Forms.Button();
            this.checkBoxImage = new System.Windows.Forms.CheckBox();
            this.labelSettings = new System.Windows.Forms.Label();
            this.labelCellColor = new System.Windows.Forms.Label();
            this.labelBackgroundСolor = new System.Windows.Forms.Label();
            this.buttonHelpCellColor = new System.Windows.Forms.Button();
            this.buttonHelpBackgroundcolor = new System.Windows.Forms.Button();
            this.buttonHelpResolution = new System.Windows.Forms.Button();
            this.buttonHelpDensity = new System.Windows.Forms.Button();
            this.buttonHelpImage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudResolution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDensity)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAccept
            // 
            this.buttonAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAccept.Location = new System.Drawing.Point(182, 200);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(140, 24);
            this.buttonAccept.TabIndex = 1;
            this.buttonAccept.Text = "Accept";
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // nudResolution
            // 
            this.nudResolution.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudResolution.Location = new System.Drawing.Point(182, 155);
            this.nudResolution.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudResolution.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudResolution.Name = "nudResolution";
            this.nudResolution.ReadOnly = true;
            this.nudResolution.Size = new System.Drawing.Size(109, 24);
            this.nudResolution.TabIndex = 6;
            this.nudResolution.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudResolution.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudResolution.ValueChanged += new System.EventHandler(this.nudResolution_ValueChanged);
            // 
            // buttonMenu
            // 
            this.buttonMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMenu.Location = new System.Drawing.Point(182, 260);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(140, 24);
            this.buttonMenu.TabIndex = 9;
            this.buttonMenu.Text = "Close";
            this.buttonMenu.UseVisualStyleBackColor = true;
            this.buttonMenu.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // nudDensity
            // 
            this.nudDensity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudDensity.Location = new System.Drawing.Point(182, 99);
            this.nudDensity.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nudDensity.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudDensity.Name = "nudDensity";
            this.nudDensity.ReadOnly = true;
            this.nudDensity.Size = new System.Drawing.Size(109, 22);
            this.nudDensity.TabIndex = 12;
            this.nudDensity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudDensity.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudDensity.ValueChanged += new System.EventHandler(this.nudDensity_ValueChanged);
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
            this.buttonDefault.TabIndex = 14;
            this.buttonDefault.Text = "Default";
            this.buttonDefault.UseVisualStyleBackColor = true;
            this.buttonDefault.Click += new System.EventHandler(this.buttonDefault_Click);
            // 
            // comboBoxDisplay
            // 
            this.comboBoxDisplay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxDisplay.FormattingEnabled = true;
            this.comboBoxDisplay.Location = new System.Drawing.Point(19, 155);
            this.comboBoxDisplay.Name = "comboBoxDisplay";
            this.comboBoxDisplay.Size = new System.Drawing.Size(109, 24);
            this.comboBoxDisplay.TabIndex = 15;
            this.comboBoxDisplay.SelectedIndexChanged += new System.EventHandler(this.comboBoxDisplay_SelectedIndexChanged);
            // 
            // comboBoxElements
            // 
            this.comboBoxElements.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxElements.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxElements.FormattingEnabled = true;
            this.comboBoxElements.Location = new System.Drawing.Point(19, 101);
            this.comboBoxElements.Name = "comboBoxElements";
            this.comboBoxElements.Size = new System.Drawing.Size(109, 24);
            this.comboBoxElements.TabIndex = 16;
            this.comboBoxElements.SelectedIndexChanged += new System.EventHandler(this.comboBoxElements_SelectedIndexChanged);
            // 
            // buttonUpload
            // 
            this.buttonUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUpload.Location = new System.Drawing.Point(19, 260);
            this.buttonUpload.Name = "buttonUpload";
            this.buttonUpload.Size = new System.Drawing.Size(139, 24);
            this.buttonUpload.TabIndex = 19;
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
            this.checkBoxImage.TabIndex = 20;
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
            this.buttonHelpCellColor.Location = new System.Drawing.Point(134, 101);
            this.buttonHelpCellColor.Name = "buttonHelpCellColor";
            this.buttonHelpCellColor.Size = new System.Drawing.Size(24, 24);
            this.buttonHelpCellColor.TabIndex = 24;
            this.buttonHelpCellColor.Text = "?";
            this.buttonHelpCellColor.UseVisualStyleBackColor = true;
            this.buttonHelpCellColor.Click += new System.EventHandler(this.buttonHelpCellColor_Click);
            // 
            // buttonHelpBackgroundcolor
            // 
            this.buttonHelpBackgroundcolor.Location = new System.Drawing.Point(134, 156);
            this.buttonHelpBackgroundcolor.Name = "buttonHelpBackgroundcolor";
            this.buttonHelpBackgroundcolor.Size = new System.Drawing.Size(24, 24);
            this.buttonHelpBackgroundcolor.TabIndex = 25;
            this.buttonHelpBackgroundcolor.Text = "?";
            this.buttonHelpBackgroundcolor.UseVisualStyleBackColor = true;
            this.buttonHelpBackgroundcolor.Click += new System.EventHandler(this.buttonHelpBackgroundcolor_Click);
            // 
            // buttonHelpResolution
            // 
            this.buttonHelpResolution.Location = new System.Drawing.Point(298, 155);
            this.buttonHelpResolution.Name = "buttonHelpResolution";
            this.buttonHelpResolution.Size = new System.Drawing.Size(24, 24);
            this.buttonHelpResolution.TabIndex = 26;
            this.buttonHelpResolution.Text = "?";
            this.buttonHelpResolution.UseVisualStyleBackColor = true;
            this.buttonHelpResolution.Click += new System.EventHandler(this.buttonHelpResolution_Click);
            // 
            // buttonHelpDensity
            // 
            this.buttonHelpDensity.Location = new System.Drawing.Point(298, 98);
            this.buttonHelpDensity.Name = "buttonHelpDensity";
            this.buttonHelpDensity.Size = new System.Drawing.Size(24, 24);
            this.buttonHelpDensity.TabIndex = 27;
            this.buttonHelpDensity.Text = "?";
            this.buttonHelpDensity.UseVisualStyleBackColor = true;
            this.buttonHelpDensity.Click += new System.EventHandler(this.buttonHelpDensity_Click);
            // 
            // buttonHelpImage
            // 
            this.buttonHelpImage.Location = new System.Drawing.Point(134, 228);
            this.buttonHelpImage.Name = "buttonHelpImage";
            this.buttonHelpImage.Size = new System.Drawing.Size(24, 24);
            this.buttonHelpImage.TabIndex = 28;
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
            this.Controls.Add(this.buttonHelpBackgroundcolor);
            this.Controls.Add(this.buttonHelpCellColor);
            this.Controls.Add(this.labelBackgroundСolor);
            this.Controls.Add(this.labelCellColor);
            this.Controls.Add(this.labelSettings);
            this.Controls.Add(this.checkBoxImage);
            this.Controls.Add(this.buttonUpload);
            this.Controls.Add(this.comboBoxElements);
            this.Controls.Add(this.comboBoxDisplay);
            this.Controls.Add(this.buttonDefault);
            this.Controls.Add(this.labelResolution);
            this.Controls.Add(this.nudDensity);
            this.Controls.Add(this.labelDensity);
            this.Controls.Add(this.buttonMenu);
            this.Controls.Add(this.nudResolution);
            this.Controls.Add(this.buttonAccept);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(356, 343);
            this.MinimumSize = new System.Drawing.Size(356, 343);
            this.Name = "FormSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game \"Cell\" - Settings";
            ((System.ComponentModel.ISupportInitialize)(this.nudResolution)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDensity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button buttonAccept;
        public System.Windows.Forms.NumericUpDown nudResolution;
        private System.Windows.Forms.Button buttonMenu;
        public System.Windows.Forms.NumericUpDown nudDensity;
        private System.Windows.Forms.Label labelDensity;
        private System.Windows.Forms.Label labelResolution;
        public System.Windows.Forms.Button buttonDefault;
        public System.Windows.Forms.ComboBox comboBoxDisplay;
        public System.Windows.Forms.ComboBox comboBoxElements;
        private System.Windows.Forms.Button buttonUpload;
        public System.Windows.Forms.CheckBox checkBoxImage;
        private System.Windows.Forms.Label labelSettings;
        private System.Windows.Forms.Label labelCellColor;
        private System.Windows.Forms.Label labelBackgroundСolor;
        private System.Windows.Forms.Button buttonHelpCellColor;
        private System.Windows.Forms.Button buttonHelpBackgroundcolor;
        private System.Windows.Forms.Button buttonHelpResolution;
        private System.Windows.Forms.Button buttonHelpDensity;
        private System.Windows.Forms.Button buttonHelpImage;
    }
}