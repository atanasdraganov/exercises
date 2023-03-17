// See https://aka.ms/new-console-template for more information
int n = int.Parse(Console.ReadLine());
int sum1 = 0, sum2 = 0;
int[,] m = new int[n,n];
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write("element - [{0},{1}] : ", i, j);
        m[i, j] = Convert.ToInt32(Console.ReadLine());
    }
}

Console.Write("\nThe matrix is : \n");
for (int i = 0; i < n; i++)
{
    Console.Write("\n");
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write("{0}\t", m[i, j]);
        }
    }
}
Console.Write("\n\n");

for (int i = 0; i < n; i++)
{

    // calculating the main diagonal sum
    sum1 += m[i, i];

    // calculating the off diagonal sum
    sum2 += m[i, n - i - 1];
}

Console.WriteLine("Sum1 is: " + sum1);
Console.WriteLine("Sum2 is: " + sum2);
Console.ReadKey();
   


