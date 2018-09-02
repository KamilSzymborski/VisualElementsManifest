using System;
using System.Linq;
using System.Collections.Generic;


namespace VisualElementsManifest.Helpers
{
    internal static class EnumCollector
    {
        #region methods
        internal static IEnumerable<T> Collect<T>()
        {
            return Enum.GetValues(typeof(T)).Cast<T>();
        }
        #endregion
    }
}