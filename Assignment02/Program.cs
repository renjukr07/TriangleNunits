using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int a, b, c;
            int option;
            
            do
            {
                Console.Write("\nMenu\n1.Enter Triangle dimensions\n2.Exit\n");
                option = Convert.ToInt32(Console.ReadLine());
                if (option == 1)
                {
                    Console.WriteLine("Please enter 3 input integers\n");
                    a = Convert.ToInt32(Console.ReadLine());
                    b = Convert.ToInt32(Console.ReadLine());
                    c = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(TriangleSolver.Analyze(a, b, c));
                }
                else if(option == 2)
                {
                    System.Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Please choose an option from the menu\n");
                }


            } while (option != 2);

            //Console.WriteLine(output);
            Console.ReadLine();


        }
    }
}
