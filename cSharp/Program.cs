using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management.Automation;

namespace cSharp
{
    class HostPS3
    {
        private const string Value = "C://Users//soory//OneDrive//Desktop//To//23.txt";

        static void Main(string[] args)
        {
            Console.WriteLine("enter path1");
            string s1 = Console.ReadLine();
            Console.WriteLine("enter path2");
            string s2 = Console.ReadLine();

            PowerShell.Create().AddCommand("Copy-Item").AddParameter(s1)
                               .AddParameter("-Destination", s2)
                               .Invoke();
            
            Console.WriteLine("Hit any key to exit.");
            Console.ReadKey();
        } // End Main.
    } // End HostPS3.
}
