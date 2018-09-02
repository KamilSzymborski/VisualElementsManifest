using System;
using System.Collections.Generic;


namespace VisualElementsManifest
{
    /// <include file=".Docs/ManifestProperties.xml" path="docs/header"/>
    [Serializable]
    public class ManifestProperties : Dictionary<ManifestPropertyType, string>
    {
        #region Constructors
        /// <include file=".Docs/ManifestProperties.xml" path="docs/constructor[@name='()']"/>
        public ManifestProperties() { }
        /// <include file=".Docs/ManifestProperties.xml" path="docs/constructor[@name='(IDictionary{KeyValuePair{ManifestPropertyType, String}})']"/>
        public ManifestProperties(IDictionary<ManifestPropertyType, string> Properties)
            : base(Properties)
        { }
        #endregion
    }
}