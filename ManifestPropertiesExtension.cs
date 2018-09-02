using System.Collections.Generic;


namespace VisualElementsManifest
{
    /// <include file=".Docs/ManifestPropertiesExtension.xml" path="docs/header"/>
    public static class ManifestPropertiesExtension
    {
        #region Methods
        /// <include file=".Docs/ManifestPropertiesExtension.xml" path="docs/method[@name='SetColorOn(Dictionary{KeyValuePair{ManifestPropertyType, String}}, Int)']/*"/>
        public static void SetColorOn(this IDictionary<ManifestPropertyType, string> Properties, int RGB)
        {
            ManifestPropertiesUtils.SetColorOn(Properties, RGB);
        }
        /// <include file=".Docs/ManifestPropertiesExtension.xml" path="docs/method[@name='SetColorOn(Dictionary{KeyValuePair{ManifestPropertyType, String}}, Byte, Byte, Byte)']/*"/>
        public static void SetColorOn(this IDictionary<ManifestPropertyType, string> Properties, byte R, byte G, byte B)
        {
            ManifestPropertiesUtils.SetColorOn(Properties, R, G, B);
        }
        /// <include file=".Docs/ManifestPropertiesExtension.xml" path="docs/method[@name='SetThemeOnLight(Dictionary{KeyValuePair{ManifestPropertyType, String}})']/*"/>
        public static void SetThemeOnLight(this IDictionary<ManifestPropertyType, string> Properties)
        {
            ManifestPropertiesUtils.SetThemeOnLight(Properties);
        }
        /// <include file=".Docs/ManifestPropertiesExtension.xml" path="docs/method[@name='SetThemeOnDark(Dictionary{KeyValuePair{ManifestPropertyType, String}})']/*"/>
        public static void SetThemeOnDark(this IDictionary<ManifestPropertyType, string> Properties)
        {
            ManifestPropertiesUtils.SetThemeOnDark(Properties);
        }
        /// <include file=".Docs/ManifestPropertiesExtension.xml" path="docs/method[@name='SetLabelStatusOnOn(Dictionary{KeyValuePair{ManifestPropertyType, String}})']/*"/>
        public static void SetLabelStatusOnOn(this IDictionary<ManifestPropertyType, string> Properties)
        {
            ManifestPropertiesUtils.SetLabelStatusOnOn(Properties);
        }
        /// <include file=".Docs/ManifestPropertiesExtension.xml" path="docs/method[@name='SetLabelStatusOnOff(Dictionary{KeyValuePair{ManifestPropertyType, String}})']/*"/>
        public static void SetLabelStatusOnOff(this IDictionary<ManifestPropertyType, string> Properties)
        {
            ManifestPropertiesUtils.SetLabelStatusOnOff(Properties);
        }
        /// <include file=".Docs/ManifestPropertiesExtension.xml" path="docs/method[@name='SetSmallImagePathOn(Dictionary{KeyValuePair{ManifestPropertyType, String}}, String)']/*"/>
        public static void SetSmallImagePathOn(this IDictionary<ManifestPropertyType, string> Properties, string Path)
        {
            ManifestPropertiesUtils.SetSmallImagePathOn(Properties, Path);
        }
        /// <include file=".Docs/ManifestPropertiesExtension.xml" path="docs/method[@name='SetMediumImagePathOn(Dictionary{KeyValuePair{ManifestPropertyType, String}}, String)']/*"/>
        public static void SetMediumImagePathOn(this IDictionary<ManifestPropertyType, string> Properties, string Path)
        {
            ManifestPropertiesUtils.SetMediumImagePathOn(Properties, Path);
        }
        /// <include file=".Docs/ManifestPropertiesExtension.xml" path="docs/method[@name='IsColorSet(Dictionary{KeyValuePair{ManifestPropertyType, String}})']/*"/>
        public static bool IsColorSet(this IReadOnlyDictionary<ManifestPropertyType, string> Properties)
        {
            return ManifestPropertiesUtils.IsColorSet(Properties);
        }
        /// <include file=".Docs/ManifestPropertiesExtension.xml" path="docs/method[@name='IsThemeSet(Dictionary{KeyValuePair{ManifestPropertyType, String}})']/*"/>
        public static bool IsThemeSet(this IReadOnlyDictionary<ManifestPropertyType, string> Properties)
        {
            return ManifestPropertiesUtils.IsThemeSet(Properties);
        }
        /// <include file=".Docs/ManifestPropertiesExtension.xml" path="docs/method[@name='IsLabelStatusSet(Dictionary{KeyValuePair{ManifestPropertyType, String}})']/*"/>
        public static bool IsLabelStatusSet(this IReadOnlyDictionary<ManifestPropertyType, string> Properties)
        {
            return ManifestPropertiesUtils.IsLabelStatusSet(Properties);
        }
        /// <include file=".Docs/ManifestPropertiesExtension.xml" path="docs/method[@name='IsSmallImagePathSet(Dictionary{KeyValuePair{ManifestPropertyType, String}})']/*"/>
        public static bool IsSmallImagePathSet(this IReadOnlyDictionary<ManifestPropertyType, string> Properties)
        {
            return ManifestPropertiesUtils.IsSmallImagePathSet(Properties);
        }
        /// <include file=".Docs/ManifestPropertiesExtension.xml" path="docs/method[@name='IsMediumImagePathSet(Dictionary{KeyValuePair{ManifestPropertyType, String}})']/*"/>
        public static bool IsMediumImagePathSet(this IReadOnlyDictionary<ManifestPropertyType, string> Properties)
        {
            return ManifestPropertiesUtils.IsMediumImagePathSet(Properties);
        }
        /// <include file=".Docs/ManifestPropertiesExtension.xml" path="docs/method[@name='IsThemeSetOnDark(Dictionary{KeyValuePair{ManifestPropertyType, String}})']/*"/>
        public static bool IsThemeSetOnDark(this IReadOnlyDictionary<ManifestPropertyType, string> Properties)
        {
            return ManifestPropertiesUtils.IsThemeSetOnDark(Properties);
        }
        /// <include file=".Docs/ManifestPropertiesExtension.xml" path="docs/method[@name='IsThemeSetOnLight(Dictionary{KeyValuePair{ManifestPropertyType, String}})']/*"/>
        public static bool IsThemeSetOnLight(this IReadOnlyDictionary<ManifestPropertyType, string> Properties)
        {
            return ManifestPropertiesUtils.IsThemeSetOnLight(Properties);
        }
        /// <include file=".Docs/ManifestPropertiesExtension.xml" path="docs/method[@name='IsLabelStatusSetOnOn(Dictionary{KeyValuePair{ManifestPropertyType, String}})']/*"/>
        public static bool IsLabelStatusSetOnOn(this IReadOnlyDictionary<ManifestPropertyType, string> Properties)
        {
            return ManifestPropertiesUtils.IsLabelStatusSetOnOn(Properties);
        }
        /// <include file=".Docs/ManifestPropertiesExtension.xml" path="docs/method[@name='IsLabelStatusSetOnOff(Dictionary{KeyValuePair{ManifestPropertyType, String}})']/*"/>
        public static bool IsLabelStatusSetOnOff(this IReadOnlyDictionary<ManifestPropertyType, string> Properties)
        {
            return ManifestPropertiesUtils.IsLabelStatusSetOnOff(Properties);
        }
        /// <include file=".Docs/ManifestPropertiesExtension.xml" path="docs/method[@name='GetSetColor(Dictionary{KeyValuePair{ManifestPropertyType, String}})']/*"/>
        public static int GetSetColor(this IReadOnlyDictionary<ManifestPropertyType, string> Properties)
        {
            return ManifestPropertiesUtils.GetSetColor(Properties);
        }
        /// <include file=".Docs/ManifestPropertiesExtension.xml" path="docs/method[@name='GetSetSmallImagePath(Dictionary{KeyValuePair{ManifestPropertyType, String}})']/*"/>
        public static string GetSetSmallImagePath(this IReadOnlyDictionary<ManifestPropertyType, string> Properties)
        {
            return ManifestPropertiesUtils.GetSetSmallImagePath(Properties);
        }
        /// <include file=".Docs/ManifestPropertiesExtension.xml" path="docs/method[@name='GetSetMediumImagePath(Dictionary{KeyValuePair{ManifestPropertyType, String}})']/*"/>
        public static string GetSetMediumImagePath(this IReadOnlyDictionary<ManifestPropertyType, string> Properties)
        {
            return ManifestPropertiesUtils.GetSetMediumImagePath(Properties);
        }
        #endregion
    }
}