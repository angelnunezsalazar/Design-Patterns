namespace MVP
{
    using System.Xml;

    public interface IProductMapper
    {
        Product Map(XmlReader reader);
    }
}