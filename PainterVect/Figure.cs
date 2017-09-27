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
    [Serializable()]
    public partial class Figure : PictureBox
    {
        public MFigure mFigure = new MFigure();
        Point mouseLocation = new Point();
        bool resize = false;

        public Figure()
        {
            InitializeComponent();
            MouseMove += Figure_MouseMove;
            MouseDown += Figure_MouseDown;
            MouseUp += Figure_MouseUp;
            MouseLeave += Figure_MouseLeave;
            contextMenu1.activeFigure = this;
            ContextMenuStrip = contextMenu1.ContextMenuStrip;
        }

        public Figure(MFigure mFigure)
        {
            InitializeComponent();
            this.mFigure = mFigure;
            MouseMove += Figure_MouseMove;
            MouseDown += Figure_MouseDown;
            MouseUp += Figure_MouseUp;
            MouseLeave += Figure_MouseLeave;
            contextMenu1.activeFigure = this;
            ContextMenuStrip = contextMenu1.ContextMenuStrip;    
        }

        private void Figure_MouseLeave(object sender, EventArgs e)
        {
            BorderStyle = BorderStyle.None;
        }

        private void Figure_MouseUp(object sender, MouseEventArgs e)
        {
            resize = false;
        }

        private void Figure_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = e.Location;

            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip.Show(Cursor.Position);

            }

            if (e.X > Size.Width - 10 || e.Y > Size.Height - 10)
            {
                resize = true;
            }
            else
            {
                resize = false;
            }
        }

        private void Figure_MouseMove(object sender, MouseEventArgs e)
        {
            BorderStyle = BorderStyle.FixedSingle;
            if (e.X > Size.Width - 5)
                Cursor.Current = Cursors.SizeWE;
            else if (e.Y > Size.Height - 5)
                Cursor.Current = Cursors.SizeNS;
            else
                Cursor.Current = Cursors.Hand;
            if (e.Button == MouseButtons.Left)
            {
                if (!resize)
                {
                    {
                        PictureBox pb = sender as PictureBox;
                        int x_shift = e.X - mouseLocation.X;
                        int y_shift = e.Y - mouseLocation.Y;
                        mFigure.Start = new Point(mFigure.Start.X + e.X - mouseLocation.X, mFigure.Start.Y + e.Y - mouseLocation.Y);
                        mFigure.End = new Point(mFigure.End.X + e.X - mouseLocation.X, mFigure.End.Y + e.Y - mouseLocation.Y);
                        Location = new Point(Location.X + x_shift, Location.Y + y_shift);
                        mouseLocation = e.Location;
                    }
                }
                else
                {
                    Height += e.Y - mouseLocation.Y;
                    Width += e.X - mouseLocation.X;
                    mFigure.End = new Point(mFigure.End.X + e.X - mouseLocation.X, mFigure.End.Y + e.Y - mouseLocation.Y);
                    mouseLocation = e.Location;
                }
                Invalidate();
                ReDrawFigure();
            }
        }

        public void ReDrawFigure()
        {
            Image = new Bitmap(Width, Height);
            Graphics graph = Graphics.FromImage(Image);
            graph.DrawPath(new Pen(mFigure.data.color, mFigure.data.lineWidth), GetGraphicsPath());
            DrawText(graph);
        }

        public void DrawFigure()
        {
            Size = new Size(GetFigureSize().Width, GetFigureSize().Height);
            Image = new Bitmap(Width, Height);
            Graphics graph = Graphics.FromImage(Image);
            graph.DrawPath(new Pen(mFigure.data.color, mFigure.data.lineWidth), GetGraphicsPath());
            DrawText(graph);
        }

        public Size GetFigureSize()
        {
            int width = Math.Abs(mFigure.End.X - mFigure.Start.X);
            int height = Math.Abs(mFigure.End.Y - mFigure.Start.Y);
            return new Size(width, height);
        }

        public GraphicsPath GetGraphicsPath()
        {

            Size size = new Size(GetFigureSize().Width- mFigure.data.lineWidth *2, GetFigureSize().Height- mFigure.data.lineWidth *2);
            Point pathStart = new Point(mFigure.data.lineWidth, mFigure.data.lineWidth);

            GraphicsPath figure = new GraphicsPath();

            if (mFigure.data.type == FigureDrawing.Rectangle)
                figure.AddRectangle(new Rectangle(pathStart, size));
            else if (mFigure.data.type == FigureDrawing.Ellipse)
                figure.AddEllipse(new Rectangle(pathStart, size));
            else if (mFigure.data.type == FigureDrawing.Line)
            {
                if(mFigure.Start.X > mFigure.End.X || mFigure.Start.Y > mFigure.End.Y)
                    figure.AddLine(new Point(Width, 0), new Point(0, Height));
                else
                    figure.AddLine(new Point(0,0), new Point(Width,Height));
            }                
            else if (mFigure.data.type == FigureDrawing.RoundRectangle)
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

        private void DrawText(Graphics g)
        {
            StringFormat format = new StringFormat();
            format.LineAlignment = mFigure.text.verticalAlign;
            format.Alignment = mFigure.text.horizontalAlign;

            //move rotation point to center of image
            g.TranslateTransform((float)ClientRectangle.Width / 2, (float)ClientRectangle.Height / 2);
            //rotate
            g.RotateTransform(mFigure.text.textAngle);
            //move image back
            g.TranslateTransform(-(float)ClientRectangle.Width / 2, -(float)ClientRectangle.Height / 2);

            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
            g.DrawString(mFigure.text.textString, mFigure.text.textFont, new SolidBrush(mFigure.text.textColor), ClientRectangle, format);
        }

        public void SetMemento(FigureMemento memento)
        {
            mFigure = memento.GetState();
        }

        public FigureMemento GetMemento()
        {
            return new FigureMemento(mFigure);
        }
    }
}
