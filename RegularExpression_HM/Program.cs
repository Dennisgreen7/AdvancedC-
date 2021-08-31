using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegularExpression_HM
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.
            string str1 = "Dennis";
            string str2 = "Roni";
            Console.WriteLine(str1.IfWordStratsWithD());// True
            Console.WriteLine(str2.IfWordStratsWithD());// False

            //2,3.
            string str3 = "D123456_DG";
            string str4 = "Funny";
            string str5 = "JackSparrow";
            string str6 = "Ron";
            Console.WriteLine(str3.IfWordStratsWithDOrForJ());// True
            Console.WriteLine(str4.IfWordStratsWithDOrForJ());// True
            Console.WriteLine(str5.IfWordStratsWithDOrForJ());// True
            Console.WriteLine(str6.IfWordStratsWithDOrForJ());// False

            //4.
            string str7 = "yyyA";
            string str8 = "זזזזB";
            Console.WriteLine(str7.ReplaceString()); //A
            Console.WriteLine(str8.ReplaceString()); ;//B

            //5.
            string str9 = "Dennis";
            string str10 = "dennis";
            Console.WriteLine(str9.StartsWithBigChar());//True
            Console.WriteLine(str10.StartsWithBigChar());//False

            //6.
            string str11 = "Dennisabc";
            string str12 = "ABCdennis";
            string str13 = "dennis";
            Console.WriteLine(str11.HaveABCOrabc());//True
            Console.WriteLine(str12.HaveABCOrabc());//True
            Console.WriteLine(str13.HaveABCOrabc());//False

            //7.
            string str14 = "dennis greenberg";
            string str15= "Cristiano Ronaldo";
            string str16 = "L m";
            Console.WriteLine(str14.FirstAndLastNamesValidation());//True
            Console.WriteLine(str15.FirstAndLastNamesValidation());//True
            Console.WriteLine(str16.FirstAndLastNamesValidation());//False

            //8.
            string str17 = "4.5";
            string str18 = "44.5";
            string str19 = "4";
            Console.WriteLine(str17.IsDecimalNumber());//True
            Console.WriteLine(str18.IsDecimalNumber());//True
            Console.WriteLine(str19.IsDecimalNumber());//False

            //9.
            string str20 = "44.544";
            Console.WriteLine(str20.IsDecimalNumberHasThreeNumsAfterPoint());//True
            Console.WriteLine(str18.IsDecimalNumberHasThreeNumsAfterPoint());//False
            Console.WriteLine(str19.IsDecimalNumberHasThreeNumsAfterPoint());//False

            //10.
            string str21 = "denis4167@gmail.com";
            string str22 = "dennis@yahoo.co.il";
            string str23 = "dennis443933@Gmailco.il";
            Console.WriteLine(str21.EmailValidation());//True
            Console.WriteLine(str22.EmailValidation());//True
            Console.WriteLine(str23.EmailValidation());//False
            
            //11.
            string str24 = "geeksforgeeks.co.il";
            string str25 = "geeksforgeeks.com";
            string str26 = "geeksforgeeks.org";
            Console.WriteLine(str24.DomainValidation());//True
            Console.WriteLine(str25.DomainValidation());//False
            Console.WriteLine(str26.DomainValidation());//False

            Console.ReadLine();
        }
    }
}
