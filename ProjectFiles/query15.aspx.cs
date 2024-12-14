using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace Project
{
    public partial class Query15 : System.Web.UI.Page
    {
        protected void btnFetchHotels_Click(object sender, EventArgs e)
        {
            // Get the connection string from Web.config
            string connectionString = WebConfigurationManager.ConnectionStrings["DB_Project_CYA"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // SQL Query
                string query = @"
                    SELECT DISTINCT h.hotel_name
                    FROM hotel h
                    JOIN hotel_services hs ON h.hotel_id = hs.hotel_hotel_id
                    JOIN hotel_services_used_by_guests hug ON hs.service_id = hug.hotel_services_service_id
                    WHERE hs.service_name = 'Room Service';
                ";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                try
                {
                    conn.Open(); // Open the database connection
                    da.Fill(dt); // Fill the data table
                    GridView15.DataSource = dt; // Set GridView's data source
                    GridView15.DataBind(); // Bind data to GridView
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
