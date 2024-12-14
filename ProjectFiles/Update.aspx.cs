using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project
{
    public partial class Update : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string t1 = TextBox1.Text;
            string t2 = TextBox2.Text;
            string t3 = TextBox3.Text;
            string t4 = TextBox4.Text;
            string t5 = TextBox5.Text;
            string t6 = TextBox6.Text;
            string t7 = TextBox7.Text;

            // Connection string
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=DB_Project_CYA;Integrated Security=True;");

            try
            {
                conn.Open();

                // Update query
                string query = "UPDATE addresses SET address_line1 = @a1, address_line2 = @a2, city =@c , state = @s , country = @cou, zipcode = @z WHERE address_id = @id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", t1);
                cmd.Parameters.AddWithValue("@a1", t2);
                cmd.Parameters.AddWithValue("@a2", t3);
                cmd.Parameters.AddWithValue("@c", t4);
                cmd.Parameters.AddWithValue("@s", t5);
                cmd.Parameters.AddWithValue("@cou", t6);
                cmd.Parameters.AddWithValue("@z", t7);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    // Record updated successfully
                    Label1.Text = "Car status updated successfully!";
                }
                else
                {
                    // No record found with the specified ID
                    Label1.Text = "Car ID not found!";
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log error, show message)
                Label1.Text = "Error: " + ex.Message;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}