using System;
using System.Collections.Generic;

namespace CurrencyConverter.Util.XmlUtility
{
    public interface IXmlSerializerDeserializer : IXmlDeserializer, IXmlSerializer
    {
        void AddType(Type type);
        void AddTypes(List<Type> types);
    }
}