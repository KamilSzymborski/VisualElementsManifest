using VisualElementsManifest.Helpers;

using System.Collections.Generic;


namespace VisualElementsManifest
{
    internal static class ManifestPropertiesUtils
    {
        #region Methods
        internal static void SetColorOn(IDictionary<ManifestPropertyType, string> Properties, int RGB)
        {
            Properties[ManifestPropertyType.Color] = ColorTranslator.ToHTMLColor(RGB);
        }
        internal static void SetColorOn(IDictionary<ManifestPropertyType, string> Properties, byte R, byte G, byte B)
        {
            Properties[ManifestPropertyType.Color] = ColorTranslator.ToHTMLColor(R, G, B);
        }
        internal static void SetThemeOnLight(IDictionary<ManifestPropertyType, string> Properties)
        {
            Properties[ManifestPropertyType.Theme] = ManifestData.THEME_STATE_LIGHT;
        }
        internal static void SetThemeOnDark(IDictionary<ManifestPropertyType, string> Properties)
        {
            Properties[ManifestPropertyType.Theme] = ManifestData.THEME_STATE_DARK;
        }
        internal static void SetLabelStatusOnOn(IDictionary<ManifestPropertyType, string> Properties)
        {
            Properties[ManifestPropertyType.LabelStatus] = ManifestData.LABEL_STATUS_STATE_ON;
        }
        internal static void SetLabelStatusOnOff(IDictionary<ManifestPropertyType, string> Properties)
        {
            Properties[ManifestPropertyType.LabelStatus] = ManifestData.LABEL_STATUS_STATE_OFF;
        }
        internal static void SetSmallImagePathOn(IDictionary<ManifestPropertyType, string> Properties, string Path)
        {
            Properties[ManifestPropertyType.SmallImagePath] = Path;
        }
        internal static void SetMediumImagePathOn(IDictionary<ManifestPropertyType, string> Properties, string Path)
        {
            Properties[ManifestPropertyType.MediumImagePath] = Path;
        }
        internal static bool IsColorSet(IReadOnlyDictionary<ManifestPropertyType, string> Properties)
        {
            return Properties.ContainsKey(ManifestPropertyType.Color);
        }
        internal static bool IsThemeSet(IReadOnlyDictionary<ManifestPropertyType, string> Properties)
        {
            return Properties.ContainsKey(ManifestPropertyType.Theme);
        }
        internal static bool IsLabelStatusSet(IReadOnlyDictionary<ManifestPropertyType, string> Properties)
        {
            return Properties.ContainsKey(ManifestPropertyType.LabelStatus);
        }
        internal static bool IsSmallImagePathSet(IReadOnlyDictionary<ManifestPropertyType, string> Properties)
        {
            return Properties.ContainsKey(ManifestPropertyType.SmallImagePath);
        }
        internal static bool IsMediumImagePathSet(IReadOnlyDictionary<ManifestPropertyType, string> Properties)
        {
            return Properties.ContainsKey(ManifestPropertyType.MediumImagePath);
        }
        internal static bool IsThemeSetOnDark(IReadOnlyDictionary<ManifestPropertyType, string> Properties)
        {
            return Properties[ManifestPropertyType.Theme] == ManifestData.THEME_STATE_DARK ? true : false;
        }
        internal static bool IsThemeSetOnLight(IReadOnlyDictionary<ManifestPropertyType, string> Properties)
        {
            return Properties[ManifestPropertyType.Theme] == ManifestData.THEME_STATE_LIGHT ? true : false;
        }
        internal static bool IsLabelStatusSetOnOn(IReadOnlyDictionary<ManifestPropertyType, string> Properties)
        {
            return Properties[ManifestPropertyType.LabelStatus] == ManifestData.LABEL_STATUS_STATE_ON ? true : false;
        }
        internal static bool IsLabelStatusSetOnOff(IReadOnlyDictionary<ManifestPropertyType, string> Properties)
        {
            return Properties[ManifestPropertyType.LabelStatus] == ManifestData.LABEL_STATUS_STATE_OFF ? true : false;
        }
        internal static int GetSetColor(IReadOnlyDictionary<ManifestPropertyType, string> Properties)
        {
            return ColorTranslator.IsKnownColor(Properties[ManifestPropertyType.Color]) ? ColorTranslator.ToRGBColor(ColorTranslator.ToHTMLColor(Properties[ManifestPropertyType.Color])) : ColorTranslator.ToRGBColor(Properties[ManifestPropertyType.Color]);
        }
        internal static string GetSetSmallImagePath(IReadOnlyDictionary<ManifestPropertyType, string> Properties)
        {
            return Properties[ManifestPropertyType.SmallImagePath];
        }
        internal static string GetSetMediumImagePath(IReadOnlyDictionary<ManifestPropertyType, string> Properties)
        {
            return Properties[ManifestPropertyType.MediumImagePath];
        }
        #endregion
    }
}