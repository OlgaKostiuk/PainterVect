namespace PainterVect.ToolBox
{
    partial class PType
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
            this.btnRectangle = new System.Windows.Forms.Button();
            this.btnRound = new System.Windows.Forms.Button();
            this.btnRoundRectangle = new System.Windows.Forms.Button();
            this.btnLine = new System.Windows.Forms.Button();
            this.btnPencil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRectangle
            // 
            this.btnRectangle.Location = new System.Drawing.Point(4, 4);
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(100, 23);
            this.btnRectangle.TabIndex = 0;
            this.btnRectangle.Tag = "Rectangle";
            this.btnRectangle.Text = "Rectangle";
            this.btnRectangle.UseVisualStyleBackColor = true;
            // 
            // btnRound
            // 
            this.btnRound.Location = new System.Drawing.Point(4, 33);
            this.btnRound.Name = "btnRound";
            this.btnRound.Size = new System.Drawing.Size(100, 23);
            this.btnRound.TabIndex = 1;
            this.btnRound.Tag = "Round";
            this.btnRound.Text = "Round";
            this.btnRound.UseVisualStyleBackColor = true;
            // 
            // btnRoundRectangle
            // 
            this.btnRoundRectangle.Location = new System.Drawing.Point(4, 63);
            this.btnRoundRectangle.Name = "btnRoundRectangle";
            this.btnRoundRectangle.Size = new System.Drawing.Size(100, 23);
            this.btnRoundRectangle.TabIndex = 2;
            this.btnRoundRectangle.Tag = "RoundRectangle";
            this.btnRoundRectangle.Text = "Round rectangle";
            this.btnRoundRectangle.UseVisualStyleBackColor = true;
            // 
            // btnLine
            // 
            this.btnLine.Location = new System.Drawing.Point(4, 93);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(100, 23);
            this.btnLine.TabIndex = 3;
            this.btnLine.Tag = "Line";
            this.btnLine.Text = "Line";
            this.btnLine.UseVisualStyleBackColor = true;
            // 
            // btnPencil
            // 
            this.btnPencil.Location = new System.Drawing.Point(3, 122);
            this.btnPencil.Name = "btnPencil";
            this.btnPencil.Size = new System.Drawing.Size(100, 23);
            this.btnPencil.TabIndex = 4;
            this.btnPencil.Tag = "Pencil";
            this.btnPencil.Text = "Pencil";
            this.btnPencil.UseVisualStyleBackColor = true;
            // 
            // PType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnPencil);
            this.Controls.Add(this.btnLine);
            this.Controls.Add(this.btnRoundRectangle);
            this.Controls.Add(this.btnRound);
            this.Controls.Add(this.btnRectangle);
            this.Name = "PType";
            this.Size = new System.Drawing.Size(107, 158);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRectangle;
        private System.Windows.Forms.Button btnRound;
        private System.Windows.Forms.Button btnRoundRectangle;
        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.Button btnPencil;
    }
}
