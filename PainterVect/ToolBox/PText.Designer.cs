namespace PainterVect.ToolBox
{
    partial class PText
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxText = new System.Windows.Forms.TextBox();
            this.btnFont = new System.Windows.Forms.Button();
            this.btnTextColor = new System.Windows.Forms.Button();
            this.comboBoxVerticalAlign = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxHorizontalAlign = new System.Windows.Forms.ComboBox();
            this.numericUpDownAngle = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAngle)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxText
            // 
            this.textBoxText.Location = new System.Drawing.Point(2, 16);
            this.textBoxText.Multiline = true;
            this.textBoxText.Name = "textBoxText";
            this.textBoxText.Size = new System.Drawing.Size(101, 20);
            this.textBoxText.TabIndex = 0;
            // 
            // btnFont
            // 
            this.btnFont.Location = new System.Drawing.Point(2, 42);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(100, 23);
            this.btnFont.TabIndex = 1;
            this.btnFont.Text = "Font";
            this.btnFont.UseVisualStyleBackColor = true;
            // 
            // btnTextColor
            // 
            this.btnTextColor.Location = new System.Drawing.Point(2, 71);
            this.btnTextColor.Name = "btnTextColor";
            this.btnTextColor.Size = new System.Drawing.Size(100, 23);
            this.btnTextColor.TabIndex = 2;
            this.btnTextColor.Text = "Text color";
            this.btnTextColor.UseVisualStyleBackColor = true;
            // 
            // comboBoxVerticalAlign
            // 
            this.comboBoxVerticalAlign.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVerticalAlign.FormattingEnabled = true;
            this.comboBoxVerticalAlign.Items.AddRange(new object[] {
            "Center",
            "Near",
            "Far"});
            this.comboBoxVerticalAlign.Location = new System.Drawing.Point(4, 113);
            this.comboBoxVerticalAlign.Name = "comboBoxVerticalAlign";
            this.comboBoxVerticalAlign.Size = new System.Drawing.Size(100, 21);
            this.comboBoxVerticalAlign.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Vertical align:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Horizontal align:";
            // 
            // comboBoxHorizontalAlign
            // 
            this.comboBoxHorizontalAlign.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHorizontalAlign.FormattingEnabled = true;
            this.comboBoxHorizontalAlign.Items.AddRange(new object[] {
            "Center",
            "Near",
            "Far"});
            this.comboBoxHorizontalAlign.Location = new System.Drawing.Point(4, 153);
            this.comboBoxHorizontalAlign.Name = "comboBoxHorizontalAlign";
            this.comboBoxHorizontalAlign.Size = new System.Drawing.Size(100, 21);
            this.comboBoxHorizontalAlign.TabIndex = 6;
            // 
            // numericUpDownAngle
            // 
            this.numericUpDownAngle.Location = new System.Drawing.Point(4, 180);
            this.numericUpDownAngle.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.numericUpDownAngle.Minimum = new decimal(new int[] {
            90,
            0,
            0,
            -2147483648});
            this.numericUpDownAngle.Name = "numericUpDownAngle";
            this.numericUpDownAngle.Size = new System.Drawing.Size(101, 20);
            this.numericUpDownAngle.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Text:";
            // 
            // PText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDownAngle);
            this.Controls.Add(this.comboBoxHorizontalAlign);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxVerticalAlign);
            this.Controls.Add(this.btnTextColor);
            this.Controls.Add(this.btnFont);
            this.Controls.Add(this.textBoxText);
            this.Name = "PText";
            this.Size = new System.Drawing.Size(107, 212);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAngle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxText;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.Button btnTextColor;
        private System.Windows.Forms.ComboBox comboBoxVerticalAlign;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxHorizontalAlign;
        private System.Windows.Forms.NumericUpDown numericUpDownAngle;
        private System.Windows.Forms.Label label3;
    }
}
