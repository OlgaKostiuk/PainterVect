using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PainterVect
{
    public class XCommand
    {
        public XData data { get; private set; } = new XData();
        public PDraw pdraw;
        
        public void setType(object sender, EventArgs e, string type)
        {
            switch (type)
            {
                case "Rectangle": { data.type = FigureDrawing.Rectangle; break; }
                case "Ellipse": { data.type = FigureDrawing.Ellipse; break; }
                case "RoundRectangle": { data.type = FigureDrawing.RoundRectangle; break; }
                case "Line": { data.type = FigureDrawing.Line; break; }
                case "Pencil": { data.type = FigureDrawing.Pencil; break; }
                default: break;
            }
        }

        public void setWidth(object sender, EventArgs e, string lineWidth)
        {
            data.lineWidth = int.Parse(lineWidth);
        }

        //public void setColor(object sender, EventArgs e, Color color)
        //{
        //    data.color = color;
        //}

        public void setColor(object sender, EventArgs e)
        {
            ColorDialog dlgColor = new ColorDialog();
            if (dlgColor.ShowDialog() == DialogResult.OK)
            {
                data.color = dlgColor.Color;
            }
        }

        public void saveFigures(object sender, EventArgs e)
        {
            SaveFileDialog dlgSave = new SaveFileDialog();
            string[] ext = { "JSON (*.json)|*.json", "XML (*.xml) | *.xml", "YAML (*.yaml)|*.yaml", "BIN (*.bin)|*.bin", "CSV (*.csv)|*.csv" };
            dlgSave.Filter = String.Join("|", ext);
            if (dlgSave.ShowDialog() == DialogResult.OK)
            {
                SOFactory.GetInstance(dlgSave.FileName).Save(pdraw.Figures);
            }
        }

        public void openFigures(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            string ext = "SO (*.json; *.xml; *.yaml; *.bin; *.csv)| *.json; *.xml; *.yaml; *.bin; *.csv";
            dlgOpen.Filter = ext;
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                pdraw.Figures = SOFactory.GetInstance(dlgOpen.FileName).Open();
                pdraw.Redraw();
            }
        }


        public delegate void setCoords(Point p);
        public event setCoords onCoordsChanged;

        public void coordsChangedHandler(Point p)
        {
            onCoordsChanged(p);
        }




    }
}
