using System;
using System.Runtime.CompilerServices;

class Colaborador : Pessoa // Os : Pessoa extende o acesso da classe Colaborador à classe Pessoa, ou seja, herda os atributos e métodos da classe Pessoa. Sem essa herança, nao é possivel usar o this.nome, ja que esse atributo pertence à classe Pessoa. Note que extendendo a classe pessoa para a classe Colaborador, o this. acessa os atributos e metodos da classe Pessoa, como se fizessem parte da propria classe Colaborador. 

{
  //Atributo
  private double salario;
  private int? faltas;

  //Construtor
  public Colaborador(string nome, int idade, double salario, int faltas)
  {
    Console.WriteLine("Digite seu nome, sua idade e o número de faltas: ");
    this.nome = nome;
    this.idade = idade;
    this.salario = salario;
    this.faltas = faltas;
    mensagemPessoa(); // a unica forma de acessar um metodo protegido é pela propria classe a classe que se extende dela(herda ela)
    mensagemColaborador(); 
  }

  //Metodo
  private void mensagemColaborador()
  {
    Console.WriteLine("Salário: " + salario);
    Console.WriteLine("Faltas: " + faltas);
  }
  
}