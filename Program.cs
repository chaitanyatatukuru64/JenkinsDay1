using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Jenkins
{
    class Program
    {
        void GetNumbers()
        {
            int iNum1 = 0, iNum2 = 0;
            Console.WriteLine("Please enter the numbers");
            iNum1 = Convert.ToInt32(Console.ReadLine());
            iNum2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("iNum1 {0}: iNum2 {1} ", iNum1, iNum2);

        }
        static void Main(string[] args)
        {
            new Program().GetNumbers();
            Console.ReadKey();

        }
    }
}
