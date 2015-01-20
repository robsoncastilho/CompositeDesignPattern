using CompositeDesignPattern.Questionario;
using System;

namespace CompositeDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var blocoA = new Bloco("A) Formação Educacional");
            var questao1 = new Questao("Qual sua formação?");
            var questao2 = new Questao("Pretende fazer alguma pós-graduação?");

            blocoA.Adicionar(questao1);
            blocoA.Adicionar(questao2);

            var blocoB = new Bloco("B) Habilidades");
            var blocoB1 = new Bloco("B1) Habilidades Técnicas");
            var questao3 = new Questao("O que é SOLID?");

            blocoB1.Adicionar(questao3);
            blocoB.Adicionar(blocoB1);

            var blocoRaiz = new Bloco("Inicio");
            blocoRaiz.Adicionar(blocoA);
            blocoRaiz.Adicionar(blocoB);

            blocoRaiz.Exibir();

            Console.ReadKey();
        }
    }
}
