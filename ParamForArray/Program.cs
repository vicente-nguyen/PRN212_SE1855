int sum(params int[] arr)
{
    int s = 0;
    foreach (int x in arr)
        s = s + x;
    return s;
}
Console.WriteLine(sum());
Console.WriteLine(sum(1,4,9));
Console.WriteLine(sum(1,2,343,44,4,24,4,324,234,246,546,6));