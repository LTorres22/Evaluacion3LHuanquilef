using Evaluacion3Model.DAL;
using Evaluacion3Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Evaluacion3Web
{
    public partial class AgregarLectura : System.Web.UI.Page
    {
        private IMedidoresDAL medidoresDAL = new MedidoresDALObjetos();
        private ILecturasDAL lecturasDAL = new LecturasDALObjetos();

        private List<Medidor> medidores1 = new List<Medidor>();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Medidor> medidores = medidoresDAL.ObtenerMedidores();
                this.medidorDd1.DataSource = medidores;
                this.medidorDd1.DataTextField = "numero";
                this.medidorDd1.DataValueField = "tipoTxt";
                this.medidorDd1.DataBind();

                this.medidores1 = medidores;
            }
        }

        protected void agregarBtn2_Click(object sender, EventArgs e)
        {
            string medidorLecturas = this.medidorDd1.SelectedValue.ToString();
            string fechaLecturas = this.Calendar1.SelectedDate.ToString();
            //DateTime fechaLecturas = DateTime.Now.ToString("yyyy-MM-dd");
            int horaLecturas = Convert.ToInt32(this.horaTxt.Text.Trim());
            int minutosLecturas = Convert.ToInt32(this.minutosTxt.Text.Trim());
            string consumoLecturas = this.consumoTxt.Text.Trim();

            string lecturaValor = this.medidorDd1.SelectedValue;
            int lecturaTexto = Convert.ToInt32(this.medidorDd1.SelectedItem.Text);

            List<Lectura> lecturas = lecturasDAL.ObtenerLecturas();
            Medidor medidor = this.medidores1.Find(b => b.Numero == lecturaTexto);

            List<Medidor> medidores = this.medidores1;
            Lectura lectura = new Lectura()
            {
                MedidorLecturas = medidorLecturas,
                FechaLecturas = fechaLecturas,
                HoraLecturas = horaLecturas,
                MinutosLecturas = minutosLecturas,
                ConsumoLecturas = consumoLecturas,
            };
            lecturasDAL.AgregarLectura(lectura);
            this.mensajeLb1.Text = "La Lectura ha sido registrada";
            Response.Redirect("VerLecturas.aspx");
        }
    }
}