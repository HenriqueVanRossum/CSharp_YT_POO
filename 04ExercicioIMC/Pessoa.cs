using System;
using System.Diagnostics.Contracts;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;


class Pessoa
{
  public string? nome;
  public double peso, altura;

  public double calcularImc(double altura, double peso)
  {
    double imc = peso / Math.Pow(altura, 2);
    return imc;
  }

  public string situacaoImc(double imc)
  {
    string situacao = "";
    if (imc < 18.5)
    {
      situacao = "Abaixo do peso";
    }
    else if (imc < 25)
    {
      situacao = "Peso normal";
    }
    else if (imc < 30)
    {
      situacao = "Acima do peso";
    }
    else if (imc < 35)
    {
      situacao = "Obesidade I";
    }
    else if (imc < 40)
    {
      situacao = "Obesidade II";
    }
    else
    {
      situacao = "Obesidade III";
    }
    return situacao;
  }

  public void mensagem() 
  {
    double obterImc = calcularImc(altura, peso);
    string obterSituacao = situacaoImc(obterImc);
    Console.WriteLine($"{nome} seu IMC está {obterImc:N2} e voce está {obterSituacao}");
  }
}