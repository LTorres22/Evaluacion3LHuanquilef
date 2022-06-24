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
    public partial class VerLecturas : System.Web.UI.Page
    {
        private IMedidoresDAL medidoresDAL = new MedidoresDALObjetos();
        private ILecturasDAL lecturasDAL = new LecturasDALObjetos();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.cargaGrilla();
            }
        }

        private void cargaGrilla()
        {
            List<Lectura> lecturas = this.lecturasDAL.ObtenerLecturas();
            this.grillaLecturas.DataSource = lecturas;
            this.grillaLecturas.DataBind();
        }

        private void cargaGrilla(List<Lectura> filtrada)
        {
            this.grillaLecturas.DataSource = filtrada;
            this.grillaLecturas.DataBind();
        }

        protected void grillaLecturas_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "eliminar")
            {
                string medidorLecturas = Convert.ToString(e.CommandArgument);
                lecturasDAL.EliminarLectura(medidorLecturas);
                cargaGrilla();
            }
        }
    }
}
