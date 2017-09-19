using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PainterVect
{
    public partial class Text : Label
    {
        //public string TextString { get; set; } = "Test";
        public int RotateAngle { get; set; } = 0;
        //public Color TextColor { get; set; } = Color.Red;
        public FontFamily FontFamily { get; set; } = new FontFamily("Arial");
        public int EmSize { get; set; } = 20;

        public Text()
        {
            InitializeComponent();
            Text = "Test";
            ForeColor = Color.Red;
            Font = new Font(FontFamily, EmSize);
            AutoSize = false;            
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Brush b = new SolidBrush(ForeColor);
            e.Graphics.TranslateTransform(Width / 2, Height / 2);
            e.Graphics.RotateTransform(RotateAngle);
            e.Graphics.DrawString(Text, Font, b, 0f, 0f);
            base.OnPaint(e);
        }
    }
}
