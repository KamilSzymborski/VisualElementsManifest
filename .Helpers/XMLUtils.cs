using System.Linq;
using System.Xml.Linq;


namespace VisualElementsManifest.Helpers
{
    internal static class XmlUtils
    {
        #region methods
        internal static void AddElement(XDocument Document, string Name)
        {
            Document.Add(new XElement(Name));
        }
        internal static void AddElementOn(XDocument Document, string Parent, string Name)
        {
            Document
                .Descendants()
                .Single(Element => Element.Name.LocalName.Equals(Parent))
                .Add(new XElement(Name));
        }
        internal static void AddAttributeOn(XDocument Document, string Parent, string Name, string Value)
        {
            Document
                .Descendants()
                .Single(Element => Element.Name.LocalName.Equals(Parent))
                .Add(new XAttribute(Name, Value));
        }
        internal static bool HasElement(XDocument Document, string Name)
        {
            return Document
                .Descendants()
                .Any(Element => Element.Name.LocalName.Equals(Name));
        }
        internal static bool HasElementOn(XDocument Document, string Parent, string Name)
        {
            return Document
                .Descendants()
                .Single(Element => Element.Name.LocalName.Equals(Parent))
                .Elements()
                .Any(Element => Element.Name.LocalName.Equals(Name));
        }
        internal static bool HasAttributeOn(XDocument Document, string Parent, string Name)
        {
            return Document
                .Descendants()
                .Single(Element => Element.Name.LocalName.Equals(Parent))
                .Attributes()
                .Any(Attribute => Attribute.Name.LocalName.Equals(Name));
        }
        internal static string GetAttributeValueOf(XDocument Document, string Parent, string Name)
        {
            return Document
                .Descendants()
                .Single(Element => Element.Name.LocalName.Equals(Parent))
                .Attribute(Name)
                .Value;
        }
        #endregion
    }
}