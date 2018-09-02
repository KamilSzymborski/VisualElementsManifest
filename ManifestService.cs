using System.Linq;
using System.Xml.Linq;
using System.Collections.Generic;


namespace VisualElementsManifest
{
    /// <include file=".Docs/ManifestService.xml" path="docs/header"/>
    public static class ManifestService
    {
        #region Methods
        /// <include file=".Docs/ManifestService.xml" path="docs/method[@name='Validate(String)']/*"/>
        public static bool Validate(string Manifest)
        {
            bool Valid;

            try
            {
                Valid = ManifestValidator.Validate(XDocument.Parse(Manifest));
            }
            catch
            {
                Valid = false;
            }

            return Valid;
        }

        /// <include file=".Docs/ManifestService.xml" path="docs/method[@name='Create({KeyValuePair{ManifestPropertyType, String}})']/*"/>
        public static string Create(IEnumerable<KeyValuePair<ManifestPropertyType, string>> Properties)
        {
            return ManifestCreator.Create(Properties);
        }

        /// <include file=".Docs/ManifestService.xml" path="docs/method[@name='Parse(String)']/*"/>
        public static ManifestProperties Parse(string Manifest)
        {
            return new ManifestProperties(ManifestParser.Parse(XDocument.Parse(Manifest)));
        }
        #endregion
    }

    internal static class ManifestCreator
    {
        #region Methods
        internal static string Create(IEnumerable<KeyValuePair<ManifestPropertyType, string>> Properties)
        {
            var Manifest = new XDocument();

            ManifestUtils.CreateRoot(Manifest);
            ManifestUtils.CreatePropertyContainer(Manifest);
            ManifestUtils.AddProperties(Manifest, Properties);

            return Manifest.ToString();
        }
        #endregion
    }

    internal static class ManifestParser
    {
        #region Methods
        internal static Dictionary<ManifestPropertyType, string> Parse(XDocument Manifest)
        {
            return ManifestPropertyTypesUtils.Collect()
                .Where(PropertyType => ManifestUtils.HasProperty(Manifest, PropertyType))
                .Select(PropertyType => ManifestUtils.GetProperty(Manifest, PropertyType))
                .ToDictionary(Pair => Pair.Key, Pair => Pair.Value);
        }
        #endregion
    }

    internal static class ManifestValidator
    {
        #region Methods
        internal static bool Validate(XDocument Manifest)
        {
            return ValidateStructure(Manifest) && ValidatePropertySet(Manifest) && ValidatePropertyValues(Manifest);
        }

        private static bool ValidateStructure(XDocument Manifest)
        {
            return ManifestUtils.HasRoot(Manifest) && ManifestUtils.HasPropertyContainer(Manifest);
        }
        private static bool ValidatePropertySet(XDocument Manifest)
        {
            return ManifestPropertyTypesUtils.CollectNotRequirement().Any(PropertyType => ManifestUtils.HasProperty(Manifest, PropertyType)) ?
                ManifestPropertyTypesUtils.Collect().All(PropertyType => ManifestUtils.HasProperty(Manifest, PropertyType))
                    :
                ManifestPropertyTypesUtils.CollectRequirement().All(PropertyType => ManifestUtils.HasProperty(Manifest, PropertyType));
        }
        private static bool ValidatePropertyValues(XDocument Manifest)
        {
            return ManifestPropertyTypesUtils.Collect().Where(PropertyType => ManifestUtils.HasProperty(Manifest, PropertyType)).All(PropertyType => ManifestPropertyUtils.Validate(ManifestUtils.GetProperty(Manifest, PropertyType)));
        }
        #endregion
    }
}