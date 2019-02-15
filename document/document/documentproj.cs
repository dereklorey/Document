using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace document
{
    class Program
    {
        static void Main(string[] args)
        {
            string docname;
            Console.WriteLine("Document" + Environment.NewLine);

            Console.WriteLine("Enter the name of the document: ");
            docname = Console.ReadLine();

            string content;
            Console.WriteLine("Enter the content inside the document: ");
            content = Console.ReadLine();
            docname += ".txt.";

           
            
            using (StreamWriter sw = new StreamWriter(docname))
            {
                    sw.WriteLine(content);
            }
                
            
            int len;
            len = content.Length;
            if (len == null)
            {
                Console.WriteLine("Operation could not be completed.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("'{0}' was successfully saved. The document contains {1} characters.", docname, len);
                Console.ReadLine();
            }
        }
    }
}

