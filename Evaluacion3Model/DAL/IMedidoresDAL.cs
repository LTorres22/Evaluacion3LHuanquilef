using Evaluacion3Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion3Model.DAL
{
    public interface IMedidoresDAL
    {
        List<Medidor> ObtenerMedidores();

        void AgregarMedidor(Medidor medidor);

        void EliminarMedidor(int numero);

        List<Medidor> FiltrarMedidores(int tipoConsumo);
    }
}
