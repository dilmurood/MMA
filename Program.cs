using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        MemoryBlock mb4 = new MemoryBlock(220, 30, 'D');//from address 220 to 250 == 30 unit available space
        MemoryBlock mb1 = new MemoryBlock(5, 20, 'A'); // from address 5 to 25 == 20 unit available space
        MemoryBlock mb2 = new MemoryBlock(85, 15, 'B'); // from address 85 to 100 == 15 unit available space
        MemoryBlock mb3 = new MemoryBlock(150, 50, 'C'); // from address 150 to 200 == 50 unit available space - for worst fit

        // Example Input
        MemoryManager memoryManager = new MemoryManager(10);
        memoryManager.memoryBlocks.Add(mb4);
        memoryManager.memoryBlocks.Add(mb2);
        memoryManager.memoryBlocks.Add(mb3);
        memoryManager.memoryBlocks.Add(mb1);

        // Allocate memory using First Fit
        if(memoryManager.FirstFit('Z', 20))
        {
            Console.WriteLine($"Memory allocated using FIRST FIT algorithm");
            Console.WriteLine();
        }

        // Allocate memory using Best Fit
        
        if(memoryManager.BestFit('X', 15))
        {
            Console.WriteLine($"Memory allocated using Best fit algorithm");
            Console.WriteLine();
        }
        // Allocate memory using Worst Fit
        if(memoryManager.WorstFit('V', 25))
        {
            Console.WriteLine($"Memory allocated using Worst fit algorithm");
            Console.WriteLine();
        }
         
        // Display allocated memory blocks
        
    }
}