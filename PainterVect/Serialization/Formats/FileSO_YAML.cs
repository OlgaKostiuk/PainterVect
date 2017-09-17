using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YamlDotNet.Serialization;

namespace PainterVect
{
    class FileSO_YAML : IFileSO
    {
        string path = "";
        public FileSO_YAML(string path)
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
            string yamlString = File.ReadAllText(path);
            List<FigureMemento> figures = new List<FigureMemento>();
            Deserializer deserializer = new Deserializer();
            if (yamlString.Length != 0)
                figures  = deserializer.Deserialize<List<FigureMemento>>(yamlString);

            return FigureSerializer.GetFiguresList(figures);
        }

        public void Save(List<Figure> figures)
        {
            Serializer serializer = new Serializer();
            string yamlString = serializer.Serialize(FigureSerializer.GetMementoList(figures));
            File.WriteAllText(path, yamlString);
        }

    }
}
