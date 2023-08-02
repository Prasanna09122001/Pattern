using Pattern;
using System;
namespace pattern
{
    class program
    { 
        static void Main()
        {
            /* ValidatePincode validatepincode = new ValidatePincode();
             validatepincode.UC1_Validate("400088");
             validatepincode.UC2_Validate("A400088");
             validatepincode.UC3_Validate("400088B");
             validatepincode.UC4_Validate("400 088");
                              "^[A-Z]{1,}[a-z]{5,}[!@#%&*~$]{1}[0-9]{1,}$";

             */
            ValidateEmail validateEmail = new ValidateEmail();
            //validateEmail.UC1_Validate("abc");
            //validateEmail.UC2_Validate("@bridgelabz");
            //validateEmail.UC3_Validate(".co");
            //validateEmail.UC4_Validate("abcd.xyz");
            Console.WriteLine("Enter the Length of the Array");
            int length = Convert.ToInt32(Console.ReadLine());
            string[] array = new string[length];
            Console.WriteLine("Enter the Email id");
            for (int i = 0; i < length; i++)
            {
                array[i] = Console.ReadLine();
                validateEmail.ActualValidate(array[i]);
            }
        }
    }
}

