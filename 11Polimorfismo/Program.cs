namespace _11Polimorfismo;

// A mesma classe pode operar de forma diferente de acordo com a forma que é instanciada. Poli: muitos Morfos: formas. Polimorfismo = uma classe mãe, como métodos que sao herdados entre as classes filhos. o Metodo da classe mae pode sofrer alteracao(palavra reservada virtual) pelos filhos que herdam essa classe (palavra reservada override)
// Neste exemplo, a classe Imposto tem o metodox() e o metodox1(),e todas as outas classes herdam a Classe Imposto. A classe Gerente tambem tem o metodox(), a classe Atendente tambem tem o metodox() e a classe Estagiario nao tem nenhum metodo proprio. O metodox() pode ter resultados diferentes entre o Gerente e o Atendente, ja que eles possuem o mesmo método que a classe imposto e podem sobrescrever esse método. Para isso, utiliza-se a palavra reservada "virtual" no metodox() da classe mae,indicando que ele pode sofrer alteraçao. Essa palavra reservada é inserida dentro da class Imposto, já que é ela a classe "mãe" que as outras classes herdam, e as classes que podem modificar esse método public virtual void metodox()(da class Imposto) devem possuir a palavra reservada override em sua declaracao, indicando que eles podem sobrescrever o metodo com a palavra reservada virtual. EX: public void override metodox()(Nas Classes Atendente e Gerente)
class Program
{
    static void Main(string[] args)
    {
        //Instanciar Estagirario
        //duas classes diferentes instanciando um objeto.
        //O objeto vai poder alterar e inserir metodos na classe Imposto
        Imposto objetoEstagiario = new Estagiario();
        Console.WriteLine(objetoEstagiario.GetType());
        objetoEstagiario.valeAlimentacao(1000);
        objetoEstagiario.valeTransporte(1000);
        Console.WriteLine("------------");

        //Instanciar Gerente 
        Imposto objetoGerente = new Gerente();
        Console.WriteLine(objetoGerente.GetType());
        objetoGerente.valeAlimentacao(1000);
        objetoGerente.valeTransporte(1000);
        Console.WriteLine("------------");

        //Instanciar Atentendente
        Imposto objetoAtendente = new Atendente();
        Console.WriteLine(objetoAtendente.GetType());
        objetoAtendente.valeAlimentacao(1000);
        objetoAtendente.valeTransporte(1000);
        Console.WriteLine("------------");
    }
}
