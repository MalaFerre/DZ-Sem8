int ReadInt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,,] GenerateCube(int A, int B, int C)
{
    int[,,] cube = new int[A, B, C];
    Random rand = new Random();
    for (int i = 0; i < A; i++)
    {
        for (int j = 0; j < B; j++)
        {
            for (int k = 0; k < C; k++)
            {
                cube[i, j, k] = rand.Next(-10, 10);
            }
        }
    }
    return cube;
}

void PrintCube(int[,,] cube)
{
    for (int i = 0; i < cube.GetLength(0); i++)
    {
        for (int j = 0; j < cube.GetLength(1); j++)
        {
            for (int k = 0; k < cube.GetLength(2); k++)
            {
                Console.Write($"{cube[i, j, k]}({i},{j},{k}) \t");
            }
            Console.WriteLine();
        }
    }
}

int myA = ReadInt("Введите размер стороны A: ");
int myB = ReadInt("Введите размер стороны B: ");
int myC = ReadInt("Введите размер стороны C: ");

PrintCube(GenerateCube(myA, myB, myC));
