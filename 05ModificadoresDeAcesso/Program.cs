namespace _05ModificadoresDeAcesso;

class Program
{
    static void Main(string[] args)
    {
        //instanciando a classe Produto com o objeto produto1
        Produto produto1 = new Produto();
        produto1.nome = "Jack";
        /*produto1.valor = 50; Nao tem acesso ao valor ja que está com acesso privado*/
    }
}
