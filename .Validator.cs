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

            return ValidateElements(Manifest) && ValidateAttributeSet(Manifest) && ValidateValueSet(Manifest);
        }

        private static bool ValidateAttributeSet(XDocument Manifest)
        {
            return EnumCollector.Collect<VisualElementType>().Where(PropertyType => Data.REQUIREMENTS[PropertyType] == false).Any(Type => Utils.HasVisualElement(Manifest, Type)) ? EnumCollector.Collect<VisualElementType>().All(Type => Utils.HasVisualElement(Manifest, Type)) : EnumCollector.Collect<VisualElementType>().Where(PropertyType => Data.REQUIREMENTS[PropertyType] == true).All(Type => Utils.HasVisualElement(Manifest, Type));
        }
        private static bool ValidateValueSet(XDocument Manifest)
        {
            return EnumCollector.Collect<VisualElementType>().Where(Type => Utils.HasVisualElement(Manifest, Type)).All(Type => StringValidator.Validate(Utils.GetVisualElement(Manifest, Type).Value, Data.PATTERNS[Type], false));
        }
        private static bool ValidateElements(XDocument Manifest)
        {
            return Utils.HasRoot(Manifest) && Utils.HasContainer(Manifest);
        }
        #endregion
    }
}