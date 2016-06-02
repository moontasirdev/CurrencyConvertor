using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter.Util.FileReader
{
    public interface IXmlFileReader
    {
        string GetText(string path);
        FileInfo FindApplicationFile(string fileName);
    }
}
