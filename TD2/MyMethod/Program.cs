using System;
using System.Web;

namespace MyMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 1)
                Console.WriteLine("<HTML><BODY> Hello " + HttpUtility.ParseQueryString(args[0]).Get("param1") + " " + HttpUtility.ParseQueryString(args[0]).Get("param2") + "</BODY></HTML>");
            else
                Console.WriteLine("ExeTest <string parameter>");
        }
    }
}
