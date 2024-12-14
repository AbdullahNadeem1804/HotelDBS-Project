﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace Project
{
    public partial class Query4 : System.Web.UI.Page
    {
        protected void btnFetchGuests_Click(object sender, EventArgs e)
        {
            // Get the connection string from Web.config
            string connectionString = WebConfigurationManager.ConnectionStrings["DB_Project_CYA"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // SQL Query
                string query = @"
                    SELECT g.guest_first_name, g.guest_last_name, COUNT(b.booking_id) AS total_bookings
                    FROM guests g
                    LEFT JOIN bookings b ON g.guest_id = b.guests_guest_id
                    GROUP BY g.guest_id, g.guest_first_name, g.guest_last_name;
                ";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                try
                {
                    conn.Open(); // Open the database connection
                    da.Fill(dt); // Fill the data table
                    GridView4.DataSource = dt; // Set GridView's data source
                    GridView4.DataBind(); // Bind data to GridView
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