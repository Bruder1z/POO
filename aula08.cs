namespace Agenda
{
    public class Pessoa
    {
        private String _nome;
        private String _email;
        private String _tel;

        public Pessoa(string nome, string tel, string email)
        {
            this.nome = nome;
            this.tel = tel;
            this.email = email;
        }

       public Pessoa()
        {
            this.nome = "";
            this.tel = "";
            this.email = "";
        }
        public string nome
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

        public string tel
        {
            get
            {
                return this._tel;
            }
            set
            {
                this._tel = value;
            }
        }

        public string email
        {
            get
            {
                return this._email;
            }
            set
            {
                this._email = value;
            }
        }
        public void exibeDados()
        {
            Console.Clear();
            Console.WriteLine("NOME: " + this.nome);
            Console.WriteLine("E-MAIL: " + this._email);
            Console.WriteLine("TELEFONE: " + this.tel);
        }
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa("LUCAS BRUDER", "99175-8586", "brudervz@gmail.com");
            Pessoa p2 = new Pessoa ();
            //p1.nome = "LUCAS BRUDER";
            //p1.tel = "99175-8586";
            //p1.email = "brudervz@gmail.com";
            p1.exibeDados();
            Console.ReadKey();
        }

    }


}
