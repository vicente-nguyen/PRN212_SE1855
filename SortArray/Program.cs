using System.Text;

void swap(ref int a, ref int b)
{
    int temp=a; 
    a=b; 
    b=temp;
}

void sort_arr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = 0; j < arr.Length; j++)
        {
            if (arr[i] < arr[j])
            {
                swap(ref arr[i],ref arr[j]);
            }
        }
    }
}

void create_array(int[] arr)
{
    Random rd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rd.Next(100);
    }
}

void print_array(int[]arr)
{
    foreach (int x in arr)
    {
        Console.Write($"{x}\t");
    }
}

int[]arr = new int[10];
create_array(arr);
Console.OutputEncoding = Encoding.UTF8;
Console.WriteLine("mảng trước khi sắp xếp");
print_array(arr);
Console.WriteLine("mảng sau khi sắp xếp");
sort_arr(arr);
print_array(arr);

Console.WriteLine();
Console.WriteLine("---------DEMO-----------");
void sortByWhile(int[] arr)
{
    int a;
    bool swapped = true;

    while (swapped)
    {
        swapped = false;
        a = 0;
        while (a < arr.Length - 1)
        {
            if (arr[a] > arr[a + 1])
            {
                swap(ref arr[a], ref arr[a + 1]);
                swapped = true;
            }
            a++;
        }
    }
}
int[] arr2 = new int[10];
create_array(arr2);
Console.WriteLine("mảng trước khi sắp xếp");
print_array(arr2);
Console.WriteLine("mảng sau khi sắp xếp");
sortByWhile(arr2);
print_array(arr2);