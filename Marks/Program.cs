using System;

namespace Marks
{
    class Program
    {
        static void Main(string[] args)
        {
            int mark;
            Console.WriteLine("Enter your mark"!);
            mark = Convert.ToInt32(Console.ReadLine());
            if (mark < 60)
            {
                Console.WriteLine(" Your grade if F");

            }
            else if ((mark >= 60) && (mark <= 70))
            {
                Console.WriteLine("Your grade is C");
            }
            else if ((mark >= 71) && (mark <= 80))
            {
                Console.WriteLine("Your grade is B");
            }
            else if ((mark >= 81) && (mark <= 90))
            {
                Console.WriteLine("Your grade is A");
            }
            else
            {
                Console.WriteLine("Your grade is A+");
            }
        }
    }
}
                
             
