using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Npgsql;
using System.Data;
using System.Configuration;
using System.Threading.Tasks;
using System.Text;
using System.Security.Cryptography;
using System.IO;

namespace records
{
    public partial class Records : System.Web.UI.Page
    {

        NpgsqlConnection conn = new NpgsqlConnection("Server = localhost; Port = 5432; Database = myordersystemdb; User Id = postgres; Password = 123;");
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public static string EncodePasswordToBase64(string password)
        {
            try
            {
                byte[] encData_byte = new byte[password.Length];
                encData_byte = System.Text.Encoding.UTF8.GetBytes(password);
                string encodedData = Convert.ToBase64String(encData_byte);
                return encodedData;
            }
            catch (Exception ex)
            {
                throw new Exception("Error in base64Encode" + ex.Message);
            }
        }

      

        protected void Button2_Click1(object sender, EventArgs e)
        {
            try
            {
                

                conn.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "Insert into records values(@id,@name,@last_name,@solary,@city,@social_security_number,@role,@email_address,@phone_number,@education,@address,@work_experience," +
                    "@financial_department,@sales_department,@administrative_department,@marketing_department,@technological_department,@communication_department,@password1)";
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add(new NpgsqlParameter("@id", Convert.ToInt32(TextBox1.Text)));
                    cmd.Parameters.Add(new NpgsqlParameter("@name", TextBox2.Text));
                    cmd.Parameters.Add(new NpgsqlParameter("@last_name", TextBox3.Text));
                    cmd.Parameters.Add(new NpgsqlParameter("@solary", Convert.ToInt32(TextBox4.Text)));
                    cmd.Parameters.Add(new NpgsqlParameter("@city", TextBox5.Text));
                    cmd.Parameters.Add(new NpgsqlParameter("@social_security_number", Convert.ToInt32(TextBox6.Text)));
                    cmd.Parameters.Add(new NpgsqlParameter("@role", Convert.ToInt32(TextBox7.Text)));
                    cmd.Parameters.Add(new NpgsqlParameter("@email_address", TextBox9.Text));
                    cmd.Parameters.Add(new NpgsqlParameter("@phone_number", TextBox10.Text));
                    cmd.Parameters.Add(new NpgsqlParameter("@education", TextBox11.Text));
                    cmd.Parameters.Add(new NpgsqlParameter("@address", TextBox12.Text));
                    cmd.Parameters.Add(new NpgsqlParameter("@work_experience", TextBox13.Text));
                    cmd.Parameters.Add(new NpgsqlParameter("@financial_department", CheckBox1.Checked));
                    cmd.Parameters.Add(new NpgsqlParameter("@sales_department", CheckBox2.Checked));
                    cmd.Parameters.Add(new NpgsqlParameter("@administrative_department", CheckBox3.Checked));
                    cmd.Parameters.Add(new NpgsqlParameter("@marketing_department", CheckBox4.Checked));
                    cmd.Parameters.Add(new NpgsqlParameter("@technological_department", CheckBox5.Checked));
                    cmd.Parameters.Add(new NpgsqlParameter("@communication_department", CheckBox6.Checked));
                    cmd.Parameters.Add(new NpgsqlParameter("@password1", EncodePasswordToBase64(TextBox8.Text)));




                cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    conn.Close();
                    TextBox1.Text = "";
                    TextBox2.Text = "";
                    TextBox3.Text = "";
                    TextBox4.Text = "";
                    TextBox5.Text = "";
                    TextBox6.Text = "";
                    TextBox7.Text = "";
                    TextBox8.Text = "";
                    TextBox9.Text = "";
                    TextBox10.Text = "";
                    TextBox11.Text = "";
                    TextBox12.Text = "";
                    TextBox13.Text = "";
                    CheckBox1.Checked = false;
                    CheckBox2.Checked = false;
                    CheckBox3.Checked = false;
                    CheckBox4.Checked = false;
                    CheckBox5.Checked = false;
                    CheckBox6.Checked = false;


                Label2.Text = "Record is added successfully";

            }
            catch (Exception ex) {

                Label2.Text = "Incorect type of Data";
            }
        }
    }
}