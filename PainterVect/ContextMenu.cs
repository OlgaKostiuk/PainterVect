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
                case "Center": { activeFigure.mFigure.text.horizontalAlign = StringAlignment.Center; break; }
                case "Near": { activeFigure.mFigure.text.horizontalAlign = StringAlignment.Near; break; }
                case "Far": { activeFigure.mFigure.text.horizontalAlign = StringAlignment.Far; break; }
                default: break;
            }
            activeFigure.ReDrawFigure();
        }

        private void TextVerticalAlignToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Text)
            {
                case "Center": { activeFigure.mFigure.text.verticalAlign = StringAlignment.Center; break; }
                case "Near": { activeFigure.mFigure.text.verticalAlign = StringAlignment.Near; break; }
                case "Far": { activeFigure.mFigure.text.verticalAlign = StringAlignment.Far; break; }
                default: break;
            }
            activeFigure.ReDrawFigure();
        }

        private void TextToolStripTextBox_TextChanged(object sender, EventArgs e)
        {
            activeFigure.mFigure.text.textString = textToolStripTextBox.Text;
            activeFigure.ReDrawFigure();
        }

        private void AngleToolStripTextBox_TextChanged(object sender, EventArgs e)
        {
            activeFigure.mFigure.text.textAngle = int.Parse(angleToolStripTextBox.Text);
            activeFigure.ReDrawFigure();
        }

        private void TextFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog dlg = new FontDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                activeFigure.mFigure.text.textFont = dlg.Font;
            }
            activeFigure.ReDrawFigure();
        }

        private void TextColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlgColor = new ColorDialog();
            if (dlgColor.ShowDialog() == DialogResult.OK)
            {
                activeFigure.mFigure.text.textColor = dlgColor.Color;
            }
            activeFigure.ReDrawFigure();
        }



        private void ChangeType(object sender, ToolStripItemClickedEventArgs e)
        {
            string type = e.ClickedItem.Text;
            switch (type)
            {
                case "Line":
                    activeFigure.mFigure.data.type = FigureDrawing.Line;
                    break;
                case "Ellipse":
                    activeFigure.mFigure.data.type = FigureDrawing.Ellipse;
                    break;
                case "Rectangle":
                    activeFigure.mFigure.data.type = FigureDrawing.Rectangle;
                    break;
                case "RoundRectangle":
                    activeFigure.mFigure.data.type = FigureDrawing.RoundRectangle;
                    break;

            }
            activeFigure.ReDrawFigure();
        }

        private void ChangeWidth(object sender, ToolStripItemClickedEventArgs e)
        {
            activeFigure.mFigure.data.lineWidth = Convert.ToInt32(e.ClickedItem.Text);
            activeFigure.ReDrawFigure();
        }

        private void ChangeColor(object sender, EventArgs e)
        {
            ColorDialog dlgColor = new ColorDialog();
            if (dlgColor.ShowDialog() == DialogResult.OK)
            {
                activeFigure.mFigure.data.color = dlgColor.Color;
                activeFigure.ReDrawFigure();
            }
        }


    }
}

