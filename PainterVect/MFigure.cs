using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PainterVect
{
    public class MFigure
    {
        public XData data = new XData();
        public XText text = new XText();
        public Point Start = new Point();
        public Point End = new Point();

        public MFigure()
        {

        }

        public MFigure(XData data, XText text, Point start, Point end)
        {
            this.data.type = data.type;
            this.data.lineWidth = data.lineWidth;
            this.data.color = data.color;
            this.text.textString = text.textString;
            this.text.textAngle = text.textAngle;
            this.text.textFont = text.textFont;
            this.text.textColor = text.textColor;
            this.text.horizontalAlign = text.horizontalAlign;
            this.text.verticalAlign = text.verticalAlign;
            Start = start;
            End = end;
        }
    }
}
