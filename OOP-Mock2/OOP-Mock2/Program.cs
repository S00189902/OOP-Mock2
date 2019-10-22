using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Mock2
{
    class Program
    {
       public const double TCost = 0.45;
       public  const double FCost = 3.25;

        public static double FitCostTotal = 0;
        public static double FitTotal = 0;

        public static int distance = 0;
        public static double CSize = 0;
        public static double CostTotal;
        public static double AverageCost = 0;
        static void Main(string[] args)
        {
            

            int input = -1;
            Console.WriteLine("The Carpet Fitting Cost Calculator");
            while(input != 0)
            {
                Console.Write("Enter a distance in kilometres: ");
                distance = Convert.ToInt32(Console.ReadLine());
                FitTotal++;
                Console.Write("Enter a Carpet size: ");
                CSize = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Cost of Fitting: EUR {0}",Calculator(distance,CSize));
                CostTotal += Calculator(distance, CSize);

                Console.Write("Enter a 0 to end or 1 to add another fitting ");
                input = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
            }
            AverageCost = CostTotal / FitTotal;
            Console.WriteLine("Total Costs: EUR {0}",CostTotal);
            Console.WriteLine("Average Costs: EUR {0}",AverageCost);




        }
        public static double Calculator(int dis,double size)
        {
            FitCostTotal += (dis * TCost) + (size * FCost);
            if ( FitCostTotal > 250.00)
                FitCostTotal -= (FitCostTotal * 0.1);
            return FitCostTotal;
        }
    }
}
