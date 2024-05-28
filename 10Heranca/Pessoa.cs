using System;

public class Pessoa
{
    protected string? nome; //protected = a propria classe e classes que herdam esse atributo têm acesso a esse atributo
    protected int? idade;
    //metodo
    protected void mensagemPessoa()
    {
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Idade: " + idade);
    }

}
