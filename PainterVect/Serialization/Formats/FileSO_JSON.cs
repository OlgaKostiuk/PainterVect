
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PainterVect
{
    public class FileSO_JSON : IFileSO
    {

        string path = "";
        public FileSO_JSON(string path) 
        {
            this.path = path;
        }


        public List<Figure> Open()
        {
            if (File.Exists(path) == false)
            {
                FileStream fs = File.Create(path);
                fs.Close();
            }
            string jsonString = File.ReadAllText(path);
            List<FigureMemento> figures = new List<FigureMemento>();
            if (jsonString.Length != 0)
                figures = JsonConvert.DeserializeObject<List<FigureMemento>>(jsonString);

            return FigureSerializer.GetFiguresList(figures);
        }

        public void Save(List<Figure> figures)
        {
            string jsonString = JsonConvert.SerializeObject(FigureSerializer.GetMementoList(figures));
            File.WriteAllText(path, jsonString);
        }
    }
}