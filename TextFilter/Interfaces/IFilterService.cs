using System;
using System.Collections.Generic;
using System.Text;

namespace TextFilter.Interfaces
{
    public interface IFilterService
    {
        bool HasVowelsInCentre(string word);
        bool HasLessThan(string word, int minimumLength);
        bool ContainsLetter(string word, char[] excludedLetters);
    }
}
