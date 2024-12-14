using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace Project
{
    public partial class Query19 : System.Web.UI.Page
    {
        protected void btnFetchEmployees_Click(object sender, EventArgs e)
        {
            // Get the connection string from Web.config
            string connectionString = WebConfigurationManager.ConnectionStrings["DB_Project_CYA"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // SQL Query
                string query = @"
                    SELECT TOP 1 e.emp_first_name, e.emp_last_name, COUNT(b.booking_id) AS handled_bookings
                    FROM employees e
                    JOIN bookings b ON e.emp_id = b.employees_emp_id
                    GROUP BY e.emp_id, e.emp_first_name, e.emp_last_name
                    ORDER BY handled_bookings DESC;
                ";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                try
                {
                    conn.Open(); // Open the database connection
                    da.Fill(dt); // Fill the data table
                    GridView19.DataSource = dt; // Set GridView's data source
                    GridView19.DataBind(); // Bind data to GridView
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
