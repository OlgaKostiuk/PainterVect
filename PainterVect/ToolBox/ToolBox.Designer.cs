namespace PainterVect.ToolBox
{
    partial class ToolBox
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
            this.pColor1 = new PainterVect.ToolBox.PColor();
            this.pLineWidth1 = new PainterVect.ToolBox.PLineWidth();
            this.pType1 = new PainterVect.ToolBox.PType();
            this.pSave1 = new PainterVect.ToolBox.PSave();
            this.pOpen1 = new PainterVect.ToolBox.POpen();
            this.SuspendLayout();
            // 
            // pColor1
            // 
            this.pColor1.cmd = null;
            this.pColor1.Location = new System.Drawing.Point(3, 3);
            this.pColor1.Name = "pColor1";
            this.pColor1.Size = new System.Drawing.Size(107, 29);
            this.pColor1.TabIndex = 0;
            // 
            // pLineWidth1
            // 
            this.pLineWidth1.cmd = null;
            this.pLineWidth1.Location = new System.Drawing.Point(3, 29);
            this.pLineWidth1.Name = "pLineWidth1";
            this.pLineWidth1.Size = new System.Drawing.Size(107, 58);
            this.pLineWidth1.TabIndex = 1;
            // 
            // pType1
            // 
            this.pType1.cmd = null;
            this.pType1.Location = new System.Drawing.Point(4, 94);
            this.pType1.Name = "pType1";
            this.pType1.Size = new System.Drawing.Size(107, 158);
            this.pType1.TabIndex = 5;
            // 
            // pSave1
            // 
            this.pSave1.Location = new System.Drawing.Point(0, 299);
            this.pSave1.Name = "pSave1";
            this.pSave1.Size = new System.Drawing.Size(107, 32);
            this.pSave1.TabIndex = 6;
            // 
            // pOpen1
            // 
            this.pOpen1.Location = new System.Drawing.Point(0, 271);
            this.pOpen1.Name = "pOpen1";
            this.pOpen1.Size = new System.Drawing.Size(107, 31);
            this.pOpen1.TabIndex = 7;
            // 
            // ToolBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pOpen1);
            this.Controls.Add(this.pSave1);
            this.Controls.Add(this.pType1);
            this.Controls.Add(this.pLineWidth1);
            this.Controls.Add(this.pColor1);
            this.Name = "ToolBox";
            this.Size = new System.Drawing.Size(114, 353);
            this.ResumeLayout(false);

        }

        #endregion

        private PColor pColor1;
        private PLineWidth pLineWidth1;
        private PType pType1;
        private PSave pSave1;
        private POpen pOpen1;
    }
}
