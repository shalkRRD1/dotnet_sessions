using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment_day32_2
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream f = new FileStream("c:\\sh_project\\dotnet_sessions\\day32\\Assignment_day32_2", FileMode.OpenOrCreate);
            StreamWriter s = new StreamWriter(f);

            Console.WriteLine("Please enter username and address file");
            s.WriteLine(Console.ReadLine());

            s.Close();
            f.Close();

            Console.ReadLine();
        }
    }
}