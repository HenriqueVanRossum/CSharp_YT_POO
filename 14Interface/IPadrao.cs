interface IPadrao
{
  void somar(int n1, int n2); // nao precisa definir a palavra abstract nem a palavra publico(por padrao é publico)
  void subtrair(int n1, int n2);// nao precisao das chaves(igual no abstract), ja que o cálculo é definido na classe que impplementa essa interface
}
