using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PainterVect
{
    [Serializable()]
    public class FigureMemento
    {
        public int x1 { get; set; }
        public int y1 { get; set; }
        public int x2 { get; set; }
        public int y2 { get; set; }
        public int color { get; set; }
        public int lineWidth { get; set; }
        public int type { get; set; }

        public FigureMemento() { }

        public FigureMemento(Figure figure)
        {
            x1 = figure.Start.X;
            y1 = figure.Start.Y;
            x2 = figure.End.X;
            y2 = figure.End.Y;
            color = figure.Color.ToArgb();
            lineWidth = figure.LineWidth;
            type = (int)figure.Type;
        }

        public Figure GetState()
        {
            return new Figure((FigureDrawing)type, Color.FromArgb(color), lineWidth, new Point(x1, y1), new Point(x2, y2), new Font(new FontFamily("Arial"), 20));
        }
    }
}