using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using CurrencyConverter.Poco;
using CurrencyConverter.Util.FileReader;
using CurrencyConverter.Util.XmlUtility;

namespace CurrencyConverter.Resource.Controllers
{
     [EnableCors(origins: "http://localhost:8080", headers: "*", methods: "*")]
    public class ValuesController : ApiController
    {
        // GET api/values
         public List<CurrencyMap> Get()
        {
            var serlizer = new XmlSerializerDeserializer(new List<Type> { typeof(CurrencyMap) });
            IXmlFileReader xmlFileReader = new XmlFileReader();
            var filePath = ConfigurationManager.AppSettings["configFile"];
            var fileInfo = xmlFileReader.FindApplicationFile(filePath);
            var xml = xmlFileReader.GetText(fileInfo.FullName);
            var objList = serlizer.DeserializerToObject<List<CurrencyMap>>(xml);
            return objList;
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
