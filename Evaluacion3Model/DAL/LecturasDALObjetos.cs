using Evaluacion3Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion3Model.DAL
{
    public class LecturasDALObjetos : ILecturasDAL
    {
        private static List<Lectura> lecturas = new List<Lectura>();
        public void AgregarLectura(Lectura lectura)
        {
            Medidor medidor = new Medidor();
            lecturas.Add(lectura);
        }

        public void EliminarLectura(string medidorLecturas)
        {
            Lectura eliminado = lecturas.Find(c => c.MedidorLecturas == medidorLecturas);
            lecturas.Remove(eliminado);
        }

        public List<Lectura> FiltrarLecturas(string medidorLecturas)
        {
            return lecturas.FindAll(c => c.MedidorLecturas == medidorLecturas);
        }

        public List<Lectura> ObtenerLecturas()
        {
            return lecturas;
        }
    }
}