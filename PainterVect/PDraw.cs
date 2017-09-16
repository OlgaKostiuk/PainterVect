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
        //private XData data;
        private Point mouseDownPoint;
        public XCommand cmd { get; set; }

        public PDraw()
        {
            InitializeComponent();
            //data = cmd.data;

            MouseDown += PDraw_MouseDown;
            MouseUp += PDraw_MouseUp;
            MouseMove += PDraw_MouseMove;
            MouseLeave += PDraw_MouseLeave;

            SizeChanged += PDraw_SizeChanged;
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

                if (End.X < Start.X && cmd.data.type != FigureDrawing.Pencil)//&& cmd.data.type != FigureDrawing.Line 
                {
                    int temp = Start.X;
                    Start = new Point(End.X, Start.Y);
                    End = new Point(temp, End.Y);
                }
                if (End.Y < Start.Y && cmd.data.type != FigureDrawing.Pencil)//&& cmd.data.type != FigureDrawing.Line 
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
                figure.Location = Start;
            }
        }
    }
}
