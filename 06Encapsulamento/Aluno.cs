using System;
class Aluno
{

  /* Quanto mais encapsulado mais seguro fica o codigo. O encapsulamente basicamente controla o acesso aos atributos e metodos das classes. Ao criar metodos e atributos como privados, vc remove o acesso a eles por meio das instancias das classes. Com o conceito de encapsulamento voce cria metodos e atributos publicos que tem acesso aos metodos/atributos de acesso privado. Dessa forma voce restringe o acesso aos dados dos metodos/atributos privados de acordo com a lógica implementada no método/atributo publico.
    Neste exemplo nós deixamos as notas como atributos privados e a média como método privado. A unica forma de acessar esses dados é através da própria classe. O método publico mensagem() tem acesso as notas e a média, ja que está na mesma classe. Entao a unica forma de acessar esses valores através de uma instancia do objeto Aluno é chamando o metodo publico mensagem(). Ex: Aluno a1 = new Aluno; a1.mensagem(); */
  private double nota1, nota2;
  private double media()
  {
    return (nota1 + nota2) / 2;
  }


//
  public void mensagem()
  {

    Console.WriteLine("Digite a primeira nota: ");
    this.nota1 = Convert.ToInt32(Console.ReadLine()); //nesse caso o this nao é necessario, ja que a unica variavel com o nome nota1 está na mesma classe. Se houvesse um parametro com o nome nota1, aí seria necessario usar o this para se referir ao atributo da classe, e nao ao parametro.
    
    Console.WriteLine("Digite a segunda nota: ");
    nota2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("A média é " + media());
  }
}