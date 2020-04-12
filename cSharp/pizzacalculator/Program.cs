using System;

namespace pizzacalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("PEOPLE THAT ORDER ONE SLICE OF PIZZA,Enter number of small,medium and large pizza: ");
            string OneSlice = Console.ReadLine();

            Console.Write("PEOPLE THAT ORDER TWP SLICES OF PIZZA,Enter number of small,medium and large pizza: ");
            string TwoSlice = Console.ReadLine();

            Console.Write("PEOPLE THAT ORDER THREE SLICES OF PIZZA,Enter number of small,medium and large pizza: ");
            string ThreeSlice = Console.ReadLine();

            Console.Write("PEOPLE THAT ORDER FOUR SLICES OF PIZZA,Enter number of small,medium and large pizza: ");
            string FourSlice = Console.ReadLine();
            
            string[] SliceOne = OneSlice.Split(",");
            string[] SliceTwo = TwoSlice.Split(",");
            string[] SliceThree = ThreeSlice.Split(",");
            string[] SliceFour = FourSlice.Split(",");

            Console.WriteLine($"Large Pizza: {(int)Math.Floor(((Convert.ToDecimal(SliceOne[2]) + Convert.ToDecimal(SliceTwo[2])  + Convert.ToDecimal(SliceThree[2]) + Convert.ToDecimal(SliceFour[2]))/8) + Convert.ToDecimal(0.5))}");
            Console.WriteLine($"Medium Pizza: {(int)Math.Floor(((Convert.ToDecimal(SliceOne[1]) + Convert.ToDecimal(SliceTwo[1])  + Convert.ToDecimal(SliceThree[1]) + Convert.ToDecimal(SliceFour[1]))/6) + Convert.ToDecimal(0.5))}");
            Console.WriteLine($"Small Pizza: {(int)Math.Floor(((Convert.ToDecimal(SliceOne[0]) + Convert.ToDecimal(SliceTwo[0])  + Convert.ToDecimal(SliceThree[0]) + Convert.ToDecimal(SliceFour[0]))/4) + Convert.ToDecimal(0.5))}");



            

            
        }
    }
}
