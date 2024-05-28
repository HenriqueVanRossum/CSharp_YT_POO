//Primeiro Arquivo Criado


using System; //using importa funcionalidades. -- System é uma biblioteca padrao do C# que exibe ou armazena dados atraves do console

namespace _01Conceitos // É o nome da pasta que tem esse projeto. É possível ter outros arquivos com o nome Program.cs desde que esteja em outra pasta, e nao a 01Conceitos. Em alguns casos pode ser excluido que nao interfere no codigo. Normalmente em codigos pequenos, com poucos arquivos. 
{
    class Program  //Um molde para instanciar objetos.
    // Propriedades das classes: Podem ter métodos e Atributos. 
    {
      static void Main(string[] args) // Em todo projeto pode ter APENAS 1 static void main. Este é o método por onde o codigo SEMPRE começa a ser lido
      {
        // Depois de ter criado o arquivo Pessoa.cs, o objeto obj vai ser instanciado.
        Pessoa obj = new Pessoa(); // criando o objeto pessoa
        obj.nome = "Henrique"; // Nome é um atributo publico da classe Pessoa
        obj.idade = 29; // Idade é um atributo publico da classe Pessoa
        obj.mensagem();

      }


    }
}