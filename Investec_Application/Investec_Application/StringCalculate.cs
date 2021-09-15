using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investec_Application
{
    internal class StringCalculate : StringManipulation
    {
        public  string DublicateCheck(ModelClass modelclass)
        {
            try
            {
                string sentence = modelclass.Text;
                string resutls = "No duplicates values were found";
                sentence = sentence.Replace(" ", String.Empty);
                int count = 0;
                List<char> listString = sentence.ToList();

                var duplicateKeys = listString.GroupBy(x => x)
                            .Where(group => group.Count() > 1)
                            .Select(group => group.Key);
                foreach (var item in duplicateKeys)
                {
                    resutls = count == 0 ? string.Concat("Found the following duplicates :", item) : string.Concat(resutls, item);
                    count++;
                }
                return resutls;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public  string NumberOfVowels_NonVowels(ModelClass modelclass)
        {
            try
            {
                string sentence = modelclass.Text;
                string resutls = "The Text has an equal amount of vowels an non-vowels";
                int nonVowel = 0;
                int vowel = 0;
                sentence = sentence.Replace(" ", String.Empty);
                var removeduplicatevowls = sentence.ToLower().Trim().ToCharArray().Distinct().ToArray();
                foreach (var item in removeduplicatevowls)
                {
                    if (item == 'a' || item == 'e' || item == 'i' || item == 'o' || item == 'u')
                    {
                        vowel++;
                    }
                    else
                    {
                        nonVowel++;
                    }
                }
                if (vowel > nonVowel)
                {
                    resutls = "The Text has more vowels than non-vowels";
                }
                else if (vowel < nonVowel)
                {
                    resutls = "The Text has more non-vowels than vowels";
                }
                return resutls;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public  string VoulCount(ModelClass modelclass)
        {
            try
            {
                string sentence = modelclass.Text;
                string resutls = "No vowels were found";
                int total = 0;

                var removeduplicatevowls = sentence.ToCharArray().Distinct().ToArray();
                foreach (var item in removeduplicatevowls)
                {
                    if (item == 'a' || item == 'e' || item == 'i' || item == 'o' || item == 'u')
                    {
                        total++;
                        resutls = "the number of vowels is " + total + "";
                    }
                }
                return resutls;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
