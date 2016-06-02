using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter.Poco
{
    public class CurrencyMap
    {
        public string FromCurrencyName { get; set; }
        public string ToCurrencyName { get; set; }
        public double ExchangeRate { get; set; }
    }
}
