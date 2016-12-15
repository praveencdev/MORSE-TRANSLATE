/*          Author: Danda Praveen
            Date:12/14/2016
            Modifications:0
            Last Modified by: Danda Praveen
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1  
{
    public class Program
    {
        private static Dictionary<char, string> _morseAlphabetDictionary;

        static void Main()
        {
            InitializeDictionary();
            ReadFileAndTranslate();

            Console.WriteLine("[Press ANY KEY to exit]");
            Console.ReadLine();
        }

        private static void InitializeDictionary()
        {
            _morseAlphabetDictionary = new Dictionary<char, string>()
                                   {
                                       {'a', ".-"},
                                       {'b', "-..."},
                                       {'c', "-.-."},
                                       {'d', "-.."},
                                       {'e', "."},
                                       {'f', "..-."},
                                       {'g', "--."},
                                       {'h', "...."},
                                       {'i', ".."},
                                       {'j', ".---"},
                                       {'k', "-.-"},
                                       {'l', ".-.."},
                                       {'m', "--"},
                                       {'n', "-."},
                                       {'o', "---"},
                                       {'p', ".--."},
                                       {'q', "--.-"},
                                       {'r', ".-."},
                                       {'s', "..."},
                                       {'t', "-"},
                                       {'u', "..-"},
                                       {'v', "...-"},
                                       {'w', ".--"},
                                       {'x', "-..-"},
                                       {'y', "-.--"},
                                       {'z', "--.."},
                                       {'0', "-----"},
                                       {'1', ".----"},
                                       {'2', "..---"},
                                       {'3', "...--"},
                                       {'4', "....-"},
                                       {'5', "....."},
                                       {'6', "-...."},
                                       {'7', "--..."},
                                       {'8', "---.."},
                                       {'9', "----."}
                                   };
        }

        private static void ReadFileAndTranslate()
        {
            string line;
            string Path;
            Console.WriteLine("Enter the path of the file where morse code is located");
            Path = Console.ReadLine();
            System.IO.StreamReader file = new System.IO.StreamReader(Path);
            while ((line = file.ReadLine()) != null)
            {
                Console.WriteLine(Translate(line));
            }
            file.Close();
        }

        private static string Translate(string input)
        {
            StringBuilder stringBuilder = new StringBuilder();
            string output = "";

            string[] letters = input.Split('|');
            for (int i = 0; i < letters.Length; i++)
            {
                if (letters[i].Length > 0)
                {
                    if (_morseAlphabetDictionary.ContainsValue(letters[i]))
                    {
                        output = output + _morseAlphabetDictionary.FirstOrDefault(x => x.Value == letters[i]).Key;
                    }
                }
            }
            return output;
        }
    }
}

