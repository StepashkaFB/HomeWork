using System;
using System.Text.RegularExpressions;

namespace TaskRegular
{
    class RegularExp
    {
        public static bool EmailAdress(string InputtedEmail)
        {
            const string Expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(InputtedEmail, Expresion))
            {
                if (Regex.Replace(InputtedEmail, Expresion, string.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public static bool Url(string InputtedURL)
        {
            const string Expresion = @"^http(s)?://([\w-]+.)+[\w-]+(/[\w- ./?%&=])?$";
            if (Regex.IsMatch(InputtedURL, Expresion))
            {
                if (Regex.Replace(InputtedURL, Expresion, string.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        //Another Way
        public static bool URLValid(string InputtedURL)
        {
            Uri uriResult;
            bool result = Uri.TryCreate(InputtedURL, UriKind.Absolute, out uriResult)
                && uriResult.Scheme == Uri.UriSchemeHttp;
            return result;
        }
        public static bool FilePathValid(string InputtedPath)
        {
            const string Expresion = @"((?:[a-zA-Z]\:){0,1}(?:[\\/][\w.]+){1,})";
            if (Regex.IsMatch(InputtedPath, Expresion))
            {
                if (Regex.Replace(InputtedPath, Expresion, string.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
