using System.Xml.Linq;
using System.Collections.Generic;


namespace KamilSzymborski.VisualElementsManifest
{
    internal static class Creator
    {
        #region Methods
        internal static string Create(IEnumerable<KeyValuePair<VisualElementType, string>> VisualElements)
        {
            var XVisualElementsManifest = new XDocument();

            Utils.CreateRoot(XVisualElementsManifest);
            Utils.CreateContainer(XVisualElementsManifest);
            Utils.AddVisualElements(XVisualElementsManifest, VisualElements);

            return XVisualElementsManifest.ToString();
        }
        #endregion
    }
}