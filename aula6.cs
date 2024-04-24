//ESTRUTURA CENTRAL -> OBJETOS

//SOFTWARE HOUSE ESTÁ PRONTO - FÁBRICA DE SOFTWARE CONSTROI

//vantgens poo
//--> reutilização de código
//--> expansao do código

//suporte para;
//-->ABSTRAÇÃO: 
//-->ENCAPSULAMENTO:
//-->HERANÇA:
//-->POLIMORFISMO:

//Todo objeto deriva de uma classe, sem a classe nao HÁ objeto

//Objetos sao instâncias úteis de uma classe

//TIPO CLASSE -> ARMAZENA ENDEREÇO DE MEMÓRIA DE UM OBJETO NA RAM

//Função dentro de uma classe se chama método

//Método contrutor nao é obrigátorio. chamado automaticamneto quando tiver a criação do objeto

//Para chamar o método precisa mostrar o qual ele faz parte

// class Program
//{
// class Circle
// {
// private int raio;
// }
// static void Main(string[]args)
// {
// Circle c; //cria uma variavel da classe
// c = new Circle(); //inicializa a variavel
// //atribuiçao alocaçao dinamica de memoria
// }
//}

//funçao dentro de uma classe nao se chama funçao, se chama método
//quando eu instacio o obj o metodo contrutor nao é necessario chamar

//class Program
//{
// class Circle
// {
// private int raio;
// public Circle()
// {
// raio = 2;
// Console.Write(raio);
// }
// }
// static void Main(string[] args)
// {
// Circle circle = new Circle();
// }
//}

//class Program
//{
// class Circle
// {
// private int raio;
// public Circle() //construtor padrao
// {
// raio = 2;
// }
// public double Area()
// {
// return (Math.PI * raio * raio);
// }
// }
// static void Main(string[] args)
// {
// Circle c= new Circle();
// double areadocirculo;
// areadocirculo = c.Area();
// Console.WriteLine(areadocirculo);
// Console.ReadKey();
// }
//}

//class Program
//{
// class Circle
// {
// private int raio;
// public Circle() //construtor padrao
// {
// raio = 0;
// }
// public Circle(int raioInicial)
// {
// raio = raioInicial;
// }
// public double Area()
// {
// return (Math.PI * raio * raio);
// }
// }
// static void Main(string[] args)
// {
// Circle c = new Circle(4);
// double areadocirculo;

// Circle d = new Circle();
// areadocirculo = c.Area();
// Console.WriteLine(areadocirculo);
// Console.ReadKey();
// }
//}


