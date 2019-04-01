using System.Text.RegularExpressions;


namespace KamilSzymborski.VisualElementsManifest
{
    internal static class StringValidator
    {
        #region methods
        internal static bool Validate(string Value, string Pattern, bool IgnoreCase)
        {
            return IgnoreCase ? Regex.IsMatch(Value, Pattern, RegexOptions.IgnoreCase) : Regex.IsMatch(Value, Pattern);
        }
        #endregion
    }
}