using System;

namespace HW13Streams
{
    public class HW13Streams
    {
        static void Main(string[] args)
        {
            string inputName = @"../../../input.txt";
            string outputName = @"../../../output.txt";

            if (!File.Exists(inputName))
            {
                Console.WriteLine($"The file {inputName} does not exist");
                File.Create(inputName);
            }
            
            List<string> myList = new List<string>();

            using (StreamReader sr = new StreamReader(inputName))
            {

                Console.WriteLine("From input file:");
                
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                    myList.Add(line);
                }
            }

            if (!File.Exists(outputName))
                {
                    Console.WriteLine($"The file {outputName} does not exist");
                    File.Create(outputName);
                }

                Console.WriteLine("Writing to output file");

                using (StreamWriter sw = new StreamWriter(outputName))
                {
                    string newLine = "";
                    foreach (var line in myList)
                    {
                        if (line.Contains("Jack Swelstad"))
                        {
                            newLine = line.Replace("Jack Swelstad", "Patrick Bateman");
                        }

                        if (line.Contains("20"))
                        {
                            newLine = line.Replace("20", "100");
                        }

                        if (line.Contains("Computer Science"))
                        {
                            newLine = line.Replace("Computer Science", "Theater");
                        }

                        sw.WriteLine(newLine);
                    }
                }

                using (StreamReader sr = new StreamReader(outputName))
                    {
                        Console.WriteLine("From output file after modifying values");
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();
                            Console.WriteLine(line);
                        }
                    }
        }
    }
}

