using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PainterVect
{
    public enum FigureDrawing { Rectangle, Ellipse, RoundRectangle, Line, Pencil };

    public class XData
    {
        public Color color = Color.Black;
        public int lineWidth = 1;
        public FigureDrawing type = FigureDrawing.Line;

        public string textString = "";
        public int textAngle = 0;
        public Color textColor = Color.Red;
        public StringAlignment horizontalAlign = StringAlignment.Center;
        public StringAlignment verticalAlign = StringAlignment.Center;
        public Font textFont = new Font(new FontFamily("Arial"), 20);
    }
}
