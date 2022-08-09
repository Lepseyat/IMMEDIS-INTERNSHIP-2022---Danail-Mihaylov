using Npgsql;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace records
{
    public partial class Login : System.Web.UI.Page
    {
        
        string str, name, password;
        NpgsqlCommand com;
        NpgsqlDataAdapter sqlda;
        DataTable dt;
        int RowCount;

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

        

        protected void Button1_Click(object sender, EventArgs e)
        {

        
            conn.Open();
            str = "Select * from public.records";
            com = new NpgsqlCommand(str);
            sqlda = new NpgsqlDataAdapter(com.CommandText, conn);
            dt = new DataTable();
            sqlda.Fill(dt);
            com.CommandType = CommandType.StoredProcedure;
            
            RowCount = dt.Rows.Count;
            for (int i = 0; i < RowCount; i++)
            {
                name = dt.Rows[i]["name"].ToString();
                password = dt.Rows[i]["password1"].ToString();
                


                if (name == TextBox1.Text && password == EncodePasswordToBase64(TextBox2.Text))
                {
                    Session["name"] = name;
                    if (dt.Rows[i]["role"].ToString() == "1")
                        Response.Redirect("AdminPage.aspx");
                    else if (dt.Rows[i]["role"].ToString() == "2")
                        Response.Redirect("Records.aspx");
                    
                }
                else
                {
                    lblErrorMessage.Visible = true;
                }
            }
        }
    }
}