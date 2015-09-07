using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace r_dailyprogrammer_parser
{
    class Program
    {
        static void Main(string[] args)
        {
            string file_loc;
            while (true)
            {
                Program.ClearConsole();

                file_loc = fileLocation();
                if (confirm_file_loc(file_loc)) { break; }
            }
            string filePath = Path.GetFullPath(file_loc);
            List<string> items = Parser.Parse_InputTxt_File(filePath);

            if (!Directory.Exists("batch"))
            { Directory.CreateDirectory("batch"); }
            for(int i = 1; i <items.Count(); i++)
            {
                using (StreamWriter sW = new StreamWriter("batch\\" + i.ToString() + ".txt",true))
                {
                    sW.Write(items[i]);
                    sW.Close();
                }
            }
        }

        private static bool confirm_file_loc(string file_loc)
        {
            Program.ClearConsole();

            Console.WriteLine("\nThe file you wish to parse is located at " + file_loc + "?");
            Console.WriteLine(@"
1: Yes
2: No");

            ConsoleKeyInfo KeyInput;
            KeyInput = Console.ReadKey();

            if(KeyInput.Key == ConsoleKey.D1)
            { return true; }
            else { return false; }
        }

        private static string fileLocation()
        {
            Console.WriteLine("Enter the location of the file you wish to parse?");
            string file_loc = Console.ReadLine();
            return file_loc;
        }

        private static void ClearConsole()
        {
            Console.Clear();
            Console.SetCursorPosition(0, 0);
        }
    }
}
