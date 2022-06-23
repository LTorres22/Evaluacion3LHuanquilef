using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion3Model.DTO
{
    public class Lectura
    {
        private string medidorLecturas;
        private DateTime fechaLecturas;
        private int horaLecturas;
        private int minutosLecturas;
        private string consumoLecturas;

        public string MedidorLecturas { get => medidorLecturas; set => medidorLecturas = value; }
        public DateTime FechaLecturas { get => fechaLecturas; set => fechaLecturas = value; }
        public int HoraLecturas { get => horaLecturas; set => horaLecturas = value; }
        public int MinutosLecturas { get => minutosLecturas; set => minutosLecturas = value; }
        public string ConsumoLecturas { get => consumoLecturas; set => consumoLecturas = value; }
    }
}
