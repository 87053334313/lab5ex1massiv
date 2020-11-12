using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace lab5masiv
{
    class FileDetails
    {
        static void Summaraize(char[] contens)
        {
            int vowels = 0, consonants = 0, lines = 1;
            foreach (char current in contens)
            {
                if (Char.IsLetter(current))
                {
                    if ("AEIOUaeiou".IndexOf(current) != -1)
                    {
                        vowels++;
                    }
                    else
                    {
                        consonants++;
                    }
                }
                else if (current == '\n')
                {

                    lines++;

                }

            }

                Console.WriteLine("Total no of characters: {0}", contens.Length);

                Console.WriteLine("Total no of vowels : {0}", vowels);

                Console.WriteLine("Total no of consonants: {0}", consonants);

                Console.WriteLine("Total no of lines : {0}", lines);

        }
    
       
        static void Main(string[] args)
        {
            string fileName = args[0];
            Console.WriteLine(args.Length);

            foreach (string arg in args)
            {
                Console.WriteLine(arg);
            }
            

            FileStream stream = new FileStream(fileName, FileMode.Open);

            StreamReader reader = new StreamReader(stream);

            int size = (int)stream.Length;

            char[] contents = new char[size];
           

            for (int i = 0; i < size; i++)
            {
                    
                contents[i] = (char)reader.Read();

            }

            foreach (char ch in contents)
            {

                Console.Write(ch);

            }
            Summaraize(contents);
            Console.ReadKey();
           
        }
    }
}
