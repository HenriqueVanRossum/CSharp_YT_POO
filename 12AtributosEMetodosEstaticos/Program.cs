namespace _12AtributosEMetodosEstaticos;

class Program
{
    // Com metodos ou atributos estáticos é possível chamar os métodos e atributos de uma classe sem a necessidade de instanciar um objeto.
    //
    static void Main(string[] args)
    {
        Exemplo.soma(3, 4);
        Console.WriteLine("Olá, " + Exemplo.nome);
    }
}
