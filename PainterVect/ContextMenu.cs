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
    public partial class ContextMenu : UserControl
    {
        public Figure activeFigure { get; set; }
        public ContextMenu()
        {
            InitializeComponent();
            ContextMenuStrip = contextMenuStrip1;
            lineWidthToolStripMenuItem.DropDownItemClicked += ChangeWidth;
            typeToolStripMenuItem.DropDownItemClicked += ChangeType;
            colorToolStripMenuItem.Click += ChangeColor;
            textColorToolStripMenuItem.Click += TextColorToolStripMenuItem_Click;
            textFontToolStripMenuItem.Click += TextFontToolStripMenuItem_Click;
            textToolStripTextBox.TextChanged += TextToolStripTextBox_TextChanged;
            textVerticalAlignToolStripMenuItem.DropDownItemClicked += TextVerticalAlignToolStripMenuItem_DropDownItemClicked;
            textHorizontalAlignToolStripMenuItem.DropDownItemClicked += TextHorizontalAlignToolStripMenuItem_DropDownItemClicked;
            angleToolStripTextBox.TextChanged += AngleToolStripTextBox_TextChanged;
        }

        private void TextHorizontalAlignToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Text)
            {
                case "Center": { activeFigure.HorizontalAlign = StringAlignment.Center; break; }
                case "Near": { activeFigure.HorizontalAlign = StringAlignment.Near; break; }
                case "Far": { activeFigure.HorizontalAlign = StringAlignment.Far; break; }
                default: break;
            }
            activeFigure.ReDrawFigure();
        }

        private void TextVerticalAlignToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Text)
            {
                case "Center": { activeFigure.VerticalAlign = StringAlignment.Center; break; }
                case "Near": { activeFigure.VerticalAlign = StringAlignment.Near; break; }
                case "Far": { activeFigure.VerticalAlign = StringAlignment.Far; break; }
                default: break;
            }
            activeFigure.ReDrawFigure();
        }

        private void TextToolStripTextBox_TextChanged(object sender, EventArgs e)
        {
            activeFigure.TextString = textToolStripTextBox.Text;
            activeFigure.ReDrawFigure();
        }

        private void AngleToolStripTextBox_TextChanged(object sender, EventArgs e)
        {
            activeFigure.TextAngle = int.Parse(angleToolStripTextBox.Text);
            activeFigure.ReDrawFigure();
        }

        private void TextFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog dlg = new FontDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                activeFigure.TextFont = dlg.Font;
            }
            activeFigure.ReDrawFigure();
        }

        private void TextColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlgColor = new ColorDialog();
            if (dlgColor.ShowDialog() == DialogResult.OK)
            {
                activeFigure.TextColor = dlgColor.Color;
            }
            activeFigure.ReDrawFigure();
        }



        private void ChangeType(object sender, ToolStripItemClickedEventArgs e)
        {
            string type = e.ClickedItem.Text;
            switch (type)
            {
                case "Line":
                    activeFigure.Type = FigureDrawing.Line;
                    break;
                case "Ellipse":
                    activeFigure.Type = FigureDrawing.Ellipse;
                    break;
                case "Rectangle":
                    activeFigure.Type = FigureDrawing.Rectangle;
                    break;
                case "RoundRectangle":
                    activeFigure.Type = FigureDrawing.RoundRectangle;
                    break;

            }
            activeFigure.ReDrawFigure();
        }

        private void ChangeWidth(object sender, ToolStripItemClickedEventArgs e)
        {
            activeFigure.LineWidth = Convert.ToInt32(e.ClickedItem.Text);
            activeFigure.ReDrawFigure();
        }

        private void ChangeColor(object sender, EventArgs e)
        {
            ColorDialog dlgColor = new ColorDialog();
            if (dlgColor.ShowDialog() == DialogResult.OK)
            {
                activeFigure.Color = dlgColor.Color;
                activeFigure.ReDrawFigure();
            }
        }


    }
}

