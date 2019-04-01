using System.Collections.Generic;


namespace KamilSzymborski.VisualElementsManifest.Extensions
{
    /// <include file="Extensions/.Docs/.IDictionaryExtension.xml" path="docs/header"/>
    public static class IDictionaryExtension
    {
        #region Methods
        /// <include file="Extensions/.Docs/.IDictionaryExtension.xml" path="docs/method[@name='SetBackgroundColorOn(Dictionary{KeyValuePair{VisualElementType, string}}, int)']/*"/>
        public static void SetBackgroundColorOn(this IDictionary<VisualElementType, string> VisualElements, int RGB)
        {
            VisualElements[VisualElementType.BackgroundColor] = ColorTranslator.ToHTMLColor(RGB);
        }
        /// <include file="Extensions/.Docs/.IDictionaryExtension.xml" path="docs/method[@name='SetBackgroundColorOn(Dictionary{KeyValuePair{VisualElementType, string}}, byte, byte, byte)']/*"/>
        public static void SetBackgroundColorOn(this IDictionary<VisualElementType, string> VisualElements, byte R, byte G, byte B)
        {
            VisualElements[VisualElementType.BackgroundColor] = ColorTranslator.ToHTMLColor(R, G, B);
        }
        /// <include file="Extensions/.Docs/.IDictionaryExtension.xml" path="docs/method[@name='SetForegroundTextOn(Dictionary{KeyValuePair{VisualElementType, string}}, bool)']/*"/>
        public static void SetForegroundTextOn(this IDictionary<VisualElementType, string> VisualElements, bool Light)
        {
            VisualElements[VisualElementType.ForegroundText] = Light ? Data.FOREGROUND_TEXT_LIGHT : Data.FOREGROUND_TEXT_DARK;
        }
        /// <include file="Extensions/.Docs/.IDictionaryExtension.xml" path="docs/method[@name='SetForegroundTextOnLight(Dictionary{KeyValuePair{VisualElementType, string}})']/*"/>
        public static void SetForegroundTextOnLight(this IDictionary<VisualElementType, string> VisualElements)
        {
            VisualElements[VisualElementType.ForegroundText] = Data.FOREGROUND_TEXT_LIGHT;
        }
        /// <include file="Extensions/.Docs/.IDictionaryExtension.xml" path="docs/method[@name='SetForegroundTextOnDark(Dictionary{KeyValuePair{VisualElementType, string}})']/*"/>
        public static void SetForegroundTextOnDark(this IDictionary<VisualElementType, string> VisualElements)
        {
            VisualElements[VisualElementType.ForegroundText] = Data.FOREGROUND_TEXT_DARK;
        }
        /// <include file="Extensions/.Docs/.IDictionaryExtension.xml" path="docs/method[@name='SetShowNameOnSquare150x150LogoOn(Dictionary{KeyValuePair{VisualElementType, string}}, bool)']/*"/>
        public static void SetShowNameOnSquare150x150LogoOn(this IDictionary<VisualElementType, string> VisualElements, bool On)
        {
            VisualElements[VisualElementType.ShowNameOnSquare150x150Logo] = On? Data.SHOW_NAME_ON_SQUARE_150_X_150_LOGO_ON : Data.SHOW_NAME_ON_SQUARE_150_X_150_LOGO_OFF;
        }
        /// <include file="Extensions/.Docs/.IDictionaryExtension.xml" path="docs/method[@name='SetShowNameOnSquare150x150LogoOnOn(Dictionary{KeyValuePair{VisualElementType, string}})']/*"/>
        public static void SetShowNameOnSquare150x150LogoOnOn(this IDictionary<VisualElementType, string> VisualElements)
        {
            VisualElements[VisualElementType.ShowNameOnSquare150x150Logo] = Data.SHOW_NAME_ON_SQUARE_150_X_150_LOGO_ON;
        }
        /// <include file="Extensions/.Docs/.IDictionaryExtension.xml" path="docs/method[@name='SetShowNameOnSquare150x150LogoOnOff(Dictionary{KeyValuePair{VisualElementType, string}})']/*"/>
        public static void SetShowNameOnSquare150x150LogoOnOff(this IDictionary<VisualElementType, string> VisualElements)
        {
            VisualElements[VisualElementType.ShowNameOnSquare150x150Logo] = Data.SHOW_NAME_ON_SQUARE_150_X_150_LOGO_OFF;
        }
        /// <include file="Extensions/.Docs/.IDictionaryExtension.xml" path="docs/method[@name='SetSquare70x70LogoOn(Dictionary{KeyValuePair{VisualElementType, string}}, string)']/*"/>
        public static void SetSquare70x70LogoOn(this IDictionary<VisualElementType, string> VisualElements, string Path)
        {
            VisualElements[VisualElementType.Square70x70Logo] = NameNormalizer.Normalize(Path);
        }
        /// <include file="Extensions/.Docs/.IDictionaryExtension.xml" path="docs/method[@name='SetSquare150x150LogoOn(Dictionary{KeyValuePair{VisualElementType, string}}, string)']/*"/>
        public static void SetSquare150x150LogoOn(this IDictionary<VisualElementType, string> VisualElements, string Path)
        {
            VisualElements[VisualElementType.Square150x150Logo] = NameNormalizer.Normalize(Path);
        }
        /// <include file="Extensions/.Docs/.IDictionaryExtension.xml" path="docs/method[@name='SetSquare70x70LogoAndSquare150x150LogoOn(Dictionary{KeyValuePair{VisualElementType, string}}, string)']/*"/>
        public static void SetSquare70x70LogoAndSquare150x150LogoOn(this IDictionary<VisualElementType, string> VisualElements, string Path)
        {
            VisualElements[VisualElementType.Square70x70Logo] = VisualElements[VisualElementType.Square150x150Logo] = NameNormalizer.Normalize(Path);
        }
        /// <include file="Extensions/.Docs/.IDictionaryExtension.xml" path="docs/method[@name='IsBackgroundColorSet(Dictionary{KeyValuePair{VisualElementType, string}})']/*"/>
        public static bool IsBackgroundColorSet(this IDictionary<VisualElementType, string> VisualElements)
        {
            return VisualElements.ContainsKey(VisualElementType.BackgroundColor);
        }
        /// <include file="Extensions/.Docs/.IDictionaryExtension.xml" path="docs/method[@name='IsForegroundTextSet(Dictionary{KeyValuePair{VisualElementType, string}})']/*"/>
        public static bool IsForegroundTextSet(this IDictionary<VisualElementType, string> VisualElements)
        {
            return VisualElements.ContainsKey(VisualElementType.ForegroundText);
        }
        /// <include file="Extensions/.Docs/.IDictionaryExtension.xml" path="docs/method[@name='IsShowNameOnSquare150x150LogoSet(Dictionary{KeyValuePair{VisualElementType, string}})']/*"/>
        public static bool IsShowNameOnSquare150x150LogoSet(this IDictionary<VisualElementType, string> VisualElements)
        {
            return VisualElements.ContainsKey(VisualElementType.ShowNameOnSquare150x150Logo);
        }
        /// <include file="Extensions/.Docs/.IDictionaryExtension.xml" path="docs/method[@name='IsSquare70x70LogoSet(Dictionary{KeyValuePair{VisualElementType, string}})']/*"/>
        public static bool IsSquare70x70LogoSet(this IDictionary<VisualElementType, string> VisualElements)
        {
            return VisualElements.ContainsKey(VisualElementType.Square70x70Logo);
        }
        /// <include file="Extensions/.Docs/.IDictionaryExtension.xml" path="docs/method[@name='IsSquare150x150LogoSet(Dictionary{KeyValuePair{VisualElementType, string}})']/*"/>
        public static bool IsSquare150x150LogoSet(this IDictionary<VisualElementType, string> VisualElements)
        {
            return VisualElements.ContainsKey(VisualElementType.Square150x150Logo);
        }
        /// <include file="Extensions/.Docs/.IDictionaryExtension.xml" path="docs/method[@name='IsSquare70x70LogoAndSquare150x150LogoSet(Dictionary{KeyValuePair{VisualElementType, string}})']/*"/>
        public static bool IsSquare70x70LogoAndSquare150x150LogoSet(this IDictionary<VisualElementType, string> VisualElements)
        {
            return VisualElements.ContainsKey(VisualElementType.Square70x70Logo) && VisualElements.ContainsKey(VisualElementType.Square150x150Logo);
        }
        /// <include file="Extensions/.Docs/.IDictionaryExtension.xml" path="docs/method[@name='IsForegroundTextSetOnDark(Dictionary{KeyValuePair{VisualElementType, string}})']/*"/>
        public static bool IsForegroundTextSetOnDark(this IDictionary<VisualElementType, string> VisualElements)
        {
            return VisualElements[VisualElementType.ForegroundText] == Data.FOREGROUND_TEXT_DARK ? true : false;
        }
        /// <include file="Extensions/.Docs/.IDictionaryExtension.xml" path="docs/method[@name='IsForegroundTextSetOnLight(Dictionary{KeyValuePair{VisualElementType, string}})']/*"/>
        public static bool IsForegroundTextSetOnLight(this IDictionary<VisualElementType, string> VisualElements)
        {
            return VisualElements[VisualElementType.ForegroundText] == Data.FOREGROUND_TEXT_LIGHT ? true : false;
        }
        /// <include file="Extensions/.Docs/.IDictionaryExtension.xml" path="docs/method[@name='IsShowNameOnSquare150x150LogoSetOnOn(Dictionary{KeyValuePair{VisualElementType, string}})']/*"/>
        public static bool IsShowNameOnSquare150x150LogoSetOnOn(this IDictionary<VisualElementType, string> VisualElements)
        {
            return VisualElements[VisualElementType.ShowNameOnSquare150x150Logo] == Data.SHOW_NAME_ON_SQUARE_150_X_150_LOGO_ON ? true : false;
        }
        /// <include file="Extensions/.Docs/.IDictionaryExtension.xml" path="docs/method[@name='IsShowNameOnSquare150x150LogoSetOnOff(Dictionary{KeyValuePair{VisualElementType, string}})']/*"/>
        public static bool IsShowNameOnSquare150x150LogoSetOnOff(this IDictionary<VisualElementType, string> VisualElements)
        {
            return VisualElements[VisualElementType.ShowNameOnSquare150x150Logo] == Data.SHOW_NAME_ON_SQUARE_150_X_150_LOGO_OFF ? true : false;
        }
        /// <include file="Extensions/.Docs/.IDictionaryExtension.xml" path="docs/method[@name='GetSetBackgroundColor(Dictionary{KeyValuePair{VisualElementType, string}})']/*"/>
        public static int GetSetBackgroundColor(this IDictionary<VisualElementType, string> VisualElements)
        {
            return ColorTranslator.IsKnownColor(VisualElements[VisualElementType.BackgroundColor]) ? ColorTranslator.ToRGBColor(ColorTranslator.ToHTMLColor(VisualElements[VisualElementType.BackgroundColor])) : ColorTranslator.ToRGBColor(VisualElements[VisualElementType.BackgroundColor]);
        }
        /// <include file="Extensions/.Docs/.IDictionaryExtension.xml" path="docs/method[@name='GetSetSquare70x70Logo(Dictionary{KeyValuePair{VisualElementType, string}})']/*"/>
        public static string GetSetSquare70x70Logo(this IDictionary<VisualElementType, string> VisualElements)
        {
            return VisualElements[VisualElementType.Square70x70Logo];
        }
        /// <include file="Extensions/.Docs/.IDictionaryExtension.xml" path="docs/method[@name='GetSetSquare150x150Logo(Dictionary{KeyValuePair{VisualElementType, string}})']/*"/>
        public static string GetSetSquare150x150Logo(this IDictionary<VisualElementType, string> VisualElements)
        {
            return VisualElements[VisualElementType.Square150x150Logo];
        }
        #endregion
    }
}