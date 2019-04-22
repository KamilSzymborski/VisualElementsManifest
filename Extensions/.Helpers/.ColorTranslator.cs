using System;
using System.Collections.Generic;


namespace KamilSzymborski.VisualElementsManifest.Extensions
{
    internal static class ColorTranslator
    {
        #region Methods
        internal static int ToRGBColor(string HTMLColor)
        {
            return Convert.ToInt32(HTMLColor.Substring(1), 16);
        }
        internal static bool IsKnownColor(string Name)
        {
            return KNOWN_COLORS.ContainsKey(Name.ToLower());
        }
        internal static string ToHTMLColor(string Name)
        {
            return KNOWN_COLORS[Name.ToLower()];
        }
        internal static string ToHTMLColor(int RGB)
        {
            return string.Format("#{0:x6}", RGB);
        }
        internal static string ToHTMLColor(byte R, byte G, byte B)
        {
            return string.Format("#{0:x2}{1:x2}{2:x2}", R, G, B);
        }
        #endregion

        #region Variables
        private static readonly Dictionary<string, string> KNOWN_COLORS = new Dictionary<string, string>
        {
            {"black", "#000000"},
            {"silver", "#c0c0c0"},
            {"gray", "#808080"},
            {"white", "#ffffff"},
            {"maroon", "#800000"},
            {"red", "#ff0000"},
            {"purple", "#800080"},
            {"fuchsia", "#ff00ff"},
            {"green", "#008000"},
            {"lime", "#00ff00"},
            {"olive", "#808000"},
            {"yellow", "#ffff00"},
            {"navy", "#000080"},
            {"blue", "#0000ff"},
            {"teal", "#008080"},
            {"aqua", "#00ffff"}
        };
        #endregion
    }
}