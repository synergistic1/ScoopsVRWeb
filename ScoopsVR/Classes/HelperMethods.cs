using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScoopsVRWeb.Classes
{
    public static class HelperMethods
    {
        public static string CharacterLimit(this string text, int length)
        {
            if (text.Length <= length) return text; int pos = text.IndexOf(" ", length); if (pos >= 0)
                return text.Substring(0, pos) + "...";
            return text;
        }
    }
}