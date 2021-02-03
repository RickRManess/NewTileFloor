using System;

namespace NewTileFloor
{
    class Program
    {
        static void Main(string[] args)
        {         
         
       
            int sideOne;
            int sideTwo;
            int height;
            double area;
            double cost;
            double totalCost;


            //Input Non Rectangle Dimensions
            Console.WriteLine("Enter Side 1");
            sideOne = Int32.Parse(Console.ReadLine());  

            Console.WriteLine("Enter Side 2");
            sideTwo = Int32.Parse(Console.ReadLine());

           
            Console.WriteLine("Enter Height");
            height = Int32.Parse(Console.ReadLine());

            int sideTotal = sideOne + sideTwo;
            area = sideTotal / 2 * height;

            Console.WriteLine("Enter Cost per square foot");
            cost = int.Parse(Console.ReadLine());
           
            //Calculations for cost
            totalCost = area * cost;
            Console.WriteLine("Total Cost to tile this floor $" + totalCost);

            //Calculations for labor
            int hours = (int)(area / 20);
            int labor = hours * 86;
            Console.WriteLine("Labor cost to tile this floor $" + labor);
        }


    }
}
