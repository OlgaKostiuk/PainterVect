namespace PainterVect
{
    class SOFactory
    {
        public static IFileSO GetInstance(string path)
        {
            IFileSO fs = null;
            string[] type = path.Split('.');
            switch (type[type.Length - 1])
            {
                case "json":
                    fs = new FileSO_JSON(path);
                    break;
                case "csv":
                    fs = new FileSO_CSV(path);
                    break;
                case "xml":
                    fs = new FileSO_XML(path);
                    break;
                case "yaml":
                    fs = new FileSO_YAML(path);
                    break;
                case "bin":
                    fs = new FileSO_BIN(path);
                    break;
            }
            return fs;
        }
    }
}