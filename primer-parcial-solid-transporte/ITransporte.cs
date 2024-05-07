using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primer_parcial_solid_transporte
{
    public interface ITransporte
    {
        void Acelerar(int velocidad);
        void Desacelerar(int velocidad);

        //viola el ISP y LSP. Se divide las interfaces según la necesidad.
    }
}
