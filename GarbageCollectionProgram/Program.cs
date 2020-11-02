using System;
using System.Dynamic;

namespace GarbageCollectionProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //GC is an inbuilt class
            long mem1 = GC.GetTotalMemory(false);
            {
                //allocate an array and make it unreachable
                int[] value = new int[5000];
                value = null;
            }

            long mem2 = GC.GetTotalMemory(false);
            {
                GC.Collect();
            }

            long mem3 = GC.GetTotalMemory(false);
            {
                Console.WriteLine(mem1);
                Console.WriteLine(mem2);
                Console.WriteLine(mem3);
            }

            Console.WriteLine("------------");

            //get memory in bytes
            long byte1 = GC.GetTotalMemory(false);
            byte[] memory = new byte[1000 * 1000 * 10];
            memory[0] = 1;

            long byte2 = GC.GetTotalMemory(false);
            long byte3 = GC.GetTotalMemory(true);

            Console.WriteLine(byte1);
            Console.WriteLine(byte2);
            Console.WriteLine(byte2 - byte1);
            Console.ReadLine();
        }
    }
}

    