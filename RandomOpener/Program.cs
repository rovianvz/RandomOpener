using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomOpener
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Texto: ");
            string entrada = Console.ReadLine();

            String[] allfiles = System.IO.Directory.GetFiles(Directory.GetCurrentDirectory(), String.Format("*{0}*.*", entrada), System.IO.SearchOption.AllDirectories);

            Random rnd = new Random();
            string file = allfiles[rnd.Next(1, allfiles.Length)];

            System.Diagnostics.Process.Start(file);
        }
    }
}
