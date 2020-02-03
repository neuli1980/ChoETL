using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UnitTestHelper
{
    public static class StringHelper
    {
        public static void EnsureCRLFLineEnding(ref string value)
        {
            value = Regex.Replace(value, "([^\r])\n", "$1\r\n");
        }

        public static string EnsureCRLFLineEnding(string value)
        {
            string temp = value;
            EnsureCRLFLineEnding(ref temp);
            return temp;
        }
    }
}
