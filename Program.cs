using static System.Console;

class Program
{
    static void Main(string[] args)
    {

        int size = 8;

        for (int row = 0; row < size; row++)
        {
            for (int col = 0; col < size; col++)
            {
                if ((row + col) % 2 == 0)
                {
                    Write("X ");
                }
                else
                {
                    Write("O "); 
                }
            }
            WriteLine(); 
        }
        ReadKey();
    }
}