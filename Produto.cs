using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrinquedoNOVO
{
    public class Produto
    {
        public string codBarra { get; set; }
        public string Descricao { get; set; }
        public string Preco { get; set; }
        public Fabricante Fabricante { get; set; }

        public string codBarraDescricao
        {
            get
            {
                return codBarra + "-" + Descricao;
            }

        }
    }
}
