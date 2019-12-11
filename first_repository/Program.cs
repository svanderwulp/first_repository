using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_repository
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach(string username in GetUsernames("student_github_names.txt"))
            {
                Console.WriteLine("Welcome {0}", username);
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }

        private static List<string> GetUsernames(string filename)
        {
            List<string> results = new List<string>();
            using (StreamReader sr = new StreamReader(filename))
            {
                string line;
                while((line = sr.ReadLine()) != null)
                {
                    if (!line.Trim().StartsWith("//"))
                        results.Add(line);
                }
            }
            return results;
        }
    }
}
