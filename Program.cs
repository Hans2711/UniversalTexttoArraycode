using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Microsoft.CSharp;


namespace AutoBatchConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length == 0)
            {
                Console.WriteLine("Give the File as arguement");
                Console.Read();
                return;
            }

            string Filepath = args[0];
            string[] Read = File.ReadAllLines(Filepath);
            for(int i = 0; i < Read.Length; i++)
            {
                
                Read[i] = Read[i].Replace(@"\", @"\\");
                Read[i] = Read[i].Replace("\"", "\\\"");
            }
            for (int i = 0; i < Read.Length; i++)
            {
                if (Read[i] != "")
                {
                    Read[i] = "\"" + Read[i] + "\",";
                }
            }



            File.WriteAllLines(Environment.CurrentDirectory + "\\Output.txt", Read);
            Console.WriteLine("Safed to: " + Environment.CurrentDirectory + "\\Output.txt");
            Console.Read();



        }
    }
}
