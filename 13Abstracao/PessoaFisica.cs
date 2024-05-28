using System;

class PessoaFisica : Padrao
{
  //metodo obrigatorio que foi definido na classe Padrao. Se este metodo nao estivesse aqui daria erro
  public override void taxaEmprestimo(double valor) 
  {
    Console.WriteLine("Taxa de emprestimo para pessoa física R$ " + (valor * 0.1));
  }

}