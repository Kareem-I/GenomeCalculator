using System;
using System.IO;
using GenomeCalculator.Interface;
using System.Collections.Generic;
using System.Text;

namespace GenomeCalculator.Implementation
{
    public class Length : ICalculate
    {
        public double calc(string filepath)
        {
            using (StreamReader fastaReader = new StreamReader(filepath)) // opening the faster file 
            {
                double bl = 0;
                fastaReader.ReadLine(); // skipping the first line
                string line;
                while ((line = fastaReader.ReadLine()?.ToLower()) != null) // keeps on reading the next line until null encounters. null inidcates end of file
                {

                    //double c = 0;

                    for (double i = 0; i < line.Length; i++)


                    {
                        bl++;
                    }

                }

                return bl;
            }
        }
    }
}