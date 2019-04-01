using System.IO;


namespace KamilSzymborski.VisualElementsManifest.Extensions
{
    internal static class NameNormalizer
    {
        #region Methods
        internal static string Normalize(string Name)
        {
            return Path.ChangeExtension(Name, Path.GetExtension(Name).ToLower());
        }
        #endregion
    }
}