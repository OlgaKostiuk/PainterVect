using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PainterVect
{
    public static class FigureSerializer
    {
        public static List<FigureMemento> GetMementoList(List<Figure> figures)
        {
            List<FigureMemento> fm = new List<FigureMemento>();
            foreach (Figure f in figures)
            {
                fm.Add(f.GetMemento());
            }
            return fm;
        }
        public static List<Figure> GetFiguresList(List<FigureMemento> fm)
        {
            List<Figure> figures = new List<Figure>();
            foreach (FigureMemento f in fm)
            {
                Figure figure = new Figure();
                figure.SetMemento(f);
                figures.Add(figure);
            }
            return figures;
        }
    }
}
