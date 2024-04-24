using System;
class Ingresso
{
    public double Valor { get; set; }

    public Ingresso(double valor)
    {
        Valor = valor;
    }

    public void ImprimeValor()
    {
        Console.WriteLine("Valor do Ingresso: R$" + Valor);
    }
}

class VIP : Ingresso
{
    public double ValorAdicional { get; set; }

    public VIP(double valor, double valorAdicional) : base(valor)
    {
        ValorAdicional = valorAdicional;
    }

    public double ValorIngressoVIP()
    {
        return Valor + ValorAdicional;
    }
}

class Normal : Ingresso
{
    public Normal(double valor) : base(valor)
    {
    }

    public void ImprimeTipoIngresso()
    {
        Console.WriteLine("Ingresso Normal");
    }
}

class CamaroteInferior : VIP
{
    public string Localizacao { get; set; }

    public CamaroteInferior(double valor, double valorAdicional, string localizacao) : base(valor, valorAdicional)
    {
        Localizacao = localizacao;
    }

    public void ImprimeLocalizacao()
    {
        Console.WriteLine("Localização: " + Localizacao);
    }
}

class CamaroteSuperior : VIP
{
    public CamaroteSuperior(double valor, double valorAdicional) : base(valor, valorAdicional)
    {
    }

    public double ValorIngressoCamaroteSuperior()
    {
        return ValorIngressoVIP(); // Reutiliza o método de VIP
    }
}

class Program
{
    static void Main()
    {
        Ingresso ingresso = new Ingresso(100.00);
        ingresso.ImprimeValor();

        Normal ingressoNormal = new Normal(50.00);
        ingressoNormal.ImprimeTipoIngresso();

        VIP ingressoVIP = new VIP(120.00, 20.0);
        Console.WriteLine("Valor do Ingresso VIP: R$" + ingressoVIP.ValorIngressoVIP());

        CamaroteInferior camaroteInferior = new CamaroteInferior(100.0, 25.0, "Setor A");
        camaroteInferior.ImprimeLocalizacao();
        Console.WriteLine("Valor do Ingresso Camarote Inferior: R$" + camaroteInferior.ValorIngressoVIP());

        CamaroteSuperior camaroteSuperior = new CamaroteSuperior(100.00, 30.0);
        Console.WriteLine("Valor do Ingresso Camarote Superior: R$" + camaroteSuperior.ValorIngressoCamaroteSuperior());
    }
}
}