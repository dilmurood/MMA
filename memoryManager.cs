class MemoryManager
{
    public List<MemoryBlock> memoryBlocks;
    public MemoryManager(int memorySize)
    {
        memoryBlocks = new List<MemoryBlock>(memorySize);
    }

    public bool FirstFit(char processID, int size)
    {
        foreach (var block in memoryBlocks)
        {
            if (block.Size >= size)
            {
                block.ProcessID = processID;
                Console.WriteLine("Memory allocated to " + "process id: " + processID + ", size: " + size);
                Console.WriteLine("Process id: " + block.ProcessID + ", taken total space " + block.Size);
                return true;
            }
        }
        return false;
    }

    public bool BestFit(char processID, int size)
    {
        foreach (var block in memoryBlocks)
        {
            if (block.Size == size)
            {
                Console.WriteLine("Memory allocated to " + "process id: " + processID + ", size of " + size);
                Console.WriteLine("Process id: " + block.ProcessID + ", taken total space " + block.Size);
                return true;
            }
        }
        
        return false;
    }

    public bool WorstFit(char processID, int size)
    {
        foreach(var block in memoryBlocks)
        {
            if(block.Size >= size + 20)
            {
                Console.WriteLine("Memory allocated to " + "process id: " + processID + ", size of " + size);
                Console.WriteLine("Process id: " + block.ProcessID + ", taken total space " + block.Size);
                return true;
            }           
        }

        return false;
    }
}