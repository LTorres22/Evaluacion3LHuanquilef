using Evaluacion3Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion3Model.DAL
{
    public interface ILecturasDAL
    {
        List<Lectura> ObtenerLecturas();

        void AgregarLectura(Lectura lectura);

        void EliminarLectura(string medidorLecturas);

        List<Lectura> FiltrarLecturas(string medidorLecturas);
    }
}
