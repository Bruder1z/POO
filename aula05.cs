using System.Xml;

class program
{
    static void Main(string[] args)
    {
        Aluno a = new Aluno();
        a.nome = "LUCAS";
        a.p1 = 10;
        a.p2 = 10;
        a.mensagem();
        Console.WriteLine("");
    }

    class Aluno
    {
        //Atributos
        public string nome;

        public double p1, p2;

        //média
        public double media()
        {
            return (p1 + p2)/2;
        }
        //situação
        public string situacao(double media)
        {
            return media >= 7 ? "APROVADO " : "REPROVADO";
        }
        //mensagem
        public void mensagem()
        {
            //obter a media
            double obterMedia = media();

            //obter a situação
            string obterSituação = situacao(obterMedia);

            //Mensagem
            Console.WriteLine(nome + " está " + obterSituação + " com média " + obterMedia);
        }
    }
}