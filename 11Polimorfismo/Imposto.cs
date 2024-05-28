using System;
using System.Runtime.InteropServices;
using _11Polimorfismo;

class Imposto
{
  public virtual void valeAlimentacao(double salario)
  {
   
    Console.WriteLine("Desconto padrão do Vale Alimentação: R$" + (salario * 0.1));
  }

  public void valeTransporte(double salario)
  {
    Console.WriteLine("Desconto padrão do Vale Transporte: R$" + (salario * 0.06));
  }
  
}
