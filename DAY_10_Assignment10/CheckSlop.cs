using System;
using System.Collections.Generic;
using System.Text;

namespace DAY_10_Assignment10
{
    class CheckSlop
    {

        public void checkSlop()
        {
            int x1, x2, x3, y1, y2, y3;



            Console.WriteLine("Enter value of x1 = ");
            x1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter value of x2 = ");
            x2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter value of y1 = ");
            y1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter value of y2 = ");
            y2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter value of x3 = ");
            x3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter value of y3 = ");
            y3 = Convert.ToInt32(Console.ReadLine());


            int AB = (y2 - y1) / (x2 - x1);
            int BC = (y3 - y2) / (x3 - x2);
            int AC = (y3 - y1) / (x3 - x1);

            if (AB == BC && AB == AC && BC == AC)
            {
                Console.WriteLine("Three points are collinear");
            }
            else
            {
                Console.WriteLine("Three points are not collinear");

            }


            Console.ReadLine();
        }
    }
}
