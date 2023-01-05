int [] array = {1, 12, 31, 10, 15, 10, 17, 18 };

int n=array.Length;
int find = 10;

int index = 0;

while (index <n)
{
    if (array[index]==find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}