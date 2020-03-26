using System;
using System.Linq;
using System.IO;



namespace gitDiff
{
    class Program
    {
        static void Main(string[] args)
        {

            //assigning paths to variables
            string Git1a_p = @"C:\Users\ryant\Documents\OOPaSS2\Assessment 2 Files\gitDiff\gitDiff\bin\Debug\netcoreapp3.1\GitRepositories_1a.txt";
            string Git1b_p = @"C:\Users\ryant\Documents\OOPaSS2\Assessment 2 Files\gitDiff\gitDiff\bin\Debug\netcoreapp3.1\GitRepositories_1b.txt";
            string Git2a_p = @"C:\Users\ryant\Documents\OOPaSS2\Assessment 2 Files\gitDiff\gitDiff\bin\Debug\netcoreapp3.1\GitRepositories_2a.txt";
            string Git2b_p = @"C:\Users\ryant\Documents\OOPaSS2\Assessment 2 Files\gitDiff\gitDiff\bin\Debug\netcoreapp3.1\GitRepositories_2b.txt";
            string Git3a_p = @"C:\Users\ryant\Documents\OOPaSS2\Assessment 2 Files\gitDiff\gitDiff\bin\Debug\netcoreapp3.1\GitRepositories_3a.txt";
            string Git3b_p = @"C:\Users\ryant\Documents\OOPaSS2\Assessment 2 Files\gitDiff\gitDiff\bin\Debug\netcoreapp3.1\GitRepositories_3b.txt";

            //Moving files to arrays 
            string[] Git1a = File.ReadAllLines(Git1a_p);
            string[] Git1b = File.ReadAllLines(Git1b_p);
            string[] Git2a = File.ReadAllLines(Git2a_p);
            string[] Git2b = File.ReadAllLines(Git2b_p);
            string[] Git3a = File.ReadAllLines(Git3a_p);
            string[] Git3b = File.ReadAllLines(Git3b_p);

            //assing bool
            bool check=true;
            // Checking git 1 a&b
            foreach (string Line in Git1a)
            {
                if (check == false) 
                {
                    break;
                }
                foreach (string Line1 in Git1b)
                {
                    if (Line == Line1)
                    {
                        check = true;
                        continue;
                    }
                    else
                    {
                        check = false;
                        break;
                    }
                }
            
            }

            
            if (check)
            {
                Console.WriteLine("Files Git1a and Git1b are the same");
            }
            else 
            {
                Console.WriteLine("Files Git1a and Git1b are different");
            }
            // Checking git 2 a&b
            foreach (string Line in Git2a)
            {
                if (check == false)
                {
                    break;
                }
                foreach (string Line1 in Git2b)
                {
                    if (Line == Line1)
                    {
                        check = true;
                        continue;
                    }
                    else
                    {
                        check = false;
                        break;
                    }
                }

            }
            if (check)
            {
                Console.WriteLine("Files Git2a and Git2b are the same");
            }
            else
            {
                Console.WriteLine("Files Git2a and Git2b are different");
            }
            // Checking git 3 a&b
            foreach (string Line in Git3a)
            {
                if (check == false)
                {
                    break;
                }
                foreach (string Line1 in Git3b)
                {
                    if (Line == Line1)
                    {
                        check = true;
                        continue;
                    }
                    else
                    {
                        check = false;
                        break;
                    }
                }

            }

            if (check)
            {
                Console.WriteLine("Files Git3a and Git3b are the same");
            }
            else
            {
                Console.WriteLine("Files Git3a and Git3b are different");
            }



        }
    }
}
