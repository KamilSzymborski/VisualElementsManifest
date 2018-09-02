using System.Collections.Generic;


namespace VisualElementsManifest
{
    internal static class ManifestData
    {
        #region Variables
        internal static readonly string ROOT = "Application";
        internal static readonly string PROPERTY_CONTAINER = "VisualElements";
        internal static readonly string THEME_STATE_DARK = "dark";
        internal static readonly string THEME_STATE_LIGHT = "light";
        internal static readonly string LABEL_STATUS_STATE_ON = "on";
        internal static readonly string LABEL_STATUS_STATE_OFF = "off";

        internal static readonly IReadOnlyDictionary<ManifestPropertyType, string> PROPERTY_NAMES = new Dictionary<ManifestPropertyType, string>
            {
                {ManifestPropertyType.Color, "BackgroundColor"},
                {ManifestPropertyType.Theme, "ForegroundText"},
                {ManifestPropertyType.LabelStatus, "ShowNameOnSquare150x150Logo"},
                {ManifestPropertyType.SmallImagePath, "Square70x70Logo"},
                {ManifestPropertyType.MediumImagePath, "Square150x150Logo"}
            };
        internal static readonly IReadOnlyDictionary<ManifestPropertyType, string> PROPERTY_PATTERNS = new Dictionary<ManifestPropertyType, string>
            {
                {ManifestPropertyType.Color, "^((#[a-fA-F0-9]{6})|(black|silver|gray|white|maroon|red|purple|fuchsia|green|lime|olive|yellow|navy|blue|teal|aqua))$"},
                {ManifestPropertyType.Theme, "^(light|dark)$"},
                {ManifestPropertyType.LabelStatus, "^(on|off)$"},
                {ManifestPropertyType.SmallImagePath, "^[^<>:\\*\\?\\.\\^\\;\\/\\\\|]{1}[^<>\\*\\.\\?\\/\\|\"]{0,248}\\.((jpg)|(png)|(jpeg)|(gif))$"},
                {ManifestPropertyType.MediumImagePath, "^[^<>:\\*\\?\\.\\^\\;\\/\\\\|]{1}[^<>\\*\\.\\?\\/\\|\"]{0,248}\\.((jpg)|(png)|(jpeg)|(gif))$"}
            };
        internal static readonly IReadOnlyDictionary<ManifestPropertyType, bool> PROPERTY_REQUIREMENTS = new Dictionary<ManifestPropertyType, bool>
            {
                {ManifestPropertyType.Color, true},
                {ManifestPropertyType.Theme, true},
                {ManifestPropertyType.LabelStatus, true},
                {ManifestPropertyType.SmallImagePath, false},
                {ManifestPropertyType.MediumImagePath, false}
            };
        #endregion
    }
}