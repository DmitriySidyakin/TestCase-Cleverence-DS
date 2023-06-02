// See https://aka.ms/new-console-template for more information
using TestCase_Cleverence_DS;

Console.WriteLine("Test 1");

string s1 = "aaabbcccdde";
Console.WriteLine($"BASE = {s1} ; RESULT = {Task1.Compression(s1)}");

Console.WriteLine("Test 2");

int[,] matrix1 = new int[3, 3] {
    {1, 2, 3 },
    {4, 5, 6 },
    {7, 8, 9 }
};

int[,] matrix2 = new int[3, 4] {
    {1, 2, 3, 4 },
    {5, 6, 7, 8 },
    {9, 10, 11, 12 }
};

int[] result1 = Task2.Spiralize(3, 3, matrix1);
int[] result2 = Task2.Spiralize(4, 3, matrix2);

for(int i = 0; i < result1.Length; i++)
{
    Console.Write(result1[i] + (i == result1.Length - 1 ? ";" : ", "));
}

Console.WriteLine();

for (int i = 0; i < result2.Length; i++)
{
    Console.Write(result2[i] + (i == result2.Length - 1 ? ";" : ", "));
}