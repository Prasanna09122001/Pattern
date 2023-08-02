using Pattern;
using System;
namespace pattern
{
    class program
    { 
        static void Main()
        {
             ValidatePincode validatepincode = new ValidatePincode();
             validatepincode.UC1_Validate("400088");
             validatepincode.UC2_Validate("A400088");
             validatepincode.UC3_Validate("400088B");
             validatepincode.UC4_Validate("400 088");


            /*
           ValidateEmail validateEmail = new ValidateEmail();
           validateEmail.UC1_Validate("abc");
           validateEmail.UC2_Validate("@bridgelabz");
           validateEmail.UC3_Validate(".co");
           validateEmail.UC4_Validate("abcd.xyz");
           validateEmail.ActualValidate("abc@bridgelabz.co.in");
             "^[A-Z]{1,}[a-z]{5,}[!@#%&*~$]{1}[0-9]{1,}$";
           */
        }
    }
}

