using System;

namespace CompositeDesignPattern.Questionario
{
    public class Questao : ElementoDoQuestionario
    {
        public Questao(string descricao) : base(descricao) { }

        public override void Exibir()
        {
            Console.WriteLine("Questão: {0}", Descricao);
        }
    }
}