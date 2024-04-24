using System.Transactions;

class Program
{

    class Aluno
    {
        private string _nome;
        public string nome;
        {
            get
            {
                return this._nome;
            }
            set
            {
                this._nome = value;
            }
        }
        private double _nota1;
        public double nota1
        {
            get
            {
                return this._nota1;
            }
            set
            {
                this.nota1 = value;
            }
        }

        private double _nota2;
        public double nota2
        {
            get
            {
                return this._nota2;
            }
            set
            {
                this.nota2 = value;
            }
        }

        private double _nota3;
        public double nota3
        {
            get
            {
                return this._nota3;
            }
            set
            {
                this.nota3 = value;
            }
        }

        private double _nota4;
        public double nota4
        {
            get
            {
                return this._nota4;
            }
            set
            {
                this.nota4 = value;
            }
        }

        public double media()
        {
            return (this._nota1 + this._nota2 + this._nota3 + this._nota4) / 4;
        }

        public void exibeMedia()
        {
            Console.Clear();
            Console.WriteLine("NOME: " + this._nome);
            Console.WriteLine("NOTA 1: " + this._nota1);
            Console.WriteLine("NOTA 2: " + this._nota2);
            Console.WriteLine("NOTA 3: " + this._nota3);
            Console.WriteLine("NOTA 4: " + this._nota4);
            Console.WriteLine("MEDIA: " + this.media());
        }

    }

    static void Main(string[] args)
    {
        Aluno obj = new Aluno();
        string entrada = "";
        Console.WriteLine("CALCULA A MEDIA DE UM ALUNO");
        Console.WriteLine("DIGITE SEU NOME: ");
        entrada = Console.ReadLine();
        obj.nome = entrada;

        Console.WriteLine("NOTA 1: ");
        entrada = Console.ReadLine();
        obj.nota1 = Convert.ToDouble(entrada);

        Console.WriteLine("NOTA 2: ");
        entrada = Console.ReadLine();
        obj.nota2 = Convert.ToDouble(entrada);

        Console.WriteLine("NOTA 3: ");
        entrada = Console.ReadLine();
        obj.nota3 = Convert.ToDouble(entrada);

        Console.WriteLine("NOTA 4: ");
        entrada = Console.ReadLine();
        obj.nota4 = Convert.ToDouble(entrada);
        obj.exibeMedia();
        Console.ReadKey();
    }
}