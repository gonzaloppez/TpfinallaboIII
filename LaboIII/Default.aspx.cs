using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace LaboIII
{
    public partial class _Default : Page
    {
        public void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                using (SqlConnection conexion = new SqlConnection("data source = localhost\\SQLEXPRESS; initial catalog = DBlaboIII; integrated security = sspi"))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = "select * from total_PlatosPedido";
                    cmd.Connection = conexion;
                    conexion.Open();
                    gvdPedidos.DataSource = cmd.ExecuteReader();
                    gvdPedidos.DataBind();
                }

            }
        }

        protected void btnAceptar(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtIDPlato.Text);
            consultarPlato(id);
        }

        public void consultarPlato(int id)
        {
           
            using (SqlConnection conexion = new SqlConnection("data source = localhost\\SQLEXPRESS; initial catalog = DBlaboIII; integrated security = sspi"))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_totalPorPlatoXPedido";
                cmd.Parameters.Add("@IDPlato", SqlDbType.BigInt).Value = txtIDPlato.Text;
                cmd.Connection = conexion;
                conexion.Open();
                gvdRecaudacionPorPlato.DataSource = cmd.ExecuteReader();
                gvdRecaudacionPorPlato.DataBind();
                
            }
            

        }
    }
}