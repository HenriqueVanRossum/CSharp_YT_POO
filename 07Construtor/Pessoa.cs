using System;
/* Um construtor é executado assim que voce instancia a classe.
  Todo Construtor é publico, e ele sempre tem o nome da classe.
  É possivel ter vários construtores desde que eles tenham alguma característica diferente. Ex parametro
  Dependendo de como o objeto for instanciado voce vai chamar um construtor ou outro. Apenas 1 construtor é inicializado quando um objeto dessa classe é instanciado*/
class Pessoa
{
  public Pessoa()
  {
    Console.WriteLine("Construtor Iniciado");
  }

  public Pessoa(string nome)
  {
    Console.WriteLine("Olá " + nome);
  }
}