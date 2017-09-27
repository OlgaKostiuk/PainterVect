using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PainterVect
{
    public class XText
    {
        public string textString = "";
        public int textAngle = 0;
        public Color textColor = Color.Black;
        public StringAlignment horizontalAlign = StringAlignment.Center;
        public StringAlignment verticalAlign = StringAlignment.Center;
        public Font textFont = new Font(new FontFamily("Arial"), 20);
    }
}
