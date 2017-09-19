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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolBox1 = new PainterVect.ToolBox.ToolBox();
            this.statusBar1 = new PainterVect.StatusBar.StatusBar();
            this.toolBar1 = new PainterVect.ToolBar.ToolBar();
            this.mainMenu1 = new PainterVect.MainMenu.MainMenu();
            this.pDraw1 = new PainterVect.PDraw();
            ((System.ComponentModel.ISupportInitialize)(this.pDraw1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolBox1
            // 
            this.toolBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.toolBox1.cmd = null;
            this.toolBox1.Location = new System.Drawing.Point(800, 25);
            this.toolBox1.Name = "toolBox1";
            this.toolBox1.Size = new System.Drawing.Size(114, 523);
            this.toolBox1.TabIndex = 5;
            // 
            // statusBar1
            // 
            this.statusBar1.cmd = null;
            this.statusBar1.Location = new System.Drawing.Point(12, 533);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Size = new System.Drawing.Size(150, 32);
            this.statusBar1.TabIndex = 4;
            // 
            // toolBar1
            // 
            this.toolBar1.cmd = null;
            this.toolBar1.Location = new System.Drawing.Point(12, 25);
            this.toolBar1.Name = "toolBar1";
            this.toolBar1.Size = new System.Drawing.Size(467, 24);
            this.toolBar1.TabIndex = 3;
            // 
            // mainMenu1
            // 
            this.mainMenu1.cmd = null;
            this.mainMenu1.Location = new System.Drawing.Point(12, 0);
            this.mainMenu1.Name = "mainMenu1";
            this.mainMenu1.Size = new System.Drawing.Size(467, 28);
            this.mainMenu1.TabIndex = 2;
            // 
            // pDraw1
            // 
            this.pDraw1.BackColor = System.Drawing.SystemColors.Control;
            this.pDraw1.cmd = null;
            this.pDraw1.Image = ((System.Drawing.Image)(resources.GetObject("pDraw1.Image")));
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
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(945, 568);
            this.Controls.Add(this.toolBox1);
            this.Controls.Add(this.statusBar1);
            this.Controls.Add(this.toolBar1);
            this.Controls.Add(this.mainMenu1);
            this.Controls.Add(this.pDraw1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pDraw1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PDraw pDraw1;
        private MainMenu.MainMenu mainMenu1;
        private ToolBar.ToolBar toolBar1;
        private StatusBar.StatusBar statusBar1;
        private ToolBox.ToolBox toolBox1;
    }
}

