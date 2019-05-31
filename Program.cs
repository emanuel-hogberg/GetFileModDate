using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetFileModDate
{
    class Program
    {
        /// <summary>
        /// Usage: GetFileModDate.exe {filename|filepath}
        /// Outputs: Last modified date (DateTime)
        /// In SAP Data Services: 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string filepath = string.Empty;
            try
            {
                if (args.Count() == 0)
                    throw new ArgumentException("Please provide a valid filename or filepath.");

                filepath = args[0];

                if (!File.Exists(filepath))
                {
                    try
                    {
                        string s = Directory.EnumerateFiles(Path.GetFullPath(filepath))
                            .Aggregate((a, b) => string.Concat(a, b));
                        throw new FileNotFoundException($" File '{filepath}' not found, path contents: {s}");
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }

                    throw new ArgumentException($"File {filepath} does not exist!");
                }

                Console.Write(File.GetLastWriteTime(filepath));
            }
            catch (Exception ex)
            {
                Console.Write($"{Environment.UserName} - {ex.Message}");
            }
        }
    }
}
