using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion3Model.DTO
{
    public class Medidor
    {
        private int numero;        
        private int tipoConsumo;
        private List<Lectura> lecturas = new List<Lectura>();

        public string TipoTxt
        {
            get
            {                
                string tipoTxt = "";
                switch (tipoConsumo)
                {
                    case 1:
                        tipoTxt = "Análogo";
                        break;
                    case 2:
                        tipoTxt = "Digital";
                        break;
                }
                return tipoTxt;
            }
        }
        public int Numero { get => numero; set => numero = value; }
        public int TipoConsumo { get => tipoConsumo; set => tipoConsumo = value; }
        public List<Lectura> Lecturas { get => lecturas; set => lecturas = value; }
    }
}