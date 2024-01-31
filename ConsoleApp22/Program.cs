using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char leftBracket = '(';
            char rightBracket = ')';
            string line = ($"{leftBracket}{rightBracket}{rightBracket}{leftBracket}{leftBracket}{rightBracket}");
            int attachmentDepth = 0;
            int maxAttachmentDepth = 0;         

            Console.WriteLine(line);

            foreach (var symbol in line)
            {
                Console.WriteLine(symbol);

                if (symbol == leftBracket && attachmentDepth >= 0)
                {
                    attachmentDepth++;

                    if (attachmentDepth > maxAttachmentDepth)
                    {
                        maxAttachmentDepth = attachmentDepth;
                    }
                }
                else if (symbol == rightBracket)
                {
                    attachmentDepth--;
                }           
            }
            if (attachmentDepth == 0)
            {
                Console.WriteLine($"{line} - строка корректная и максимум глубины равняется - {maxAttachmentDepth}");
            }
            else
            {
                Console.WriteLine($"{line} - строка не корректная");
            }
            Console.ReadKey();
        }
    }
}
