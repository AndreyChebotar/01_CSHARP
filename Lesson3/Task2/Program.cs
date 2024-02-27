void PrintSqaures(int limit)
{
    int i = 1;
    while(i <= limit)
    {
        Console.Write($"{i * i} ");
        i = i + 1; // или можно использовать i++; 
    }
}
PrintSqaures(5);
PrintSqaures(10);
PrintSqaures(15);