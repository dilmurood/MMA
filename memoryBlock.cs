class MemoryBlock
{
    public int StartAddress { get; set; }
    public int Size { get; set; }
    public char ProcessID { get; set; }

    public MemoryBlock(int startAddress, int size, char processID)
    {
        StartAddress = startAddress;
        Size = size;
        ProcessID = processID;
    }
}