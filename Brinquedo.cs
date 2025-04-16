using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrinquedoNOVO
{
    public class Brinquedo
    {
        public Produto Produto { get; set; }
        public Fabricante Fabricante { get; set; }
        public string Categoria { get; set; }
        public string idadeMinima { get; set; }

        public string codBarraDescricaoCategoria
        {
            get
            {
                return Produto.codBarra + "-" + Produto.Descricao + "-" + Categoria;
            }
        }

        public string codBarraDescricaoCategorianomeFabricante
        {
            get
            {
                return Produto.codBarraDescricao + " - " + Categoria + " - " + Fabricante.Nome;
            }
        }


    }
}
