//Segundo Arquivo Criado

using System;

class Pessoa
{


  //Atributos = características que o objeto pode ter. No caso Pessoa:
  public string? nome; // public = modificador de acesso (publicos, privado ou protegido)(aula05)
  //public indica que qualquer arquivo .cs vai ter acesso ao atributo ou método;
  // string? = O ponto de interrogacao indica que a variavel nome pode ser anulável
  public int idade; 

  // Metodos = Funcoes/açoes dentro das classes:
  public void mensagem() // void indica que nao há retorno. (retorno nulo ou vazio)
  {
    Console.WriteLine($"Olá {nome}, você tem {idade} anos");
  }
}