using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrinquedoNOVO
{
    public class Fabricante
    {

        public string Nome { get; set; }

        public string CNPJ { get; set; }

        public string NomeCNPJ
        {
            get
            {
                return Nome + " - " + CNPJ;
            }
        }



    }
}
