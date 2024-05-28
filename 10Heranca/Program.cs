namespace _10Heranca;

//Nao existe Heranca Multipla no Java, C# ou PHP. Cada classe so consegue herdar propriedades de 1 outra classe.
class Program
{
    static void Main(string[] args)
    {
        Colaborador col1 = new Colaborador("Henrique", 29, 5000, 3);
        Console.WriteLine(col1.GetType());
    }
}
