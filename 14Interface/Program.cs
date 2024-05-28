namespace _14Interface;

class Program
{
    //Interface é utilizada para criar EXCLUSIVAMENTE métodos OBRIGATORIOS. Diferente da Abstracao, nao ha metodos opcionais, e pode ser implementada em varias classes.
    //Uma classe pode implementar varias interfaces
    // Os métodos da Interface nao contem cálculos, condicionais, laços e demais açoes;
    //No C# por padrao um metodo na Interface é abstrato e publico;
    //Nas boas práticas do C# toda interface tem incial I, em seguida o nome da interface
    //Ex: IPadrao, ICalculo, IConsulta;
    static void Main(string[] args)
    {
        Calculo c1 = new Calculo();
        c1.somar(5, 7);
        Calculo c2 = new Calculo();
        c2.subtrair(5, 7);
    }
}
