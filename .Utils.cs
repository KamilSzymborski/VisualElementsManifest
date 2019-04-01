using System.Linq;
using System.Xml.Linq;
using System.Collections.Generic;


namespace KamilSzymborski.VisualElementsManifest
{
    internal static class Utils
    {
        #region Methods
        internal static void CreateRoot(XDocument Manifest)
        {
            AddElement(Manifest, Data.ROOT);
        }
        internal static void CreateContainer(XDocument Manifest)
        {
            AddElementOn(Manifest, Data.ROOT, Data.CONTAINER);
        }
        internal static void AddVisualElements(XDocument Manifest, IEnumerable<KeyValuePair<VisualElementType, string>> VisualElements)
        {
            VisualElements.ToList().ForEach(VisualElement => AddAttributeOn(Manifest, Data.CONTAINER, Data.NAMES[VisualElement.Key], VisualElement.Value));
        }
        internal static bool HasRoot(XDocument Manifest)
        {
            return HasElement(Manifest, Data.ROOT);
        }
        internal static bool HasContainer(XDocument Manifest)
        {
            return HasElementOn(Manifest, Data.ROOT, Data.CONTAINER);
        }
        internal static bool HasVisualElement(XDocument Manifest, VisualElementType VisualElementType)
        {
            return HasAttributeOn(Manifest, Data.CONTAINER, Data.NAMES[VisualElementType]);
        }
        internal static KeyValuePair<VisualElementType, string> GetVisualElement(XDocument Manifest, VisualElementType VisualElementType)
        {
            return new KeyValuePair<VisualElementType, string>(VisualElementType, GetAttributeValueOf(Manifest, Data.CONTAINER, Data.NAMES[VisualElementType]));
        }

        private static void AddElement(XDocument Document, string Name)
        {
            Document.Add(new XElement(Name));
        }
        private static void AddElementOn(XDocument Document, string Parent, string Name)
        {
            Document.Descendants().Single(Element => Element.Name.LocalName.Equals(Parent)).Add(new XElement(Name));
        }
        private static void AddAttributeOn(XDocument Document, string Parent, string Name, string Value)
        {
            Document.Descendants().Single(Element => Element.Name.LocalName.Equals(Parent)).Add(new XAttribute(Name, Value));
        }
        private static bool HasElement(XDocument Document, string Name)
        {
            return Document.Descendants().Any(Element => Element.Name.LocalName.Equals(Name));
        }
        private static bool HasElementOn(XDocument Document, string Parent, string Name)
        {
            return Document.Descendants().Single(Element => Element.Name.LocalName.Equals(Parent)).Elements().Any(Element => Element.Name.LocalName.Equals(Name));
        }
        private static bool HasAttributeOn(XDocument Document, string Parent, string Name)
        {
            return Document.Descendants().Single(Element => Element.Name.LocalName.Equals(Parent)).Attributes().Any(Attribute => Attribute.Name.LocalName.Equals(Name));
        }
        private static string GetAttributeValueOf(XDocument Document, string Parent, string Name)
        {
            return Document.Descendants().Single(Element => Element.Name.LocalName.Equals(Parent)).Attribute(Name).Value;
        }
        #endregion
    } 
}