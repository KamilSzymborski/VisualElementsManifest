using System.Collections.Generic;


namespace KamilSzymborski.VisualElementsManifest
{
    internal static class Data
    {
        #region Variables
        internal static readonly string ROOT = "Application";
        internal static readonly string CONTAINER = "VisualElements";
        internal static readonly string FOREGROUND_TEXT_DARK = "dark";
        internal static readonly string FOREGROUND_TEXT_LIGHT = "light";
        internal static readonly string SHOW_NAME_ON_SQUARE_150_X_150_LOGO_ON = "on";
        internal static readonly string SHOW_NAME_ON_SQUARE_150_X_150_LOGO_OFF = "off";

        internal static readonly Dictionary<VisualElementType, string> NAMES = new Dictionary<VisualElementType, string>
            {
                {VisualElementType.BackgroundColor, "BackgroundColor"},
                {VisualElementType.ForegroundText, "ForegroundText"},
                {VisualElementType.ShowNameOnSquare150x150Logo, "ShowNameOnSquare150x150Logo"},
                {VisualElementType.Square70x70Logo, "Square70x70Logo"},
                {VisualElementType.Square150x150Logo, "Square150x150Logo"}
            };
        internal static readonly Dictionary<VisualElementType, string> PATTERNS = new Dictionary<VisualElementType, string>
            {
                {VisualElementType.BackgroundColor, "^((#[a-fA-F0-9]{6})|(black|silver|gray|white|maroon|red|purple|fuchsia|green|lime|olive|yellow|navy|blue|teal|aqua))$"},
                {VisualElementType.ForegroundText, "^(light|dark)$"},
                {VisualElementType.ShowNameOnSquare150x150Logo, "^(on|off)$"},
                {VisualElementType.Square70x70Logo, "^[^<>:\\*\\?\\.\\^\\;\\/\\\\|]{1}[^<>\\*\\.\\?\\/\\|\"]{0,248}\\.((jpg)|(png)|(jpeg)|(gif))$"},
                {VisualElementType.Square150x150Logo, "^[^<>:\\*\\?\\.\\^\\;\\/\\\\|]{1}[^<>\\*\\.\\?\\/\\|\"]{0,248}\\.((jpg)|(png)|(jpeg)|(gif))$"}
            };
        internal static readonly Dictionary<VisualElementType, bool> REQUIREMENTS = new Dictionary<VisualElementType, bool>
            {
                {VisualElementType.BackgroundColor, true},
                {VisualElementType.ForegroundText, true},
                {VisualElementType.ShowNameOnSquare150x150Logo, true},
                {VisualElementType.Square70x70Logo, false},
                {VisualElementType.Square150x150Logo, false}
            };
        #endregion
    }
}