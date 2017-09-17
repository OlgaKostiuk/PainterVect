using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace PainterVect
{
    public partial class Figure : PictureBox
    {
        public Point Start { get; private set; }
        public Point End { get; private set; }
        public Color Color { get; private set; }
        public int LineWidth { get; private set; }
        public FigureDrawing Type { get; private set; }

        public Figure() { }

        public Figure(FigureDrawing type, Color color, int lineW, Point start, Point end)
        {
            InitializeComponent();
            Color = color;
            Start = start;
            End = end;
            Type = type;
            LineWidth = lineW;
            BackColor = Color.Lavender;
        }

        public void DrawFigure()
        {
            Size = new Size(GetFigureSize().Width, GetFigureSize().Height);
            Image = new Bitmap(Width, Height);
            Graphics graph = Graphics.FromImage(Image);
            graph.DrawPath(new Pen(Color, LineWidth), GetGraphicsPath());
        }

        public Size GetFigureSize()
        {
            int width = Math.Abs(End.X - Start.X);
            int height = Math.Abs(End.Y - Start.Y);
            return new Size(width, height);
        }

        public GraphicsPath GetGraphicsPath()
        {

            Size size = new Size(GetFigureSize().Width-LineWidth*2, GetFigureSize().Height-LineWidth*2);
            Point pathStart = new Point(LineWidth, LineWidth);

            GraphicsPath figure = new GraphicsPath();

            if (Type == FigureDrawing.Rectangle)
                figure.AddRectangle(new Rectangle(pathStart, size));
            else if (Type == FigureDrawing.Round)
                figure.AddEllipse(new Rectangle(pathStart, size));
            else if (Type == FigureDrawing.Line)
            {
                if(Start.X > End.X || Start.Y > End.Y)
                    figure.AddLine(new Point(Width, 0), new Point(0, Height));
                else
                    figure.AddLine(new Point(0,0), new Point(Width,Height));
            }                
            else if (Type == FigureDrawing.RoundRectangle)
                figure.AddPath(RoundRectangle(new Rectangle(pathStart, size), 20), false);

            return figure;
        }

        private GraphicsPath RoundRectangle(Rectangle bounds, int diameter)
        {
            GraphicsPath path = new GraphicsPath();
            Size size = new Size(diameter, diameter);
            Rectangle arc = new Rectangle(bounds.Location, size);
            path.AddArc(arc, 180, 90);
            arc.X = bounds.Right - diameter;
            path.AddArc(arc, 270, 90);
            arc.Y = bounds.Bottom - diameter;
            path.AddArc(arc, 0, 90);
            arc.X = bounds.Left;
            path.AddArc(arc, 90, 90);
            arc.Y = bounds.Top;
            path.CloseFigure();
            return path;
        }

        public void SetMemento(FigureMemento memento)
        {
            Figure figure = memento.GetState();
            Type = figure.Type;
            Start = figure.Start;
            End = figure.End;
            Color = figure.Color;
            LineWidth = figure.LineWidth;
        }

        public FigureMemento GetMemento()
        {
            return new FigureMemento(this);
        }
    }
}
