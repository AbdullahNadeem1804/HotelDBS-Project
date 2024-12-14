using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace Project
{
    public partial class Query11 : System.Web.UI.Page
    {
        protected void btnFetchPopularService_Click(object sender, EventArgs e)
        {
            // Get the connection string from Web.config
            string connectionString = WebConfigurationManager.ConnectionStrings["DB_Project_CYA"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // SQL Query
                string query = @"
                    SELECT hs.service_name, COUNT(hug.service_used_id) AS times_used
                    FROM hotel_services hs
                    JOIN hotel_services_used_by_guests hug ON hs.service_id = hug.hotel_services_service_id
                    GROUP BY hs.service_name
                    ORDER BY COUNT(hug.service_used_id) DESC;
                ";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                try
                {
                    conn.Open(); // Open the database connection
                    da.Fill(dt); // Fill the data table
                    GridView11.DataSource = dt; // Set GridView's data source
                    GridView11.DataBind(); // Bind data to GridView
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
