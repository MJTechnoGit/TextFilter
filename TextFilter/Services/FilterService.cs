using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

using TextFilter.Extensions;
using TextFilter.Interfaces;

namespace TextFilter.Services
{
    public class FilterService : IFilterService
    {
        readonly char[] vowels = { 'A', 'a', 'E', 'e', 'I', 'i', 'O', 'o', 'U', 'u' };

        public bool HasVowelsInCentre(string word)
        {
            bool vowelsInCentre = false;

            if (word.MiddleLetters() == null)
            {
                return vowelsInCentre;
            }    

            // Check for any vowels in the middle of the word.
            if (word.MiddleLetters().ToCharArray().Any(c => vowels.Contains(c)))
            {
                vowelsInCentre = true;
            }

                    
            return vowelsInCentre;
        }

        public bool HasLessThan(string word, int minimumLength)
        {
            if (word.Length < minimumLength)
            {
                return true;
            }

            return false;
        }

        public bool ContainsLetter(string word, char[] excludedLetters)
        {
            if (word.ToCharArray().Any(c => excludedLetters.Contains(c)))
            {
                return true;
            }

            return false;
        }

        
       


    }
}
