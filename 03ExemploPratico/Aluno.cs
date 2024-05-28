using System;

public class Aluno
{
  //atributos
  public string? nome; // o Ponto de interrogacao indica que a variavel pode ser nula. Vale para todos os tipos
  public double nota1, nota2;

  //métodos
  public double media()
  {
    return (nota1 + nota2) / 2;
  }

  public string situacao(double media)
  {
    return media >= 7 ? "Aprovado" : "reprovado"; //operador ternario: ? (caso) : (caso contrario)
  }

  public void mensagem()
  {
    double obterMedia = media();
    string obterSituacao = situacao(obterMedia);
    Console.WriteLine(nome + " está " + obterSituacao + " com média " + obterMedia);
  }
}