// See https://aka.ms/new-console-template for more information
int[] numbers = new int[0]; 

for (int i = 1; i <= 9; i++)
{
    for (int j = 1; j <= 9; j++)
    {
        for (int k = 1; k <= 9; k++)
        {
            int num = i * 100 + j * 10 + k;
            if ((Math.Abs(i - j) == 1 && Math.Abs(j - k) == 1) || (Math.Abs(i - k) == 1 && Math.Abs(k - j) == 1) || (Math.Abs(j - k) == 1 && Math.Abs(k - i) == 1))
            {
                Array.Resize(ref numbers, numbers.Length + 1);
                numbers[numbers.Length - 1] = num;
            }
        }
    }
}
Array.Sort(numbers);
foreach (int num in numbers)
{
    Console.WriteLine(num);
}


