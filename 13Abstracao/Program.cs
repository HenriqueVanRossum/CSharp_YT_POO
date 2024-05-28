namespace _13Abstracao;

class Program
{
    // Utiliza a palavra reservada abstract na declaracao da classe;
    //Obrigatoriamente as classes abstratas 
    //Abstraçao é uma classe que pode conter métodos obrigatórios para todas as classes que a herdarem;
    // É possível criar métodos convencionais (não obrigatórios), para que as classes que herdem consigam utilizar;
    //Não é possivel instanciar uma classe abstrata, exemplo: Produto prod1 = new Produto(); --NAO PODE
    // Padrão utilizado em projetos com muitos desenvolvedores, pois garante uma estrutura pré-moldada com ações que podem ser realizadas;
    //Como é utilizada a herança, cada classe pode herdar APENAS UMA classe abstrata
    //class Produto : PadraoProduto > Ok
    //class Produto: PadraoProduto, CalculoImposto > Falha
    static void Main(string[] args)
    {
        PessoaFisica pf = new PessoaFisica();
        pf.taxaEmprestimo(1000);
        pf.calculoPoupanca(1000, 0.1);

        PessoaJuridica pj = new PessoaJuridica();
        pj.taxaEmprestimo(1000);
        pj.calculoPoupanca(1000, 0.2);
    }
}
