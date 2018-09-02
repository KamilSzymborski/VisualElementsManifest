using System;


namespace VisualElementsManifest
{
    /// <include file=".Docs/ManifestPropertyType.xml" path="docs/header"/>
    [Serializable]
    public enum ManifestPropertyType
    {
        /// <include file=".Docs/ManifestPropertyType.xml" path="docs/value[@name='Color']/*"/>
        Color,
        /// <include file=".Docs/ManifestPropertyType.xml" path="docs/value[@name='Theme']/*"/>
        Theme,
        /// <include file=".Docs/ManifestPropertyType.xml" path="docs/value[@name='LabelStatus']/*"/>
        LabelStatus,
        /// <include file=".Docs/ManifestPropertyType.xml" path="docs/value[@name='SmallImagePath']/*"/>
        SmallImagePath,
        /// <include file=".Docs/ManifestPropertyType.xml" path="docs/value[@name='MediumImagePath']/*"/>
        MediumImagePath
    }
}