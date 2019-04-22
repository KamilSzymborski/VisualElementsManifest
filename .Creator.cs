using System.Xml.Linq;
using System.Collections.Generic;


namespace KamilSzymborski.VisualElementsManifest
{
    internal static class Creator
    {
        #region Methods
        internal static string Create(IEnumerable<KeyValuePair<VisualElementType, string>> VisualElements)
        {
            var Manifest = new XDocument();

            Utils.CreateRoot(Manifest);
            Utils.CreateContainer(Manifest);
            Utils.AddVisualElements(Manifest, VisualElements);

            return Manifest.ToString();
        }
        #endregion
    }
}