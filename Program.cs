using System;
using System.IO;
using System.Runtime;
using System.Xml;
using System.Xml.XPath;
using System.Xml.Xsl;

namespace xml2flat
{
    class Program
    {
        public String ReadFile(string filename)
        {
            String filecontent = "";
            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader(filename))
                {
                    // Read the stream to a string, and write the string to the console.
                    filecontent = sr.ReadToEnd();
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("The file '" + filename + "'could not be read:");
                Console.WriteLine(e.Message);
                Environment.Exit(1);
            }
            return filecontent;
        }

        static void Main(string[] args)
        {
            Program t = new Program();


            Console.WriteLine("Starting...");
            var myXslTrans = new XslCompiledTransform();
            Console.WriteLine("Loading and compiling xslt...");
            myXslTrans.Load("pacs.002.001.03.xslt");
            Console.WriteLine("Transforming xml...");
            myXslTrans.Transform("pacs.002.001.03.xml", "resulta.html");

            Console.WriteLine(t.ReadFile("resulta.html"));
            Console.WriteLine("Done!!!");

            Console.ReadLine();
            Environment.Exit(0);
        }
    }
}
