using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace Project
{
    public partial class Query8 : System.Web.UI.Page
    {
        protected void btnFetchEmployees_Click(object sender, EventArgs e)
        {
            // Get the connection string from Web.config
            string connectionString = WebConfigurationManager.ConnectionStrings["DB_Project_CYA"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // SQL Query
                string query = @"
                    SELECT e.emp_first_name, e.emp_last_name, h.hotel_name, a.city
                    FROM employees e
                    JOIN hotel h ON e.addresses_address_id = h.addresses_address_id
                    JOIN addresses a ON h.addresses_address_id = a.address_id
                    WHERE a.city = (
                        SELECT city 
                        FROM addresses 
                        WHERE address_id = e.addresses_address_id
                    );
                ";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                try
                {
                    conn.Open(); // Open the database connection
                    da.Fill(dt); // Fill the data table
                    GridView8.DataSource = dt; // Set GridView's data source
                    GridView8.DataBind(); // Bind data to GridView
                }
                catch (Exception ex)
                {
                    // Display an error message if something goes wrong
                    Response.Write($"<script>alert('Error: {ex.Message}');</script>");
                }
            }
        }
    }
}
