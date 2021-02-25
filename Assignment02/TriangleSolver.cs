using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    public static class TriangleSolver
    {
        public static String Analyze(int a, int b, int c)
        {
            String output;

            if (a+b>c && b+c>a && a+c> b)
            {
                if (a == b && b == c)
                {
                    output = "Triangle is Equilateral";
                }
                else if((a == b || b == c || c == a)) {
                    output = "Triangle is Isoceles";
                }
                else
                {
                    output = "Triangle is Scalene";
                }

            }
            else
            {
                output = "Input values do not form a triangle";
                //Console.WriteLine("Input values do not form a triangle\n");


            }
            return output;


        }

    }
}
