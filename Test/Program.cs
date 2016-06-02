using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CurrencyConverter.Poco;
using CurrencyConverter.Util.FileReader;
using CurrencyConverter.Util.XmlUtility;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {

           var rates =  new List<CurrencyMap>
           {
               new CurrencyMap
               {
                   ExchangeRate = 1.2,
                   FromCurrencyName = "BDT",
                   ToCurrencyName = "USD"
               },
               new CurrencyMap
               {
                   ExchangeRate = 1.2,
                   FromCurrencyName = "QWA",
                   ToCurrencyName = "USD"
               },
               new CurrencyMap
               {
                   ExchangeRate = 1.2,
                   FromCurrencyName = "QBT",
                   ToCurrencyName = "USD"
               }
           };

            IXmlFileReader xmlFileReader = new XmlFileReader();
            var fileInfo = xmlFileReader.FindApplicationFile("RateMapping.xml");

           var serlizer = new XmlSerializerDeserializer(new List<Type> { typeof(CurrencyMap) });

            var xml = xmlFileReader.GetText(fileInfo.FullName);
            var objList = serlizer.DeserializerToObject<List<CurrencyMap>>(xml);


            Console.ReadLine();
        }
    }
}
