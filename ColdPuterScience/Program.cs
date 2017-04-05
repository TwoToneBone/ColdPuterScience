using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColdPuterScience
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
            string [] inputs = Console.ReadLine().Split(' ');
            int[] temps = new int[inputs.Length];
            for (int i = 0; i < temps.Length; i++)
            {
                temps[i] = int.Parse(inputs[i]);
            }
            int counter = 0;
            for (int i = 0; i < temps.Length; i++)
            {
                if (temps[i] < 0)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
