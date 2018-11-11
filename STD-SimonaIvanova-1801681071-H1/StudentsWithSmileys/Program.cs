using System;
using System.Text;

namespace StudentsWithSmileys
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string[] names = System.IO.File.ReadAllLines(@"C:\Users\Potrebitel\Desktop\STD2B-SimonaIvanova-1801681071\PU-IntroCSharp-2018-1801681071\STD-SimonaIvanova-1801681071-H1\std-students-2018.txt");
            int nameValue = 0;
            char smileyFace = '\u263a';
            foreach (string name in names)
            {
                foreach (char ch in name)
                {
                    nameValue = nameValue + ch;
                }
                if (nameValue > 1500) Console.WriteLine("{0} student's sum of names is {1} {2}", name, nameValue, smileyFace);
                else Console.WriteLine("{0} student's sum of names is {1}", name, nameValue);
                nameValue = 0;

            }


        }
    }
}
