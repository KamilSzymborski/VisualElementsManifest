namespace KamilSzymborski.VisualElementsManifest.Tools
{
    /// <include file="Tools/.Docs/.ManifestNameBuilder.xml" path="docs/header"/>
    public static class ManifestNameBuilder
    {
        #region Constants
        private const string EXTENSION = "xml";
        private const string SEPARATOR = ".";
        private const string BASE_NAME = "VisualElementsManifest";
        #endregion

        #region Methods
        /// <include file="Tools/.Docs/.ManifestNameBuilder.xml" path="docs/method[@name='Build(string)']"/>
        public static string Build(string AppName)
        {
            return $"{AppName}{SEPARATOR}{BASE_NAME}{SEPARATOR}{EXTENSION}";
        }
        #endregion
    }
}