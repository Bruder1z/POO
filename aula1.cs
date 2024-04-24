class Program
{
    static void Fatorial(int x)
    {
        int fat = 1;
        for (int i = x; i > 0; i--)
        {
            fat = fat * i;
        }
        Console.WriteLine(fat);
    }


    static void Main(string[] args)
    {
        Console.WriteLine("Digite um número para saber seu fatorial: ");
        int x = int.Parse(Console.ReadLine());

        Fatorial(x);
        Console.ReadKey();
    }
}