using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace r_dailyprogrammer_browser
{
    class Parser
    {
        /// <summary>
        /// Ideally parses the original files created by TheEd1tor from the /r/dailyprogrammer challenges.
        /// </summary>
        /// <param name="input_dir">Use the location of the files included with the commit, else pass your own updated version.</param>
        /// <returns></returns>
        static List<string> Parse_InputTxt_File(string input_dir)
        {
            if (File.Exists(input_dir))
            {
                using (StreamReader sw = new StreamReader(input_dir))
                {
                    string input_text = sw.ReadToEnd();
                    List<string> raw_strings = input_text.Split(new[] { "Title" }, StringSplitOptions.RemoveEmptyEntries).ToList();

                    List<string> pure_strings = new List<string>();
                    foreach (string raw_string in raw_strings)
                    {
                        pure_strings.Add("Title" + raw_string);
                    }
                    return pure_strings;
                    
                }
            }
            else
            {
                return new List<string>(){ "File not Found" };
            }
        }
    }
}
