using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace SemverTemplate
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 3) {
                throw new Exception(@"Usage: st.exe 1.2.3 .\template.txt .\output.txt");
            }

            var version = args[0];
            var inputPath = args[1];
            var outputPath = args[2];

            var semVer = new SemVer(version);

            using (StreamReader reader = new StreamReader(inputPath))
            {
                string lines = reader.ReadToEnd();
                var output = semVer.replaceInTemplate(lines);

                Console.WriteLine("Generated output:");
                Console.WriteLine(output);

                if (File.Exists(outputPath))
                {
                    Console.WriteLine();
                    Console.WriteLine("Output file exists and will be overwritten!");
                }

                using (StreamWriter writer = new StreamWriter(outputPath))
                {
                    writer.Write(output);
                }
            } 
        }
    }
}
