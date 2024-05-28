using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// O this sempre se remete ao atributo da propria classe. Caso nao exista, ele faz referencia a um parametro

namespace _09This
{
    public class Pessoa
    {
        // Atributo
        private string nome = "Jack";

        // Construtor
        public Pessoa(string nome) // Com esse parametro, o Console.WriteLine imprime o argumento passado como argumento na chamada dessa classe. Se n tivesse um parametro, imprimiria o nome Jack.
        {
            Console.WriteLine(nome); // Retorna o argumento passado na chamada desse metodo pela class program
            Console.WriteLine(this.nome); // retorna o valor do atributo private this == "Jack"

        }

        public Pessoa()
        {
            Console.WriteLine("Outro construtor. Este nao tem parametro!");
        }
    }
}