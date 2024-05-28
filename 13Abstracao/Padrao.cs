using System;

abstract class Padrao // Quando cria uma classe abstract é criado um padrao para os projetos 
// é  possível criar métodos obrigatorios ou opcionais. obrigatorios = public/protected abstract void Metodo(); 
//todas as classes que se extenderem a esta classe deverão ter o metodo obrigadotio override void taxaEmprestimo(double valor)
{
  //método obrigatorio: Tambem leva a palavra abstract e Pode ser público ou protegido
  public abstract void taxaEmprestimo(double valor); //Nao é usado chaves, ja que a regra de negocio é definida dentro da classe que herda esta classe

  //metodo opcional:
  public void calculoPoupanca(double valor, double taxa)
  {
    Console.WriteLine("Ganhos obtidos pela poupança R$ " + (valor * taxa));
  }
}