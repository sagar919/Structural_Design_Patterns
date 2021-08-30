using System;

namespace AdapterDesignPattern2
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Non-adapted chemical compound
            Compound unknown = new Compound("Unknown");
            unknown.Display();

            // Adapted chemical compounds
            Compound water = new RichCompound("Water");
            water.Display();
            Compound ethanol = new RichCompound("Ethanol");
            ethanol.Display();
            Console.ReadKey();
        }
    }
}
