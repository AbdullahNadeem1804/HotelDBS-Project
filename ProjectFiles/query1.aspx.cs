using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace Project
{
    public partial class Query1 : System.Web.UI.Page
    {
        protected void btnExecuteQuery_Click(object sender, EventArgs e)
        {
            // Connection string from Web.config
            string connectionString = WebConfigurationManager.ConnectionStrings["DB_Project_CYA"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // SQL Query
                string query = @"
                    SELECT g.guest_first_name, g.guest_last_name, b.total_amount
                    FROM guests g
                    JOIN bookings b ON g.guest_id = b.guests_guest_id
                    WHERE DATEDIFF(day, b.check_in_date, b.check_out_date) > 2;
                ";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                try
                {
                    conn.Open();
                    da.Fill(dt);
                    GridView1.DataSource = dt;
                    GridView1.DataBind();
                }
                catch (Exception ex)
                {
                    // Handle exceptions (log or display an error message)
                    Response.Write($"<script>alert('Error: {ex.Message}');</script>");
                }
            }
        }
    }
}
