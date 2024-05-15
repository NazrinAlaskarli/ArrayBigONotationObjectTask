// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


int[] intArray = new int[] { 2, 9, 4, 3, 5, 1, 7 };
int temp = 0;

for (int i = 0; i <= intArray.Length - 1; i++)
{
    for (int j = i + 1; j < intArray.Length; j++)
    {
        if (intArray[i] > intArray[j])
        {
            temp = intArray[i];
            intArray[i] = intArray[j];
            intArray[j] = temp;
        }
    }
}
foreach (var item in intArray)
{
    Console.WriteLine(item);
}
Console.ReadLine();
