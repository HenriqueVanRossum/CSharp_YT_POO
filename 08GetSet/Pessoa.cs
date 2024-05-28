using System;
class Pessoa()
{
  private string nome= "";

  //Get e Set - Todo get e set é publico. Por padrão, coloca-se o mesmo nome que o atributo que vai receber o get/set em letra maiuscula
  public string Nome
  {
    get { return nome; } // caso nao queria permitir que a pessoa acesse, deixa so o set
    set { nome = value; } // caso nao queira permitir a alteraçao do atributo, deixa so o get
  }
}
 