using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PainterVect
{
    public enum FigureDrawing { Rectangle, Round, RoundRectangle, Line, Pencil };

    public class XData
    {
        public Color color = Color.Black;
        public int lineWidth = 1;
        public FigureDrawing type = FigureDrawing.Line;
    }
}
