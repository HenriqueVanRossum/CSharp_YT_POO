using System;
using System.Reflection;
namespace _04ExercicioIMC;

class Program
{
    static void Main(string[] args)
    {
        Pessoa pessoa1 = new Pessoa();
        pessoa1.nome = "Henrique";
        pessoa1.altura = 1.79;
        pessoa1.peso = 85;
        pessoa1.mensagem();
    }
}
