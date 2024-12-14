using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace Project
{
    public partial class Query7 : System.Web.UI.Page
    {
        protected void btnFetchRoomTypes_Click(object sender, EventArgs e)
        {
            // Get the connection string from Web.config
            string connectionString = WebConfigurationManager.ConnectionStrings["DB_Project_CYA"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // SQL Query
                string query = @"
                    SELECT h.hotel_name, rt.room_type_name, AVG(rt.room_cost) AS avg_cost
                    FROM hotel h
                    JOIN rooms r ON h.hotel_id = r.hotel_hotel_id
                    JOIN room_type rt ON r.rooms_type_rooms_type_id = rt.room_type_id
                    GROUP BY h.hotel_id, rt.room_type_id, h.hotel_name, rt.room_type_name;
                ";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                try
                {
                    conn.Open(); // Open the database connection
                    da.Fill(dt); // Fill the data table
                    GridView7.DataSource = dt; // Set GridView's data source
                    GridView7.DataBind(); // Bind data to GridView
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
