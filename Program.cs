using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace work
{
    class Program
    {
        static void Main(string[] args)
        {
           
            myarr();

        }

        public static double add(double a, double b)
        {
            double c = a + b;
            Console.WriteLine("The total is  {0}", c);
            Console.ReadLine();
            return c;

        }
        public static void myarr()
        {

           
               int total = 0;
          
               for (int i = 0; i <= 4; i++)
               {
                   int[] no = new int[5]; //array of six no 
                   Console.WriteLine("enter your score");
                   no[i] = Convert.ToInt32(Console.ReadLine());//store the input into an array
                   total= total+ no[i];//add toatal of the score



               }

               Console.WriteLine("The total is {0}",total);
               if (total >= 70)// checks is greater than 70
               {
                   Console.WriteLine("you passed");
                   Console.ReadLine();

               }
               else {
                   Console.WriteLine("you failed");// less than 70
                   Console.ReadLine();
           
               } 





            Console.ReadLine();

        }

    }
}
