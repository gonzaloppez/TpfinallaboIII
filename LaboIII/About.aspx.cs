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
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
                    using (SqlConnection conexion = new SqlConnection("data source = localhost\\SQLEXPRESS; initial catalog = DBlaboIII; integrated security = sspi"))
                    {
                        SqlCommand cmd = new SqlCommand();
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.CommandText = "Select * from Carta";
                        cmd.Connection = conexion;
                        conexion.Open();
                        gvdPlatos.DataSource = cmd.ExecuteReader();
                        gvdPlatos.DataBind();
                    }
                
            }
        }

        
        public void GuardaPlato()
        {
            using (SqlConnection conexion = new SqlConnection("data source = localhost\\SQLEXPRESS; initial catalog = DBlaboIII; integrated security = sspi"))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Agregar_Plato";
                cmd.Parameters.Add("@ID", SqlDbType.SmallInt).Value = txtID.Text;
                cmd.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = txtNombre.Text.Trim();
                cmd.Parameters.Add("@precio", SqlDbType.Money).Value = txtPrecio.Text.Trim();
                cmd.Parameters.Add("@IDTipo_Plato", SqlDbType.TinyInt).Value = txtIDPlato.Text;
                cmd.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = txtDescripcion.Text.Trim();
                cmd.Parameters.Add("@Calorias", SqlDbType.SmallInt).Value = txtEmail.Text.Trim();

                cmd.Connection = conexion;
                conexion.Open();
                cmd.ExecuteNonQuery();
            }
        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            pnlPlatos.Visible = false;
            pnlAltaPlato.Visible = true;
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            pnlAltaPlato.Visible = true;
            pnlPlatos.Visible = false;
            GuardaPlato();
        }

    }
}