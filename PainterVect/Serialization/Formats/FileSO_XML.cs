using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace PainterVect
{
    public class FileSO_XML : IFileSO
    {
        string path = "";
        public FileSO_XML(string path)
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
            TextReader reader = File.OpenText(path);
            
            XmlSerializer serializer = new XmlSerializer(typeof(List<FigureMemento>));
            List<FigureMemento> figures = new List<FigureMemento>();
            try
            {
                figures = (List<FigureMemento>)serializer.Deserialize(reader);
            }
            catch (Exception)
            {
                figures = new List<FigureMemento>();
            }

            reader.Close();
            return FigureSerializer.GetFiguresList(figures);
        }

        public void Save(List<Figure> figures)
        {
            TextWriter writer = File.CreateText(path);
            XmlSerializer serializer = new XmlSerializer(typeof(List<FigureMemento>));
            serializer.Serialize(writer, FigureSerializer.GetMementoList(figures));
            writer.Close();
        }

    }
}