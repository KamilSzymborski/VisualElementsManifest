using System.Linq;
using System.Xml.Linq;


namespace KamilSzymborski.VisualElementsManifest
{
    internal static class Validator
    {
        #region Methods
        internal static bool Validate(string Xml)
        {
            XDocument Manifest;

            try
            {
                Manifest = XDocument.Parse(Xml);
            }
            catch
            {
                return false;
            }

            return ValidateStructure(Manifest) && ValidateSet(Manifest) && ValidateValues(Manifest);
        }

        private static bool ValidateSet(XDocument Manifest)
        {
            return EnumCollector.Collect<VisualElementType>().Where(PropertyType => Data.REQUIREMENTS[PropertyType] == false).Any(Type => Utils.HasVisualElement(Manifest, Type)) ? EnumCollector.Collect<VisualElementType>().All(Type => Utils.HasVisualElement(Manifest, Type)) : EnumCollector.Collect<VisualElementType>().Where(PropertyType => Data.REQUIREMENTS[PropertyType] == true).All(Type => Utils.HasVisualElement(Manifest, Type));
        }
        private static bool ValidateValues(XDocument Manifest)
        {
            return EnumCollector.Collect<VisualElementType>().Where(Type => Utils.HasVisualElement(Manifest, Type)).All(Type => StringValidator.Validate(Utils.GetVisualElement(Manifest, Type).Value, Data.PATTERNS[Type], false));
        }
        private static bool ValidateStructure(XDocument Manifest)
        {
            return Utils.HasRoot(Manifest) && Utils.HasContainer(Manifest);
        }
        
        #endregion
    }
}