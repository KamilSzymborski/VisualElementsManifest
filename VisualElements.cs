using System.Collections.Generic;


namespace KamilSzymborski.VisualElementsManifest
{
    /// <include file=".Docs/.VisualElements.xml" path="docs/header"/>
    public class VisualElements : Dictionary<VisualElementType, string>
    {
        #region Constructors
        /// <include file=".Docs/.VisualElements.xml" path="docs/constructor[@name='()']"/>
        public VisualElements() { }
        /// <include file=".Docs/.VisualElements.xml" path="docs/constructor[@name='(IDictionary{KeyValuePair{VisualElementType, string}})']"/>
        public VisualElements(IDictionary<VisualElementType, string> VisualElements)
            : base(VisualElements)
        { }
        #endregion
    }
}