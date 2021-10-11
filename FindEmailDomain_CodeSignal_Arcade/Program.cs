using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindEmailDomain_CodeSignal_Arcade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "sajdkjaks@google.com";
            string v = findEmailDomain(s);
            Console.WriteLine(v);
        }

        static string findEmailDomain(string address)
        {
            string[] s = address.Split('@');
            return s[s.Length - 1];
        }
    }
}
