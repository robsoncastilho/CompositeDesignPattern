
namespace CompositeDesignPattern.Questionario
{
    public abstract class ElementoDoQuestionario
    {
        protected string Descricao;

        protected ElementoDoQuestionario(string descricao)
        {
            Descricao = descricao;
        }

        public abstract void Exibir();
    }
}
