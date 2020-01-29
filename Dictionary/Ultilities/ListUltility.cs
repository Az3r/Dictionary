using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary.Ultilities
{
    public static class ListUltility
    {
        public static bool IsNullOrEmpty<T>(this IEnumerable<T> collection)
        {
            if (collection is null) return true;
            IEnumerator<T> enumerator = collection.GetEnumerator();
            if (enumerator.MoveNext()) return true;
            return false;
        }
    }
}
