using System;
class Calculo : IPadrao
{
  //Com os metodos definidos na interface IPadrao nao dá problema. Se algum desses metodos nao estivesse aqui daria erro, ja que os metodos da interface sao obrigatorios;
  public void somar(int n1, int n2)// Aqui voce define se o metodo é publico, privado ou protegido, e nao na classe da Interface
  {
    Console.WriteLine($"A soma é entre {n1} e {n2} é " + (n1 + n2)); 
  }

  public void subtrair(int n1, int n2)
  {
    Console.WriteLine($"A subtraçao de {n1} e {n2} é " + (n1 - n2));
  }
}