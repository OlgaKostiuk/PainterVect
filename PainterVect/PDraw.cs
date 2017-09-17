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
    public partial class PDraw : PictureBox
    {
        private Point mouseDownPoint;
        public XCommand cmd { get; set; }

        public PDraw()
        {
            InitializeComponent();

            MouseDown += PDraw_MouseDown;
            MouseUp += PDraw_MouseUp;
            MouseMove += PDraw_MouseMove;
            MouseLeave += PDraw_MouseLeave;

            SizeChanged += PDraw_SizeChanged;
        }

        public void Redraw()
        {
            foreach (var item in Figures)
            {
                //TODO: find location for lines 
                //Point location = new Point();
                item.Location = item.Start;
                //item.Location = location;
                item.DrawFigure();
                item.MouseMove += Figure_MouseMove;
            }
            Invalidate();
        }

        private void PDraw_MouseLeave(object sender, EventArgs e)
        {
            cmd.coordsChangedHandler(new Point(0,0));
        }

        private void PDraw_SizeChanged(object sender, EventArgs e)
        {
            Image = new Bitmap(Width, Height);
        }

        private void PDraw_MouseMove(object sender, MouseEventArgs e)
        {
            if (cmd.data.type == FigureDrawing.Pencil && e.Button == MouseButtons.Left)
            {
                using (Graphics g = Graphics.FromImage(Image))
                {
                    g.DrawLine(new Pen(cmd.data.color, cmd.data.lineWidth), mouseDownPoint, e.Location);
                    mouseDownPoint = e.Location;
                    Invalidate();
                }
            }
            cmd.coordsChangedHandler(e.Location);
        }

        private void Figure_MouseMove(object sender, MouseEventArgs e)
        {
            Point location = new Point(((Figure)sender).Location.X + e.Location.X, ((Figure)sender).Location.Y + e.Location.Y);
            cmd.coordsChangedHandler(location);
        }

        private void PDraw_MouseUp(object sender, MouseEventArgs e)
        {

            Point mouseUpPoint = e.Location;
            DrawFigure(mouseUpPoint);
        }

        private void PDraw_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDownPoint = e.Location;
        }

        private void DrawFigure(Point end)
        {
            if (cmd.data.type != FigureDrawing.Pencil)
            {
                Point Start = mouseDownPoint;
                Point End = end;
                Figure figure;

                if (End.X < Start.X && cmd.data.type != FigureDrawing.Pencil)
                {
                    int temp = Start.X;
                    Start = new Point(End.X, Start.Y);
                    End = new Point(temp, End.Y);
                }
                if (End.Y < Start.Y && cmd.data.type != FigureDrawing.Pencil)
                {
                    int temp = Start.Y;
                    Start = new Point(Start.X, End.Y);
                    End = new Point(End.X, temp);
                }
                if(cmd.data.type == FigureDrawing.Line)
                    figure = new Figure(cmd.data.type, cmd.data.color, cmd.data.lineWidth, mouseDownPoint, end);
                else
                    figure = new Figure(cmd.data.type, cmd.data.color, cmd.data.lineWidth, Start, End);
                Controls.Add(figure);
                figure.DrawFigure();
                figure.Location = Start;

                figure.MouseMove += Figure_MouseMove;

            }
        }

        public List<Figure> Figures
        {
            get
            {
                List<Figure> list = new List<Figure>();
                foreach (Control figure in Controls)
                {
                    list.Add((figure as Figure));
                }
                return list;
            }
            set
            {
                Controls.Clear();
                foreach (Figure figure in value)
                {
                    Controls.Add(figure);
                }
            }
        }
    }
}
