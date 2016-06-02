namespace CurrencyConverter.Util.XmlUtility
{
    public interface IXmlSerializer
    {
        string SerializeToXml<T>(T t);
    }
}