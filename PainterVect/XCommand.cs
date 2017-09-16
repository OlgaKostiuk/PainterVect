using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PainterVect
{
    public class XCommand
    {
        public XData data { get; private set; } = new XData();
        
        public void setType(object sender, EventArgs e, string type)
        {
            switch (type)
            {
                case "Rectangle": { data.type = FigureDrawing.Rectangle; break; }
                case "Round": { data.type = FigureDrawing.Round; break; }
                case "RoundRectangle": { data.type = FigureDrawing.RoundRectangle; break; }
                case "Line": { data.type = FigureDrawing.Line; break; }
                case "Pencil": { data.type = FigureDrawing.Pencil; break; }
                default: break;
            }
        }

        public void setWidth(object sender, EventArgs e, string lineWidth)
        {
            data.lineWidth = int.Parse(lineWidth);
        }

        public void setColor(object sender, EventArgs e, Color color)
        {
            data.color = color;
        }

        public delegate void setCoords(Point p);
        public event setCoords setCoordsEvent;

        public void coordsChangedHandler(Point p)
        {
            setCoordsEvent(p);
        }
    }
}
