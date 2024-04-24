using System;


class Pessoa
{

    static void Main(string[] args)
    {
        Pessoa p = new Pessoa();
        p.peso = 80;
        p.altura = 1.80;
        p.mensagem();
    }
    //atribos
    public double peso, altura;

    //metodo de calculo
    public double calculo()
    {
        return peso / (altura * altura);
    }
    //SITUAÇÃO
    public string situacao(double imc)
    {
        //Variavel
        string retorno;
        //condicional
        if(imc < 18.5)
        {
            retorno = "ABAIXO DO PESO";
        }
        else if(imc < 25)
        {
            retorno = "peso normal";
        }
        else if (imc < 30)
        {
            retorno = "acima do normal";
        }
        else if (imc < 35)
        {
            retorno = "obesidade 1";
        }
        else if (imc < 40)
        {
            retorno = "obesidade 2";
        }
        else 
        {
            retorno = "obesidade 3";
        }

        //retorno
        return retorno;
    }

    //mensagem
    public void mensagem()
    {
        //obter calculo
        double obterCalculo = calculo();

        //obter situaçao
        string obterSituacao = situacao(obterCalculo);

        //    exibir mensagem
        Console.WriteLine("SEU IMC É DE "+obterCalculo);
        Console.WriteLine("SUA SITUAÇÃO É "+obterSituacao);
    }

    

}