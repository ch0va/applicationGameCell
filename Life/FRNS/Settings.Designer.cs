
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
            this.buttonAccept = new System.Windows.Forms.Button();
            this.nudResolution = new System.Windows.Forms.NumericUpDown();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.nudDensity = new System.Windows.Forms.NumericUpDown();
            this.labelDensity = new System.Windows.Forms.Label();
            this.labelResolution = new System.Windows.Forms.Label();
            this.buttonDefault = new System.Windows.Forms.Button();
            this.comboBoxForms = new System.Windows.Forms.ComboBox();
            this.comboBoxElements = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudResolution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDensity)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAccept
            // 
            this.buttonAccept.Location = new System.Drawing.Point(284, 279);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(75, 23);
            this.buttonAccept.TabIndex = 1;
            this.buttonAccept.Text = "Accept";
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // nudResolution
            // 
            this.nudResolution.Location = new System.Drawing.Point(284, 210);
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
            this.nudResolution.Size = new System.Drawing.Size(89, 20);
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
            this.buttonMenu.Location = new System.Drawing.Point(284, 308);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(75, 23);
            this.buttonMenu.TabIndex = 9;
            this.buttonMenu.Text = "Menu";
            this.buttonMenu.UseVisualStyleBackColor = true;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // nudDensity
            // 
            this.nudDensity.Location = new System.Drawing.Point(284, 171);
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
            this.nudDensity.Size = new System.Drawing.Size(89, 20);
            this.nudDensity.TabIndex = 12;
            this.nudDensity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudDensity.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudDensity.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // labelDensity
            // 
            this.labelDensity.AutoSize = true;
            this.labelDensity.Location = new System.Drawing.Point(281, 155);
            this.labelDensity.Name = "labelDensity";
            this.labelDensity.Size = new System.Drawing.Size(42, 13);
            this.labelDensity.TabIndex = 11;
            this.labelDensity.Text = "Density";
            // 
            // labelResolution
            // 
            this.labelResolution.AutoSize = true;
            this.labelResolution.Location = new System.Drawing.Point(281, 194);
            this.labelResolution.Name = "labelResolution";
            this.labelResolution.Size = new System.Drawing.Size(57, 13);
            this.labelResolution.TabIndex = 13;
            this.labelResolution.Text = "Resolution";
            // 
            // buttonDefault
            // 
            this.buttonDefault.Location = new System.Drawing.Point(284, 250);
            this.buttonDefault.Name = "buttonDefault";
            this.buttonDefault.Size = new System.Drawing.Size(75, 23);
            this.buttonDefault.TabIndex = 14;
            this.buttonDefault.Text = "Default";
            this.buttonDefault.UseVisualStyleBackColor = true;
            this.buttonDefault.Click += new System.EventHandler(this.buttonDefault_Click);
            // 
            // comboBoxForms
            // 
            this.comboBoxForms.FormattingEnabled = true;
            this.comboBoxForms.Location = new System.Drawing.Point(284, 79);
            this.comboBoxForms.Name = "comboBoxForms";
            this.comboBoxForms.Size = new System.Drawing.Size(144, 21);
            this.comboBoxForms.TabIndex = 15;
            this.comboBoxForms.Text = "White";
            this.comboBoxForms.SelectedIndexChanged += new System.EventHandler(this.comboBoxForms_SelectedIndexChanged);
            // 
            // comboBoxElements
            // 
            this.comboBoxElements.FormattingEnabled = true;
            this.comboBoxElements.Location = new System.Drawing.Point(284, 106);
            this.comboBoxElements.Name = "comboBoxElements";
            this.comboBoxElements.Size = new System.Drawing.Size(144, 21);
            this.comboBoxElements.TabIndex = 16;
            this.comboBoxElements.Text = "Black";
            this.comboBoxElements.SelectedIndexChanged += new System.EventHandler(this.comboBoxElements_SelectedIndexChanged);
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.comboBoxElements);
            this.Controls.Add(this.comboBoxForms);
            this.Controls.Add(this.buttonDefault);
            this.Controls.Add(this.labelResolution);
            this.Controls.Add(this.nudDensity);
            this.Controls.Add(this.labelDensity);
            this.Controls.Add(this.buttonMenu);
            this.Controls.Add(this.nudResolution);
            this.Controls.Add(this.buttonAccept);
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
        public System.Windows.Forms.ComboBox comboBoxForms;
        public System.Windows.Forms.ComboBox comboBoxElements;
    }
}