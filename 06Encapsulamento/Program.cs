namespace _06Encapsulamento;

class Program
{
    //O encsapsulamento serve para restringir a visibilidade dos metodos e atributos
    static void Main(string[] args)
    {
        Aluno aluno1 = new Aluno();
        //aluno1.nota1 = 0; -> Proibido pq está como privado. Só é acessado pelo metodo publico
        aluno1.mensagem();
    }
}
