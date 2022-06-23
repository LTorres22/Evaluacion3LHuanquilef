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
    public partial class AgregarMedidor : System.Web.UI.Page
    {
        private IMedidoresDAL medidoresDAL = new MedidoresDALObjetos();
        private ILecturasDAL lecturasDAL = new LecturasDALObjetos();

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void agregarBtn_Click(object sender, EventArgs e)
        {
            //1. obtener los datos del formulario
            int numero = Convert.ToInt32(this.numeroTxt.Text.Trim());
            int tipoConsumo = Convert.ToInt32(this.tipoRb1.SelectedItem.Value);

            //2. construir el objeto de tipo medidor
            Medidor medidor = new Medidor()
            {
                Numero = numero,
                TipoConsumo = tipoConsumo,
            };
            //3. Llamar al DAL
            medidoresDAL.AgregarMedidor(medidor);
            //4. Mostrar mensaje de exito
            this.mensajeLb1.Text = "Medidor Ingresado";
            Response.Redirect("VerMedidores.aspx");
        }
    }
}