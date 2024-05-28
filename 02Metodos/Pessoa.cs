using System;

class Pessoa // importante que seja sempre o nome do arquivo. Padrao universal da POO é comecar uma classe com letra maiuscula
{
  // Os metodos podem ter o mesmo nome desde que tenham parametros diferentes
  //metodo 01 
  public void apresentar()
  {
    Console.WriteLine("Olá");
  }

  //metodo 02
  public void apresentar(string nome)
  {
    Console.WriteLine("Olá " + nome);
  }

  //metodo 03
  public void apresentar(string nome, int idade)
  {
    Console.Write("Olá " + nome + " você tem " + idade + " anos");
  }
}