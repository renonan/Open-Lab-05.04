using System;
using System.Linq;
using System.Text;

namespace Open_Lab_05._04
{
    public class StringTools
    {
        public string RemoveSpecialCharacters(string original)
        {
            string result ="";
            foreach (char c in original)
            {
                if ((c >= '0' && c <= '9') || (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || c == '_' || c == '-' || c == ' ')
                {
                   result+= c;
                }
            }
            return result;
        }
    }
}
