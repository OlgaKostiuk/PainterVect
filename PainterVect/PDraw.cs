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
        //TODO: remove init for data
        private XData data = new XData();
        private Point mouseDownPoint;
        public XCommand cmd { get; set; }

        public PDraw()
        {
            InitializeComponent();

            BackColor = Color.Beige;

            MouseDown += PDraw_MouseDown;
            MouseUp += PDraw_MouseUp;
        }

        private void PDraw_MouseUp(object sender, MouseEventArgs e)
        {
            Point mouseUpPoint = new Point(e.X, e.Y);
            DrawFigure(mouseUpPoint);
        }

        private void PDraw_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDownPoint = new Point(e.X, e.Y);
        }

        private void DrawFigure(Point end)
        {
            Point Start = mouseDownPoint;
            Point End = end;
            if (End.X < Start.X && data.type != FigureDrawing.Line)
            {
                int temp = Start.X;
                Start = new Point(End.X, Start.Y);
                End = new Point(temp, End.Y);
            }
            if (End.Y < Start.Y && data.type != FigureDrawing.Line)
            {
                int temp = Start.Y;
                Start = new Point(Start.X, End.Y);
                End = new Point(End.X, temp);
            }

            Figure figure = new Figure(data.type, data.color, data.lineWidth, Start, End);
            Controls.Add(figure);
            figure.Location = Start;
        }
    }
}
