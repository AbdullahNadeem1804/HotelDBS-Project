using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace Project
{
    public partial class Query10 : System.Web.UI.Page
    {
        protected void btnFetchRooms_Click(object sender, EventArgs e)
        {
            // Get the connection string from Web.config
            string connectionString = WebConfigurationManager.ConnectionStrings["DB_Project_CYA"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // SQL Query
                string query = @"
                    SELECT r.room_number, COUNT(rb.rooms_booked_id) AS times_booked
                    FROM rooms r
                    JOIN rooms_booked rb ON r.room_id = rb.rooms_room_id
                    GROUP BY r.room_id, r.room_number
                    HAVING COUNT(rb.rooms_booked_id) > 1;
                ";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                try
                {
                    conn.Open(); // Open the database connection
                    da.Fill(dt); // Fill the data table
                    GridView10.DataSource = dt; // Set GridView's data source
                    GridView10.DataBind(); // Bind data to GridView
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
