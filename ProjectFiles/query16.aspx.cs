using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace Project
{
    public partial class Query16 : System.Web.UI.Page
    {
        protected void btnFetchBookings_Click(object sender, EventArgs e)
        {
            // Get the connection string from Web.config
            string connectionString = WebConfigurationManager.ConnectionStrings["DB_Project_CYA"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // SQL Query
                string query = @"
                    SELECT b.booking_id, g.guest_first_name, g.guest_last_name, rt.room_type_name
                    FROM bookings b
                    JOIN rooms_booked rb ON b.booking_id = rb.bookings_booking_id
                    JOIN rooms r ON rb.rooms_room_id = r.room_id
                    JOIN room_type rt ON r.rooms_type_rooms_type_id = rt.room_type_id
                    JOIN guests g ON b.guests_guest_id = g.guest_id
                    WHERE rt.pet_friendly = 1;
                ";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                try
                {
                    conn.Open(); // Open the database connection
                    da.Fill(dt); // Fill the data table
                    GridView16.DataSource = dt; // Set GridView's data source
                    GridView16.DataBind(); // Bind data to GridView
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
