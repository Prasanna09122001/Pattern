using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Pattern
{
    internal class ValidatePincode
    {
        string  uc4_Regex = "^([ ]{0,1}[0-9]){5,7}$";
        string uc1_Regex = "^[0-9]{6}$";
        string uc2_Regex = "^[0-9]{6}$";
        string uc3_Regex = "^[0-9]{6}$";

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
    }
}
