using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    class StringCalculator
    {
        public static string AddTwoStrings(string str1, string str2)
        {
            return (double.Parse(str1.Text) + double.Parse(str2.Text)).ToString();
        }
    }
}
