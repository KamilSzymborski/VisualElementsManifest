using VisualElementsManifest.Helpers;

using System.Linq;
using System.Collections.Generic;


namespace VisualElementsManifest
{
    internal static class ManifestPropertyTypesUtils
    {
        #region Methods
        internal static IEnumerable<ManifestPropertyType> Collect()
        {
            return EnumCollector.Collect<ManifestPropertyType>();
        }
        internal static IEnumerable<ManifestPropertyType> CollectRequirement()
        {
            return EnumCollector.Collect<ManifestPropertyType>().Where(PropertyType => ManifestData.PROPERTY_REQUIREMENTS[PropertyType]);
        }
        internal static IEnumerable<ManifestPropertyType> CollectNotRequirement()
        {
            return EnumCollector.Collect<ManifestPropertyType>().Where(PropertyType => ManifestData.PROPERTY_REQUIREMENTS[PropertyType] == false);
        }
        #endregion
    }
}