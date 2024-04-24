//RECLUSIVIDADE DE CALDA -  QUANDO A CHAMADA ESTÁ NO FINAL
//class program
//{
//    static int fibi(int n)
//    {
//        if (n <= 1) return 1;
//        return (fibi(n - 1) + fibi (n - 2));
//    }

//    static void Main (string[] args)
//    {
//        int n;
//        Console.WriteLine("Digite um número: ");
//        n = int.Parse(Console.ReadLine());
//        Console.WriteLine("COM RECURSIVIDADE");
//        Console.Write(fibi(n - 1));
//        Console.ReadKey();
//    }
//}


//EX01
class program
{
    static int soma(int n)
    {
        if (n <= 1) return 1;
        return (n + soma(n -1));
    }

    static void Main (string[] args)
    {
        int n;
        Console.WriteLine("DIGITE UM NÚMERO: ");
        n = int.Parse(Console.ReadLine());
        Console.Write(soma(n));
        Console.ReadKey();
    }
}

//EX02
class ex2
{
    static int find(int[] array, int n)
    {
        if (n == 0) return int.MinValue;
        int max
    }
}