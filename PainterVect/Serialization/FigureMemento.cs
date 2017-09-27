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

        public string textString { get; set; }
        public int textAngle { get; set; }
        public int textColor { get; set; }
        public int horizontalAlign { get; set; }
        public int verticalAlign { get; set; }
        public string fontName { get; set; }
        public int textSize { get; set; }

        public FigureMemento() { }

        public FigureMemento(MFigure mFigure)
        {
            x1 = mFigure.Start.X;
            y1 = mFigure.Start.Y;
            x2 = mFigure.End.X;
            y2 = mFigure.End.Y;
            color = mFigure.data.color.ToArgb();
            lineWidth = mFigure.data.lineWidth;
            type = (int)mFigure.data.type;

            textString = mFigure.text.textString;
            textAngle = mFigure.text.textAngle;
            textColor = mFigure.text.textColor.ToArgb();
            horizontalAlign = (int)mFigure.text.horizontalAlign;
            verticalAlign = (int)mFigure.text.verticalAlign;
            fontName = mFigure.text.textFont.Name;
            textSize = (int)mFigure.text.textFont.Size;
        }

        public MFigure GetState()
        {
            XData data = new XData();
            data.type = (FigureDrawing)type;
            data.color = Color.FromArgb(color);
            data.lineWidth = lineWidth;

            XText text = new XText();
            text.textString = textString;
            text.textAngle = textAngle;
            text.textColor = Color.FromArgb(textColor);
            text.textFont = new Font(fontName, textSize);
            text.horizontalAlign = (StringAlignment)horizontalAlign;
            text.verticalAlign = (StringAlignment)verticalAlign;
            return new MFigure()
            {
                data = data,
                text = text,
                Start = new Point(x1, y1),
                End = new Point(x2, y2)
            };
        }
    }
}