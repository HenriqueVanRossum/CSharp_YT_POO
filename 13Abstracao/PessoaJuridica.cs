using System;

class PessoaJuridica: Padrao
{
  //metodo obrigatorio que foi definido na classe Padrao
  public override void taxaEmprestimo(double valor) 
  {
    Console.WriteLine("Taxa de emprestimo para pessoa jurídica R$ " + (valor * 0.2));
  }

}