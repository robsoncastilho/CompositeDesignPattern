using System.Collections.Generic;
using System.Linq;

namespace CompositeDesignPattern.Empresa
{
    public class Departamento : MembroDaEmpresa
    {
        private IList<MembroDaEmpresa> _membrosDaEmpresa = new List<MembroDaEmpresa>();
        public IEnumerable<MembroDaEmpresa> MembrosDaEmpresa { get { return _membrosDaEmpresa; } }

        public override decimal CalcularSalario()
        {
            return _membrosDaEmpresa.Sum(membro => membro.CalcularSalario());
        }
    }
}
