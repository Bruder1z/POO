class Program
{

  class Pessoa
    {
        private string nome;
        private double altura;

        public void setNome(String valor)
        {
            //nome = valor;
            this.nome = valor;
        }
        public string getNome()
        {
            return this.nome;
        }

        public void setAltura(double valor)
        {
            //nome = valor;
            this.altura = valor;
        }
        public double getAltura()
        {
            return this.altura;
        }


        public void TalkAboutU()
        {
            Console.WriteLine("MEU NOME É: " + nome);
            Console.WriteLine("EU TENHO : "+  altura + "METROS DE ALTURA");
        }
    }
    static void Main(string[] args)
    {
        string entrada = "";
        Pessoa pessoa1;
        pessoa1 = new Pessoa();
        Console.WriteLine("EFETUA A LEITURA DOS DADOS DE TRÊS PESSOAS");
        Console.WriteLine("DADOS DA 1 PESSOA: ");
        Console.WriteLine("INFORME SEU NOME");

        entrada = Console.ReadLine();
        pessoa1.setNome(entrada);
        Console.WriteLine("INFORME SUA ALTURA: ");
        entrada = Console.ReadLine();
        pessoa1.setAltura(Convert.ToDouble(entrada));
        pessoa1.TalkAboutU();
        Console.ReadKey();
    }
}