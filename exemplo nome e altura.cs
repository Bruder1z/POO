class Program
{
    class Pessoa
    {
        public string nome;
        public double altura;
        public void talkAboutU()
        {
            Console.WriteLine("MEU NOME É " + nome);
            Console.WriteLine("MINHA ALTURA É " +  altura);
        }

        static  void Main(string[] args)
        {
            string entrada = "";
            Pessoa pessoa1;
            pessoa1 = new Pessoa();
            Console.WriteLine("EFETUA A LEITURA DOS DADOS DE TRÊS PESSOAS");
            Console.WriteLine("DADOS DA 1 PESSOA");
            Console.WriteLine("INFORME SEU NOME: ");
            entrada = Console.ReadLine();
            pessoa1.nome = entrada;
            Console.WriteLine("INFORME SUA ALTURA: ");
            entrada = Console.ReadLine();
            pessoa1.altura = Convert.ToDouble(entrada);
            pessoa1.talkAboutU();
            Console.ReadKey();

            Pessoa pessoa2;
            pessoa2 = new Pessoa();
            Console.WriteLine("DADOS DA 2 PESSOA");
            Console.WriteLine("INFORME SEU NOME: ");
            entrada = Console.ReadLine();
            pessoa2.nome = entrada;
            Console.WriteLine("INFORME SUA ALTURA: ");
            entrada = Console.ReadLine();
            pessoa2.altura = Convert.ToDouble(entrada);
            pessoa2.talkAboutU();
            Console.ReadKey();

            Pessoa pessoa3;
            pessoa3 = new Pessoa();
            Console.WriteLine("DADOS DA 3 PESSOA");
            Console.WriteLine("INFORME SEU NOME: ");
            entrada = Console.ReadLine();
            pessoa3.nome = entrada;
            Console.WriteLine("INFORME SUA ALTURA: ");
            entrada = Console.ReadLine();
            pessoa3.altura = Convert.ToDouble(entrada);
            pessoa3.talkAboutU();
            Console.ReadKey();
        }
    }
}