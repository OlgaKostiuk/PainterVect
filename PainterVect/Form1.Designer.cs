namespace PainterVect
{
    partial class Form1
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
            this.pDraw1 = new PainterVect.PDraw();
            ((System.ComponentModel.ISupportInitialize)(this.pDraw1)).BeginInit();
            this.SuspendLayout();
            // 
            // pDraw1
            // 
            this.pDraw1.BackColor = System.Drawing.Color.Beige;
            this.pDraw1.Location = new System.Drawing.Point(12, 66);
            this.pDraw1.Name = "pDraw1";
            this.pDraw1.Size = new System.Drawing.Size(765, 461);
            this.pDraw1.TabIndex = 0;
            this.pDraw1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 568);
            this.Controls.Add(this.pDraw1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pDraw1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PDraw pDraw1;
    }
}

