
using System.Text.Json;

int[] list = { 2, 3, 4, 1, 6 };

for (int i = 1; i < list.Length; i++)
{
    int j = i - 1;

    while(j >= 0 && list[j+1] < list[j])
    {
        int temp = list[j + 1];

        list[j + 1] = list[j];
        list[j] = temp;

        j--;
    }
}

Console.WriteLine(JsonSerializer.Serialize(list));