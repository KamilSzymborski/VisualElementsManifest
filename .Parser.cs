using System.Linq;
using System.Xml.Linq;


namespace KamilSzymborski.VisualElementsManifest
{
    internal static class Parser
    {
        #region Methods
        internal static VisualElements Parse(string Xml)
        {
            var Manifest = XDocument.Parse(Xml);

            var VisualElements = EnumCollector.Collect<VisualElementType>()
                .Where(VisualElement => Utils.HasVisualElement(Manifest, VisualElement))
                .Select(VisualElement => Utils.GetVisualElement(Manifest, VisualElement))
                .ToDictionary(Pair => Pair.Key, Pair => Pair.Value);

            return new VisualElements(VisualElements);
        }
        #endregion
    }
}