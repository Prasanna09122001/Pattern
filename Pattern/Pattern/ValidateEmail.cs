using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Pattern
{
    internal class ValidateEmail
    {
        string uc1_Regex = "^[a-z]{0,}$";
        string uc2_Regex = "[@]{1}[a-z]{0,}$";
        string uc3_Regex = "^[.]{1}[a-z]{2}$";
        string uc4_Regex = "^[a-z]+[._+-]{0,1}[a-z]{0,}$";
        string actualRegex = "^[a-z]+[._+-]{0,1}[a-z0-9]+[@]{1}[a-z0-9]+[.]{1}[a-z]{2,3}([.]{1}[a-z]{2,3}){0,1}$";
        public void UC1_Validate(string input)
        {
            bool result = Regex.IsMatch(input, uc1_Regex);
            if (result)
                Console.WriteLine("Validation Successful");
            else
                Console.WriteLine("Valiadtion is Not Successful");
        }
        public void UC2_Validate(string input)
        {
            bool result = Regex.IsMatch(input, uc2_Regex);
            if (result)
                Console.WriteLine("Validation Successful");
            else
                Console.WriteLine("Valiadtion is Not Successful");
        }
        public void UC3_Validate(string input)
        {
            bool result = Regex.IsMatch(input, uc3_Regex);
            if (result)
                Console.WriteLine("Validation Successful");
            else
                Console.WriteLine("Valiadtion is Not Successful");
        }
        public void UC4_Validate(string input)
        {
            bool result = Regex.IsMatch(input, uc4_Regex);
            if (result)
                Console.WriteLine("Validation Successful");
            else
                Console.WriteLine("Valiadtion is Not Successful");
        }
        public void ActualValidate(string input)
        {
            bool result = Regex.IsMatch(input, actualRegex);
            if (result)
                Console.WriteLine("The Given Mail id "+input+" is Correct");
            else
                Console.WriteLine("The Given Mail id "+input+" is Not Correct");
        }
    }
}
