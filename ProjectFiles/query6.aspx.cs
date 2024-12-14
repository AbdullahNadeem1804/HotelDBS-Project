using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace Project
{
    public partial class Query6 : System.Web.UI.Page
    {
        protected void btnFetchDiscountedBookings_Click(object sender, EventArgs e)
        {
            // Get the connection string from Web.config
            string connectionString = WebConfigurationManager.ConnectionStrings["DB_Project_CYA"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // SQL Query
                string query = @"
                    SELECT b.booking_id, b.total_amount, d.discount_rate
                    FROM bookings b
                    JOIN rooms_booked rb ON b.booking_id = rb.bookings_booking_id
                    JOIN rooms r ON rb.rooms_room_id = r.room_id
                    JOIN room_type rt ON r.rooms_type_rooms_type_id = rt.room_type_id
                    JOIN room_rate_discount d ON rt.room_type_id = d.room_type_room_type_id
                    WHERE b.booking_date BETWEEN 
                          DATEADD(MONTH, -d.end_month, GETDATE())  
                          AND DATEADD(MONTH, -d.start_month, GETDATE());
                ";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                try
                {
                    conn.Open(); // Open the database connection
                    da.Fill(dt); // Fill the data table
                    GridView6.DataSource = dt; // Set GridView's data source
                    GridView6.DataBind(); // Bind data to GridView
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
