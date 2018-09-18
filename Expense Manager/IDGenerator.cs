using System;
using System.Collections.Generic;
using System.Text;

namespace Expense_Manager
{
    class IDGenerator
{
        public static string Id()
        {
            string UpperCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string LowerCase = "abcdefghijklmnopqrstuvwxyz";
            string SpecialChars = "~@#$%^&*";
                       
            Random rand = new Random();
                int specialcharrandom = rand.Next(SpecialChars.Length) ;
                int upperrandom = rand.Next(UpperCase.Length) ;
                int lowerrandom = rand.Next(LowerCase.Length) ;
                int digits = rand.Next(9) ;
                char specialrand = SpecialChars[specialcharrandom];
                char upperrand = UpperCase[upperrandom];
                char lowerrand = LowerCase[lowerrandom];
            int specialcharrandom2 = rand.Next(SpecialChars.Length) ;
            int upperrandom2 = rand.Next(UpperCase.Length) ;
            int lowerrandom2 = rand.Next(LowerCase.Length) ;
            int digits2 = rand.Next(9) ;
            char specialrand2 = SpecialChars[specialcharrandom2];
            char upperrand2 = UpperCase[upperrandom2];
            char lowerrand2 = LowerCase[lowerrandom2];
            StringBuilder build = new StringBuilder(upperrand);
            build.Append("M"+upperrand);
            build.Append(lowerrand);
            build.Append(specialrand);
            build.Append(digits);
            build.Append(specialrand2);
            build.Append(upperrand2);
            build.Append(lowerrand2);
            build.Append(digits2);
           string m= build.ToString();
            
            




            return m;
            
        }
}
}
