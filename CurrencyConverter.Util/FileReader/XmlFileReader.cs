using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter.Util.FileReader
{
    public class XmlFileReader : IXmlFileReader
    {
        public string GetText(string path)
        {
            string result = string.Empty;

            result = File.ReadAllText(path, Encoding.UTF8);

            return result;
        }

        public  FileInfo FindApplicationFile(string fileName)
        {
            string startPath = Path.Combine(fileName);
            FileInfo file = new FileInfo(startPath);
            while (!file.Exists)
            {
                if (file.Directory.Parent == null)
                {
                    return null;
                }
                DirectoryInfo parentDir = file.Directory.Parent;
                file = new FileInfo(Path.Combine(parentDir.FullName, file.Name));
            }
            return file;
        }
    }
}
