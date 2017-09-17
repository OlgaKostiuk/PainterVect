
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace PainterVect
{
    public class FileSO_BIN : IFileSO
    {
        string path = "";
        public FileSO_BIN(string path)
        {
            this.path = path;
        }


        public List<Figure> Open()
        {
            if (File.Exists(path) == false)
            {
                FileStream fs = File.Create(path);
                fs.Close();
                return new List<Figure>();
            }
            List<FigureMemento> lf = new List<FigureMemento>();
            using (Stream stream = File.Open(path, FileMode.Open))
            {
                BinaryFormatter bformatter = new BinaryFormatter();
                lf = (List<FigureMemento>)bformatter.Deserialize(stream);
            }
            return FigureSerializer.GetFiguresList(lf);
        }

        public void Save(List<Figure> figures)
        {
            using (Stream stream = File.Open(path, FileMode.Create))
            {
                BinaryFormatter bformatter = new BinaryFormatter();
                bformatter.Serialize(stream, FigureSerializer.GetMementoList(figures));
            }
        }
    }
}