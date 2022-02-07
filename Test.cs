using System;

int[][] nums = new int[2][];
nums[0] = new int[]{ 1, 2, 3};
nums[1] = new int[]{ 4, 5, 6};
for (int i = 0; i < nums.Length; i++)
{
    for (int j = 0; j < nums[i].Length; j++)
    {
        Console.Write($"{nums[i][j]} \t");
    }
    Console.WriteLine();
}

int[,,] mas = { { { 1, 2 },{ 3, 4 } },
                { { 4, 5 }, { 6, 7 } },
                { { 7, 8 }, { 9, 10 } },
                { { 10, 11 }, { 12, 13 } }
              };
int izm1 = mas.GetLength(0);
int izm2 = mas.GetLength(1);
int izm3 = mas.GetLength(2);
//Console.WriteLine($"izm1 = {izm1}");
//Console.WriteLine($"izm2 = {izm2}");
//Console.WriteLine($"izm3 = {izm3}");
for(int i = 0;i < izm1; i++)
{
    if(i == 0)
        Console.Write("{");
    for (int j = 0;j < izm2; j++)
    {
        if(j == 0)
            Console.Write("{");
        for(int k = 0;k < izm3; k++)
        {
            if(k == 0)
                Console.Write("{");
            Console.Write($"{mas[i, j, k]}");
            if (k < izm3-1)
            {
                Console.Write(" , ");
            }

        }
        Console.Write("}");
        if (j < izm2-1)
            Console.Write(" , ");
    }
    Console.Write("}");
    if (i < izm1-1)
        Console.Write(" , ");
    if (i == izm1 - 1)
        Console.Write("}");

}