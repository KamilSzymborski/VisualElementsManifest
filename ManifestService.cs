using System.Collections.Generic;


namespace KamilSzymborski.VisualElementsManifest
{
    /// <include file=".Docs/.ManifestService.xml" path="docs/header"/>
    public static class ManifestService
    {
        #region Methods
        /// <include file=".Docs/.ManifestService.xml" path="docs/method[@name='Validate(string)']/*"/>
        public static bool Validate(string Manifest)
        {
            return Validator.Validate(Manifest);
        }

        /// <include file=".Docs/.ManifestService.xml" path="docs/method[@name='Create({KeyValuePair{VisualElementType, string}})']/*"/>
        public static string Create(IEnumerable<KeyValuePair<VisualElementType, string>> VisualElements)
        {
            return Creator.Create(VisualElements);
        }

        /// <include file=".Docs/.ManifestService.xml" path="docs/method[@name='Parse(string)']/*"/>
        public static VisualElements Parse(string Manifest)
        {
            return Parser.Parse(Manifest);
        }
        #endregion
    }
}