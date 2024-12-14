using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project
{
    public partial class Delete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // Get the ID from the TextBox
            string t1 = TextBox1.Text;

            // Connection string
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=DB_Project_CYA;Integrated Security=True;");

            try
            {
                conn.Open();

                // Delete query
                string query = "DELETE FROM addresses WHERE address_id = @id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", t1);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    // Record deleted successfully
                    Label1.Text = "Record deleted successfully!";
                    Label1.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    // No record found with the specified ID
                    Label1.Text = "Record not found!";
                    Label1.ForeColor = System.Drawing.Color.Red;
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions
                Label1.Text = "Error: " + ex.Message;
                Label1.ForeColor = System.Drawing.Color.Red;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}