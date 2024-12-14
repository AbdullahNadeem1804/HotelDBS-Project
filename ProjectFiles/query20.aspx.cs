using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace Project
{
    public partial class Query20 : System.Web.UI.Page
    {
        protected void btnFetchRooms_Click(object sender, EventArgs e)
        {
            // Get the connection string from Web.config
            string connectionString = WebConfigurationManager.ConnectionStrings["DB_Project_CYA"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // SQL Query
                string query = @"
                    SELECT DISTINCT r.room_number, g.guest_first_name, g.guest_last_name
                    FROM rooms r
                    JOIN rooms_booked rb ON r.room_id = rb.rooms_room_id
                    JOIN bookings b ON rb.bookings_booking_id = b.booking_id
                    JOIN guests g ON b.guests_guest_id = g.guest_id
                    WHERE g.guest_id IN (
                        SELECT g.guest_id
                        FROM guests g
                        JOIN bookings b ON g.guest_id = b.guests_guest_id
                        JOIN hotel_services_used_by_guests hug ON b.booking_id = hug.bookings_booking_id
                        GROUP BY g.guest_id
                        HAVING COUNT(DISTINCT hug.hotel_services_service_id) >= 2
                    );
                ";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                try
                {
                    conn.Open(); // Open the database connection
                    da.Fill(dt); // Fill the data table
                    GridView20.DataSource = dt; // Set GridView's data source
                    GridView20.DataBind(); // Bind data to GridView
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
