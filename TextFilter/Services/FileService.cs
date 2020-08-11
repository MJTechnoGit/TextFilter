using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Reflection;
using Microsoft.Extensions.Configuration;
using TextFilter.Interfaces;
using System.Linq;

namespace TextFilter.Services
{
    public class FileService : IFileService
    {

        string[] words;

        public string ReadFile(string FileName)
        {
            
            string path = Path.Combine(Directory.GetCurrentDirectory(), FileName);

            if (File.Exists(path))
            {

                using (StreamReader sReader = new StreamReader(path))
                {
                    FilterService filterService = new FilterService();
                    StringBuilder filteredSB = new StringBuilder();

                    int minimumValue = 3;
                    char[] excludedLetters = { 'T', 't' };


                    words = sReader.ReadToEnd().Split(new[] { " ", "\r\n", "\n", "\r" }, StringSplitOptions.None);
                    sReader.Close();

                    var filteredWords = words.Where(x => !filterService.HasVowelsInCentre(x) && !filterService.HasLessThan(x, minimumValue) && !filterService.ContainsLetter(x, excludedLetters));

                    foreach (var word in filteredWords)
                    {
                        filteredSB.AppendFormat("{0} ", word);

                        //Remove any commas or apostrophes from the string buffer.
                        if (word.EndsWith("'") || word.EndsWith(","))
                        {
                            filteredSB.Length--; 
                        }
                    }

                    return filteredSB.ToString();
                }
            }
            else
            {
                throw new IOException("File not found");                
            }

            
        }


    }
}
