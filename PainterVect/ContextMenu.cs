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
        }    

        private void ChangeType(object sender, ToolStripItemClickedEventArgs e)
        {
            string type = e.ClickedItem.Text;
            switch (type)
            {
                case "Line":
                    activeFigure.Type = FigureDrawing.Line;
                    break;
                case "Round":
                    activeFigure.Type = FigureDrawing.Round;
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

