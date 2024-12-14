using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project
{
    public partial class Insert : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=DB_Project_CYA;Integrated Security=True;");
            conn.Open();
            //INSERT INTO addresses (address_id, address_line1, address_line2, city, state, country, zipcode) 
            SqlCommand cm;
            string t1 = TextBox1.Text;
            string t2 = TextBox2.Text;
            string t3 = TextBox3.Text;
            string t4 = TextBox4.Text;
            string t5 = TextBox5.Text;
            string t6 = TextBox6.Text;
            string t7 = TextBox7.Text;
            string query = "INSERT INTO addresses (address_id, address_line1, address_line2, city, state, country, zipcode)  values ('" + t1 + "','" + t2 + "','" + t3 + "' ,'" + t4 + "' ,'" + t5 + "' , '" + t6 + "' , '" + t7 + "'   )";
            cm = new SqlCommand(query, conn);
            cm.ExecuteNonQuery();
            cm.Dispose();
            conn.Close();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=DB_Project_CYA;Integrated Security=True;");
            conn.Open();
            //INSERT INTO hotel_chain (hotel_chain_id, hotel_chain_name, hotel_chain_contact_number, hotel_chain_email_address, hotel_chain_website, hotel_chain_head_office_address_id) 
            SqlCommand cm;
            string t1 = TextBox8.Text;
            string t2 = TextBox9.Text;
            string t3 = TextBox10.Text;
            string t4 = TextBox11.Text;
            string t5 = TextBox12.Text;
            string t6 = TextBox13.Text;
            string query = "INSERT INTO hotel_chain (hotel_chain_id, hotel_chain_name, hotel_chain_contact_number, hotel_chain_email_address, hotel_chain_website, hotel_chain_head_office_address_id)  values ('" + t1 + "','" + t2 + "','" + t3 + "' ,'" + t4 + "' ,'" + t5 + "' , '" + t6 + "'   )";
            cm = new SqlCommand(query, conn);
            cm.ExecuteNonQuery();
            cm.Dispose();
            conn.Close();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=DB_Project_CYA;Integrated Security=True;");
            conn.Open();
            //INSERT INTO star_ratings (star_rating_id, star_rating_image)
            SqlCommand cm;
            string t1 = TextBox14.Text;
            string t2 = TextBox15.Text;
            string query = "INSERT INTO star_ratings (star_rating_id, star_rating_image)  values ('" + t1 + "','" + t2 + "')";
            cm = new SqlCommand(query, conn);
            cm.ExecuteNonQuery();
            cm.Dispose();
            conn.Close();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=DB_Project_CYA;Integrated Security=True;");
            conn.Open();
            //INSERT INTO hotel (hotel_id, hotel_name, hotel_contact_number, hotel_email_address, hotel_website, hotel_description, hotel_floor_count, hotel_room_capacity, hotel_chain_id, addresses_address_id, star_ratings_star_rating)
            SqlCommand cm;
            string t1 = TextBox16.Text;
            string t2 = TextBox17.Text;
            string t3 = TextBox18.Text;
            string t4 = TextBox19.Text;
            string t5 = TextBox20.Text;
            string t6 = TextBox21.Text;
            string t7 = TextBox22.Text;
            string t8 = TextBox23.Text;
            string t9 = TextBox24.Text;
            string t10 = TextBox25.Text;
            string t11 = TextBox26.Text;
            string query = "INSERT INTO hotel (hotel_id, hotel_name, hotel_contact_number, hotel_email_address, hotel_website, hotel_description, hotel_floor_count, hotel_room_capacity, hotel_chain_id, addresses_address_id, star_ratings_star_rating)  values ('" + t1 + "','" + t2 + "','" + t3 + "' ,'" + t4 + "' ,'" + t5 + "' , '" + t6 + "' , '" + t7 + "' , '" + t8 + "' , '" + t9 + "' , '" + t10 + "' , '" + t11 + "'  )";
            cm = new SqlCommand(query, conn);
            cm.ExecuteNonQuery();
            cm.Dispose();
            conn.Close();
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=DB_Project_CYA;Integrated Security=True;");
            conn.Open();
            //INSERT INTO hotel_services (service_id, service_name, service_description, service_cost, hotel_hotel_id)  
            SqlCommand cm;
            string t1 = TextBox27.Text;
            string t2 = TextBox28.Text;
            string t3 = TextBox29.Text;
            string t4 = TextBox30.Text;
            string t5 = TextBox31.Text;
            string query = "INSERT INTO hotel_services (service_id, service_name, service_description, service_cost, hotel_hotel_id)   values ('" + t1 + "','" + t2 + "','" + t3 + "' ,'" + t4 + "' ,'" + t5 + "'  )";
            cm = new SqlCommand(query, conn);
            cm.ExecuteNonQuery();
            cm.Dispose();
            conn.Close();
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=DB_Project_CYA;Integrated Security=True;");
            conn.Open();
            //INSERT INTO department (department_id, department_name, department_description)  
            SqlCommand cm;
            string t1 = TextBox32.Text;
            string t2 = TextBox33.Text;
            string t3 = TextBox34.Text;
            string query = "INSERT INTO department (department_id, department_name, department_description)   values ('" + t1 + "','" + t2 + "','" + t3 + "' )";
            cm = new SqlCommand(query, conn);
            cm.ExecuteNonQuery();
            cm.Dispose();
            conn.Close();
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=DB_Project_CYA;Integrated Security=True;");
            conn.Open();
            //INSERT INTO employees (emp_id, emp_first_name, emp_last_name, emp_designation, emp_address_id, emp_contact_number, emp_email_address, department_department_id, addresses_address_id)
            SqlCommand cm;
            string t1 = TextBox35.Text;
            string t2 = TextBox36.Text;
            string t3 = TextBox37.Text;
            string t4 = TextBox38.Text;
            string t5 = TextBox39.Text;
            string t6 = TextBox40.Text;
            string t7 = TextBox41.Text;
            string t8 = TextBox42.Text;
            string t9 = TextBox43.Text;
            string query = "INSERT INTO employees (emp_id, emp_first_name, emp_last_name, emp_designation, emp_address_id, emp_contact_number, emp_email_address, department_department_id, addresses_address_id)  values ('" + t1 + "','" + t2 + "','" + t3 + "' ,'" + t4 + "' ,'" + t5 + "' , '" + t6 + "' , '" + t7 + "' , '" + t8 + "' , '" + t9 + "' )";
            cm = new SqlCommand(query, conn);
            cm.ExecuteNonQuery();
            cm.Dispose();
            conn.Close();
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=DB_Project_CYA;Integrated Security=True;");
            conn.Open();
            //INSERT INTO room_type (room_type_id, room_type_name, room_cost, room_type_description, smoke_friendly, pet_friendly)  
            SqlCommand cm;
            string t1 = TextBox44.Text;
            string t2 = TextBox45.Text;
            string t3 = TextBox46.Text;
            string t4 = TextBox47.Text;
            string t5 = TextBox48.Text;
            string t6 = TextBox49.Text;
            string query = "INSERT INTO room_type (room_type_id, room_type_name, room_cost, room_type_description, smoke_friendly, pet_friendly)   values ('" + t1 + "','" + t2 + "','" + t3 + "' ,'" + t4 + "' ,'" + t5 + "' , '" + t6 + "'   )";
            cm = new SqlCommand(query, conn);
            cm.ExecuteNonQuery();
            cm.Dispose();
            conn.Close();
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=DB_Project_CYA;Integrated Security=True;");
            conn.Open();
            //INSERT INTO rooms (room_id, room_number, rooms_type_rooms_type_id, hotel_hotel_id)  
            SqlCommand cm;
            string t1 = TextBox50.Text;
            string t2 = TextBox51.Text;
            string t3 = TextBox52.Text;
            string t4 = TextBox53.Text;
            string query = "INSERT INTO rooms (room_id, room_number, rooms_type_rooms_type_id, hotel_hotel_id)   values ('" + t1 + "','" + t2 + "','" + t3 + "' ,'" + t4 + "')";
            cm = new SqlCommand(query, conn);
            cm.ExecuteNonQuery();
            cm.Dispose();
            conn.Close();
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=DB_Project_CYA;Integrated Security=True;");
            conn.Open();
            //INSERT INTO room_rate_discount (discount_id, discount_rate, start_month, end_month, room_type_room_type_id)  
            SqlCommand cm;
            string t1 = TextBox54.Text;
            string t2 = TextBox55.Text;
            string t3 = TextBox56.Text;
            string t4 = TextBox57.Text;
            string t5 = TextBox58.Text;
            string query = "INSERT INTO room_rate_discount (discount_id, discount_rate, start_month, end_month, room_type_room_type_id)   values ('" + t1 + "','" + t2 + "','" + t3 + "' ,'" + t4 + "' ,'" + t5 + "')";
            cm = new SqlCommand(query, conn);
            cm.ExecuteNonQuery();
            cm.Dispose();
            conn.Close();
        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=DB_Project_CYA;Integrated Security=True;");
            conn.Open();
            //INSERT INTO guests (guest_id, guest_first_name, guest_last_name, guest_contact_number, guest_email_address, guest_credit_card, addresses_address_id)
            SqlCommand cm;
            string t1 = TextBox59.Text;
            string t2 = TextBox60.Text;
            string t3 = TextBox61.Text;
            string t4 = TextBox62.Text;
            string t5 = TextBox63.Text;
            string t6 = TextBox64.Text;
            string t7 = TextBox65.Text;
            string query = "INSERT INTO guests (guest_id, guest_first_name, guest_last_name, guest_contact_number, guest_email_address, guest_credit_card, addresses_address_id)  values ('" + t1 + "','" + t2 + "','" + t3 + "' ,'" + t4 + "' ,'" + t5 + "' , '" + t6 + "' , '" + t7 + "' )";
            cm = new SqlCommand(query, conn);
            cm.ExecuteNonQuery();
            cm.Dispose();
            conn.Close();
        }

        protected void Button12_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=DB_Project_CYA;Integrated Security=True;");
            conn.Open();
            //INSERT INTO bookings (booking_id, booking_date, duration_of_stay, check_in_date, check_out_date, booking_payment_type, total_rooms_booked, hotel_hotel_id, guests_guest_id, employees_emp_id, total_amount)
            SqlCommand cm;
            string t1 = TextBox66.Text;
            string t2 = TextBox67.Text;
            string t3 = TextBox68.Text;
            string t4 = TextBox69.Text;
            string t5 = TextBox70.Text;
            string t6 = TextBox71.Text;
            string t7 = TextBox72.Text;
            string t8 = TextBox73.Text;
            string t9 = TextBox74.Text;
            string t10 = TextBox75.Text;
            string t11 = TextBox76.Text;
            string query = "INSERT INTO bookings (booking_id, booking_date, duration_of_stay, check_in_date, check_out_date, booking_payment_type, total_rooms_booked, hotel_hotel_id, guests_guest_id, employees_emp_id, total_amount)  values ('" + t1 + "','" + t2 + "','" + t3 + "' ,'" + t4 + "' ,'" + t5 + "' , '" + t6 + "' , '" + t7 + "' , '" + t8 + "' , '" + t9 + "' , '" + t10 + "' , '" + t11 + "'  )";
            cm = new SqlCommand(query, conn);
            cm.ExecuteNonQuery();
            cm.Dispose();
            conn.Close();
        }

        protected void Button13_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=DB_Project_CYA;Integrated Security=True;");
            conn.Open();
            //INSERT INTO rooms_booked (rooms_booked_id, bookings_booking_id, rooms_room_id)  
            SqlCommand cm;
            string t1 = TextBox77.Text;
            string t2 = TextBox78.Text;
            string t3 = TextBox79.Text;
            string query = "INSERT INTO rooms_booked (rooms_booked_id, bookings_booking_id, rooms_room_id)   values ('" + t1 + "','" + t2 + "','" + t3 + "')";
            cm = new SqlCommand(query, conn);
            cm.ExecuteNonQuery();
            cm.Dispose();
            conn.Close();
        }

        protected void Button14_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=DB_Project_CYA;Integrated Security=True;");
            conn.Open();
            //INSERT INTO hotel_services_used_by_guests (service_used_id, hotel_services_service_id, bookings_booking_id)
            SqlCommand cm;
            string t1 = TextBox80.Text;
            string t2 = TextBox81.Text;
            string t3 = TextBox82.Text;
            string query = "INSERT INTO hotel_services_used_by_guests (service_used_id, hotel_services_service_id, bookings_booking_id)   values ('" + t1 + "','" + t2 + "','" + t3 + "')";
            cm = new SqlCommand(query, conn);
            cm.ExecuteNonQuery();
            cm.Dispose();
            conn.Close();
        }

        protected void Button15_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=DB_Project_CYA;Integrated Security=True;");
            conn.Open();
            //INSERT INTO hotel_chain_has_hotel (hotel_chains_hotel_chain_id, hotels_hotel_id)
            SqlCommand cm;
            string t1 = TextBox82.Text;
            string t2 = TextBox83.Text;
            string query = "INSERT INTO hotel_chain_has_hotel (hotel_chains_hotel_chain_id, hotels_hotel_id)   values ('" + t1 + "','" + t2 + "')";
            cm = new SqlCommand(query, conn);
            cm.ExecuteNonQuery();
            cm.Dispose();
            conn.Close();
        }
    }
}