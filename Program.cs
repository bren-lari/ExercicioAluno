using System;

namespace Aluno
{
        class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Aluno Aluno1 = new Aluno();

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("Digite o nome do aluno: ");
           
            Console.ForegroundColor = ConsoleColor.Yellow;
            Aluno1.nome = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("Insira o nome do curso: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Aluno1.curso = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("Insira a idade do aluno: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Aluno1.idade = int.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("Insira o RG do aluno: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Aluno1.rg = Console.ReadLine();


            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("O aluno é bolsista: (Sim ou Não) ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            string resposta = Console.ReadLine();

            if(resposta == "Sim") {
                Aluno1.bolsista = true;


            }else if(resposta == "Não") {
                Aluno1.bolsista = false;
            }



            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("Insira a média do aluno: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Aluno1.mediaFinal = double.Parse(Console.ReadLine());


            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("Insira o valor da mensalidade: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Aluno1.valorDaMensalidade = double.Parse(Console.ReadLine());


            Console.WriteLine(Aluno1.nome);
            Console.WriteLine(Aluno1.curso);
            Console.WriteLine(Aluno1.idade);
            Console.WriteLine(Aluno1.rg);
            Console.WriteLine(Aluno1.bolsista);
            // Console.WriteLine(Aluno1.mediaFinal);
            // Console.WriteLine(Aluno1.valorDaMensalidade);

            Aluno1.VerMediaFinal(Aluno1.mediaFinal);
            Aluno1.VerMensalidade(Aluno1.bolsista, Aluno1.valorDaMensalidade);



        }
    }
}
