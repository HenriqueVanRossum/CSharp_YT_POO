namespace _07Construtor;

/*Construtor é um método com o MESMO nome da classe que é executado assim que voce instancia um objeto dessa classe
Uma classe pode ter mais de 1 construtor, e dependendo de como voce instanciar essa classe, o construtor vai ser chamado.
Neste exemplo o construtor está escrevendo no terminal assim que o objeto é criado. Temos 2 Construtores*/
class Program
{
    static void Main(string[] args)
    {
        Pessoa p = new Pessoa();
        Pessoa p2 = new Pessoa("Henrique");

    }
}
