using System;
using System.Collections.Generic;
using System.Text;

namespace TextFilter.Extensions
{
    public static class StringExtensions
    {
        public static string MiddleLetters(this string value)
        {
            if (String.IsNullOrEmpty(value))
                return value;

            return value.Length % 2 == 0 ?
                    value.ToLower().Substring(value.Length / 2 - 1, 2)
                : value.ToLower().Substring(value.Length / 2, 1); 
        }
    }
}
