using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Investec_Application
{
    class Program
    {
        static void Main(string[] args)
        {
            StringCalculate calculate = new StringCalculate();
            ModelClass model = new ModelClass();
            Console.WriteLine("Enter which operations to do on the supplied text, ‘1’ for a duplicate character check,");
            Console.WriteLine("‘2’ to count the number of vowels, ‘3’ to check if there are more vowels or non vowels,");
            Console.WriteLine("or any combination of ‘1’, ‘2’ and ‘3’ to perform multiple checks");
            Console.WriteLine("Enter text to be analysed");
            model.Text = (Console.ReadLine());
            
            Console.WriteLine("Type any number:  "); 
            string operationValue = Console.ReadLine();
            var operationValueList = operationValue.ToCharArray().Distinct().ToArray();
            foreach (char item in operationValueList)
            {
                if (item == '1')
                {
                   string output = calculate.DublicateCheck(model);
                    Console.WriteLine(output);
                }
                else if (item == '2')
                {
                    string output = calculate.VoulCount(model);
                    Console.WriteLine(output);

                }
                else if (item == '3')
                {
                    string output  = calculate.NumberOfVowels_NonVowels(model);
                    Console.WriteLine(output);
                }
                
            }
            Console.ReadLine();

        }
  
    }
}
