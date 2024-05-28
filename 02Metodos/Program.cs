namespace _02Metodos;

class Program
{
    static void Main(string[] args)
    {
        Pessoa objetoPessoa = new Pessoa();
        objetoPessoa.apresentar(); // Chamou o primeiro metodo já que nao foi informado nenhum parametro
        objetoPessoa.apresentar("Jack"); //chamou o segundo metodo ja que ele foi definido com apenas 1 parametro
        objetoPessoa.apresentar("Cintia", 30); // chamou o terceiro metodo, ja que ele foi definido com 2 parametros.
        //Dessa forma é possivel entender que podem haver metodos com o mesmo nome numa mesma classe, desde que eles tenham paramtros diferentes
    }
}
