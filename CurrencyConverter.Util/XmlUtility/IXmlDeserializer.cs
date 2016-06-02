namespace CurrencyConverter.Util.XmlUtility
{
    public interface IXmlDeserializer
    {
        T DeserializerToObject<T>(string xml);
    }
}