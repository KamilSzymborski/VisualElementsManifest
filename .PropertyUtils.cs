using VisualElementsManifest.Helpers;

using System.Collections.Generic;


namespace VisualElementsManifest
{
    internal static class ManifestPropertyUtils
    {
        #region Methods
        internal static bool Validate(KeyValuePair<ManifestPropertyType, string> Property)
        {
            return StringValidator.Validate(Property.Value, ManifestData.PROPERTY_PATTERNS[Property.Key], false);
        }
        #endregion
    }
}