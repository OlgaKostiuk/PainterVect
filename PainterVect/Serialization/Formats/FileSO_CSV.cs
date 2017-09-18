
using Newtonsoft.Json;
using ServiceStack.Text;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PainterVect
{
    public class FileSO_CSV : IFileSO
    {
        string path = "";
        public FileSO_CSV(string path)
        {
            this.path = path;
        }

        public  List<Figure> Open()
        {
            if (File.Exists(path) == false)
            {
                FileStream fs = File.Create(path);
                fs.Close();
            }
            string csvString = File.ReadAllText(path);
            List<FigureMemento> mFigures = new List<FigureMemento>();
            if (csvString.Length != 0)
                mFigures = CsvSerializer.DeserializeFromString<List<FigureMemento>>(csvString);

            return FigureSerializer.GetFiguresList(mFigures);
        }

        public void Save(List<Figure> figures)
        {
            string csvString = CsvSerializer.SerializeToCsv(FigureSerializer.GetMementoList(figures));
            File.WriteAllText(path, csvString);
        }
    }
}