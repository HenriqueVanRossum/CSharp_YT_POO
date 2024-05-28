using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace _08GetSet;

/* 
    Set voce envia uma informacao para um atributo
    get voce pega uma informacao de um atributo
    Muito válido para o conceito de encapsulamento
    
*/
class Program
{
    static void Main(string[] args)
    {
        Pessoa p = new Pessoa();
        p.Nome = "Ralph";
        Console.WriteLine(p.Nome); // note que p. so tem acesso ao Nome, que é um atributo publico que tem o get, set,e nao o atributo nome que é privado
        //Se o get for removido, eu nao consigo acessar o valor desse atributo com o metodo get, mas se o set estiver presente,eu ainda consigo definir um valor ao atributo privado. 

        Personagem personagem1 = new Personagem();
        personagem1.Name = "Charizard";
        personagem1.Power = 500;
        personagem1.Defense = 200;

        Personagem personagem2 = new Personagem();
        personagem2.Name = "Pikachu";
        personagem2.Power = 700;
        personagem2.Defense = 200;

        personagem1.Life = personagem1.Life - (personagem2.Power - personagem1.Defense);

        Console.WriteLine($"Ataque do {personagem2.Name}: " + personagem2.Power + $"\nDefesa do {personagem1.Name}: {personagem2.Defense}");
        Console.WriteLine($"Dano causado: {personagem2.Power - personagem1.Defense}");
        Console.WriteLine($"Vida do {personagem1.Name}: {personagem1.Life}");



    }
}
