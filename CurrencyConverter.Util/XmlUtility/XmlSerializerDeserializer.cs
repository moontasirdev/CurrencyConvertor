using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace CurrencyConverter.Util.XmlUtility
{
    public class XmlSerializerDeserializer : IXmlSerializerDeserializer
    {
        #region IXmlDeserializer Members

        private List<Type> _types;

        public XmlSerializerDeserializer(List<Type> types = null)
        {
            _types = types ?? new List<Type>();
        }

        public T DeserializerToObject<T>(string xml)
        {
            var xs = new XmlSerializer(typeof(T), _types.ToArray());
            var memoryStream = new MemoryStream(StringToUtf8ByteArray(xml));
            var xmlTextWriter = new XmlTextWriter(memoryStream, Encoding.UTF8);
            return (T)xs.Deserialize(memoryStream);
        }

        #endregion

        #region IXmlSerializer Members

        public string SerializeToXml<T>(T obj)
        {
            try
            {
                var memoryStream = new MemoryStream();
                var xs = new XmlSerializer(typeof(T), _types.ToArray());
                var xmlTextWriter = new XmlTextWriter(memoryStream, Encoding.UTF8);
                xs.Serialize(xmlTextWriter, obj);
                memoryStream = (MemoryStream)xmlTextWriter.BaseStream;
                string xmlString = Utf8ByteArrayToString(memoryStream.ToArray());
                return xmlString;
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        #endregion

        private string Utf8ByteArrayToString(byte[] characters)
        {
            var encoding = new UTF8Encoding();
            string constructedString = encoding.GetString(characters);
            return (constructedString);
        }

        private Byte[] StringToUtf8ByteArray(string pXmlString)
        {
            var encoding = new UTF8Encoding();
            byte[] byteArray = encoding.GetBytes(pXmlString);
            return byteArray;
        }

        public void AddType(Type type)
        {
            _types.Add(type);
        }

        public void AddTypes(List<Type> types)
        {
            _types.AddRange(types);
        }
    }
}