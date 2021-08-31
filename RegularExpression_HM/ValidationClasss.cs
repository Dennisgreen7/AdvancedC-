using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegularExpression_HM
{
    public static class ValidationClasss
    {
        //1.
        public static bool IfWordStratsWithD(this string str)
        {
            string pattern = @"^D";
            return Regex.Match(str, pattern).Success;
        }

        public static bool IfWordStratsWithDOrForJ(this string str)
        {
            string pattern = @"^[DFJ]\d{6}\w[A-Z]{2}";
            return Regex.Match(str, pattern).Success;
        }
        public static string ReplaceString(this string str)
        {
            string pattern = @"(y{3}|ז{4})";
            string CleanedString = Regex.Replace(str, pattern, "");
            return CleanedString;
        }
        public static bool StartsWithBigChar(this string str)
        {
            string pattern = @"^[A-Z]";
            return Regex.Match(str, pattern).Success;
        }
        public static bool HaveABCOrabc(this string str)
        {
            string pattern = "(abc|ABC)";
            return Regex.Match(str, pattern).Success;
        }
        public static bool FirstAndLastNamesValidation(this string str)
        {
            string pattern = "[A-Za-z]{2,18}[\\s][a-zA-Z]{2,18}";
            return Regex.Match(str, pattern).Success;
        }
        public static bool IsDecimalNumber(this string str)
        {
            string pattern = @"^[0-9]{1,}\.{1}[0-9]{1,}$";
            return Regex.Match(str, pattern).Success;
        }
        public static bool IsDecimalNumberHasThreeNumsAfterPoint(this string str)
        {
            string pattern = @"^[0-9]{1,}\.{1}[0-9]{3}$";
            return Regex.Match(str, pattern).Success;
        }
        public static bool EmailValidation(this string str)
        {
            string pattern = @"^[a-zA-Z0-9]{2,15}\@(gmail|GMAIL|yahoo|YAHOO)\.\D{3,}$";
            return Regex.Match(str, pattern).Success;
        }
        public static bool DomainValidation(this string str)
        {
            string pattern = "^(?!-)[A-Za-z0-9-]+([\\-\\.]{1}[a-z0-9]+)*\\.co.il$";
            return Regex.Match(str, pattern).Success;
        }


    }
}
