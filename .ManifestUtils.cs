using VisualElementsManifest.Helpers;

using System.Linq;
using System.Xml.Linq;
using System.Collections.Generic;


namespace VisualElementsManifest
{
    internal static class ManifestUtils
    {
        #region Methods
        internal static void CreateRoot(XDocument Manifest)
        {
            XmlUtils.AddElement(Manifest, ManifestData.ROOT);
        }
        internal static void CreatePropertyContainer(XDocument Manifest)
        {
            XmlUtils.AddElementOn(Manifest, ManifestData.ROOT, ManifestData.PROPERTY_CONTAINER);
        }
        internal static void AddProperties(XDocument Manifest, IEnumerable<KeyValuePair<ManifestPropertyType, string>> Properties)
        {
            Properties.ToList().ForEach(Property => AddProperty(Manifest, Property));
        }
        internal static bool HasRoot(XDocument Manifest)
        {
            return XmlUtils.HasElement(Manifest, ManifestData.ROOT);
        }
        internal static bool HasPropertyContainer(XDocument Manifest)
        {
            return XmlUtils.HasElementOn(Manifest, ManifestData.ROOT, ManifestData.PROPERTY_CONTAINER);
        }
        internal static bool HasProperty(XDocument Manifest, ManifestPropertyType PropertyType)
        {
            return XmlUtils.HasAttributeOn(Manifest, ManifestData.PROPERTY_CONTAINER, ManifestData.PROPERTY_NAMES[PropertyType]);
        }
        internal static KeyValuePair<ManifestPropertyType, string> GetProperty(XDocument Manifest, ManifestPropertyType PropertyType)
        {
            return new KeyValuePair<ManifestPropertyType, string>(PropertyType, XmlUtils.GetAttributeValueOf(Manifest, ManifestData.PROPERTY_CONTAINER, ManifestData.PROPERTY_NAMES[PropertyType]));
        }

        private static void AddProperty(XDocument Manifest, KeyValuePair<ManifestPropertyType, string> Property)
        {
            XmlUtils.AddAttributeOn(Manifest, ManifestData.PROPERTY_CONTAINER, ManifestData.PROPERTY_NAMES[Property.Key], Property.Value);
        }
        #endregion
    } 
}