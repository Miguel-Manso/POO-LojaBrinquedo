using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrinquedoNOVO
{
    public class listaExecucao
    {
        private List<Brinquedo> listaBrinquedo = new List<Brinquedo>();

        public void Adicionar(Brinquedo brinquedo)
        {
            listaBrinquedo.Add(brinquedo);
        }

        public void Remover(Brinquedo brinquedo)
        {
            listaBrinquedo.Remove(brinquedo);
        }

        public List<Brinquedo> ListarBrinquedo()
        {
            return listaBrinquedo;
        }
    }
}
