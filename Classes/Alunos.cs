using System;

namespace Aluno
{
    public class Aluno
    {
        public string nome;

        public string curso;

        public int idade;

        public string rg;

        public bool bolsista;

        public double mediaFinal;

        public double valorDaMensalidade;

        public void VerMediaFinal(double media){
            Console.WriteLine($"A Média final do alune é: {media}");

        }

        public void VerMensalidade(bool bolsista, double mensalidade){
            if(bolsista == true){
                Console.WriteLine("Esse aluno é bolsista. ");
                Console.WriteLine($"Mensalidade sem desconto: {mensalidade}");

                Console.WriteLine($"Mensalidade com desconto: {0.7*mensalidade}");
                
            }else{
                Console.WriteLine("Esse aluno não é bolsista. ");
                Console.WriteLine($"Mensalidade {mensalidade}");
            }

        }
        
    }
}