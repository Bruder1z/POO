////reclusividade  é qndo a função chama a si mesma

////INSTANCIA: chama a mesma função porém em blocos diferentes

////TODO BLOCO RECLUSIVO TEM UM PONTO DE PARADA (REGRA DO JOGO)
////caso não tenha ponto de parada, ele entra em looping infinito

////Reclusividade é um laço em memória RAM

//O QUE EU FAÇO COM A RECLUSIVDADE EU FAÇO SEM ELA (MELHOR FAZER SEM ELA - EX USO DE FOR)
//Usar apenas em programas especifícos e caso seja pedido


//VANTAGENS DA RECLUSIVIDADE:
//maneira mas logica de resolver o problema
//Pra ficar compacto
//escreve algortimos de maneira mais clara e concisa

//DESVANTAGENS DA RECLUSIVIDADE
//constante uso da pilha, resultando em uma operação mais lenta
//empilhamento de endereços
//stack overflow
//redução empenho e desempenho
//dificuldade na depuração do programa, ainda mais c for muito profundo
//reclusão profunda = muitas chamadas no mesmo bloco
//main congela

class Program


//{
//    static int Fatorial(int x)
//    {
//        if (x == 1) return (1);
//        return (x * Fatorial(x - 1));
//    }


//    static void Main(string[] args)
//    {
//        int num = 5;
//        Console.WriteLine("{0}", Fatorial(num));
//        Console.ReadKey();
//    }
//}


//{
//    public static int potencia(int num, int pot)
//    {
//        if (pot == 0)
//            return 1;
//        else
//            return num = potencia(num, pot - 1);
//    }
//    static void Main(string[] args)
//    {
//        int num, pot;
//        Console.WriteLine("Digite a base: ");
//        num = int.Parse(Console.ReadLine());
//        Console.WriteLine(("Digite a potencia"));
//        pot = int.Parse(Console.ReadLine());
//        Console.WriteLine("{0} elevado a {1}e{2} ", num, pot, potencia(num, pot));
//        Console.ReadKey();

//    }



//}

//{
//    static void exibe(int max, int [] v)
//    {
//        Console.WriteLine(v[max]);
//        if (max != v.Length - 1)
//        {
//            exibe(max + 1, v);
//        }
//    }

//    static void Main(string[] args)
//    {
//        int[] vetor = new int[] { 1, 2, 3, 4 ,5};
//        exibe(0, vetor);
//        Console.ReadKey();
//    }
//}