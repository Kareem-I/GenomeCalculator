using System;
using System.IO;
using GenomeCalculator.Interface;
using System.Collections.Generic;
using System.Text;

namespace GenomeCalculator.Implementation
{
    public  class Ratio : ICalculate
    {
        public double calc(string filepath)
        {
            double g = 0, c = 0, a = 0, t = 0;
            double gc = 0;

            using (StreamReader fastaReader = new StreamReader(filepath)) // opening the faster file 
            {
                fastaReader.ReadLine(); // skipping the first line
                string line;
                while ((line = fastaReader.ReadLine()?.ToLower()) != null) // keeps on reading the next line until null encounters. null inidcates end of file
                {                                                           //converting to lower case to ensure general comparision
                    foreach (char character in line)
                    {
                        if (character == 'g')
                        {
                            g++;
                        }
                        else if (character == 'a')
                        {
                            a++;
                        }
                        else if (character == 'c')
                        {
                            c++;
                        }
                        else if (character == 't')
                        {
                            t++;
                        }
                    }
                }

                gc = ((double)(g + c)) / ((double)(a + t + c + g)); //type casting the results


            }
            return gc;
        }
    }
}