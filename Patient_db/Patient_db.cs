using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hosital_Management_System
{
    public class Patient_db
    {

        public static string con = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;

        public void Btn_Login(Bunifu.Framework.UI.BunifuMetroTextbox Email, Bunifu.Framework.UI.BunifuMetroTextbox Password, Form loginForm, Form mainForm, string Role)
        {
            try
            {
                SqlConnection sql = new SqlConnection(con);
                sql.Open();
                SqlCommand cmd = new SqlCommand("Patient", sql) { CommandType = CommandType.StoredProcedure };
                cmd.Parameters.AddWithValue("@FirstName", SqlDbType.VarChar).Value = Convert.ToString(Email.Text);
                cmd.Parameters.AddWithValue("@LastName", SqlDbType.VarChar).Value = Convert.ToString(Password.Text);
                cmd.Parameters.AddWithValue("@Gender", SqlDbType.VarChar).Value = Role;
                cmd.Parameters.AddWithValue("@BloodGroup", SqlDbType.VarChar).Value = Role;
                cmd.Parameters.AddWithValue("@BirthDate", SqlDbType.DateTime).Value = Role;
                cmd.Parameters.AddWithValue("@Phone", SqlDbType.VarChar).Value = Role;
                cmd.Parameters.AddWithValue("@Address", SqlDbType.VarChar).Value = Role;
                cmd.Parameters.AddWithValue("@Email", SqlDbType.VarChar).Value = Role;
                cmd.Parameters.AddWithValue("@Password", SqlDbType.VarChar).Value = Role;
                cmd.Parameters.AddWithValue("@Status", SqlDbType.VarChar).Value = Role;
                cmd.Parameters.AddWithValue("@picture", SqlDbType.Image).Value = Role;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    if (dt.Rows[0][10].ToString().Equals("Enable"))
                    {
                        if (Role.Equals("Patient"))
                        {
                            MessageBox.Show("Patient inserted Successfully...", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            sql.Close();
                            loginForm.Hide();
                            mainForm.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Your Account Credentials were expired.Please contact to the Administrator if you have any query.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                else
                {
                    MessageBox.Show("Check your Credentials!!!!!!!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }






       
        public static void Update(string regno, string procname, string name, string gender, string group, string birth, string contact, string address, string email, string pass, string status)
        {
            try
            {
                SqlConnection sql = new SqlConnection(con);
                sql.Open();
                SqlCommand cmd = new SqlCommand(procname, sql) { CommandType = CommandType.StoredProcedure };
                cmd.Parameters.AddWithValue("@FirstName", SqlDbType.VarChar).Value = regno;
                cmd.Parameters.AddWithValue("@LastName", SqlDbType.VarChar).Value = name;
                cmd.Parameters.AddWithValue("@Gender", SqlDbType.VarChar).Value = gender;
                cmd.Parameters.AddWithValue("@BloodGroup", SqlDbType.VarChar).Value = group;
                cmd.Parameters.AddWithValue("@BirthDate", SqlDbType.VarChar).Value = birth;
                cmd.Parameters.AddWithValue("@Phone", SqlDbType.VarChar).Value = email;
                cmd.Parameters.AddWithValue("@Address", SqlDbType.VarChar).Value = contact;
                cmd.Parameters.AddWithValue("@Email", SqlDbType.VarChar).Value = address;
                cmd.Parameters.AddWithValue("@Password", SqlDbType.Int).Value = email;
                cmd.Parameters.AddWithValue("@Status", SqlDbType.Int).Value = status;
                cmd.ExecuteNonQuery();
                Console.WriteLine("Query runs perfectly");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Query not runs perfectly");
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public static void Patient_Deletion(string regno, string name, string gender, string group, string birth, string contact, string address, string email, string pass, string status)
        {
            try
            {
                SqlConnection sql = new SqlConnection(con);
                sql.Open();
                SqlCommand cmd = new SqlCommand("Patient_Deletion", sql) { CommandType = CommandType.StoredProcedure };
                cmd.Parameters.AddWithValue("@FirstName", SqlDbType.VarChar).Value = regno;
                cmd.Parameters.AddWithValue("@LastName", SqlDbType.VarChar).Value = name;
                cmd.Parameters.AddWithValue("@Gender", SqlDbType.VarChar).Value = gender;
                cmd.Parameters.AddWithValue("@BloodGroup", SqlDbType.VarChar).Value = group;
                cmd.Parameters.AddWithValue("@BirthDate", SqlDbType.VarChar).Value = birth;
                cmd.Parameters.AddWithValue("@Phone", SqlDbType.VarChar).Value = contact;
                cmd.Parameters.AddWithValue("@Address", SqlDbType.VarChar).Value = address;
                cmd.Parameters.AddWithValue("@Email", SqlDbType.VarChar).Value = email;
                cmd.Parameters.AddWithValue("@Password", SqlDbType.VarChar).Value = pass;
                cmd.Parameters.AddWithValue("@Status", SqlDbType.VarChar).Value = status;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        public static void Patient_Edit(string regno, string name, string gender, string group, string birth, string contact, string address, string email, string pass, string status)
        {
            try
            {
                SqlConnection sql = new SqlConnection(con);
                sql.Open();
                SqlCommand cmd = new SqlCommand("Patient_Edit", sql) { CommandType = CommandType.StoredProcedure };
                cmd.Parameters.AddWithValue("@FirstName", SqlDbType.VarChar).Value = regno;
                cmd.Parameters.AddWithValue("@LastName", SqlDbType.VarChar).Value = name;
                cmd.Parameters.AddWithValue("@Gender", SqlDbType.VarChar).Value = gender;
                cmd.Parameters.AddWithValue("@BloodGroup", SqlDbType.VarChar).Value = group;
                cmd.Parameters.AddWithValue("@BirthDate", SqlDbType.VarChar).Value = birth;
                cmd.Parameters.AddWithValue("@Phone", SqlDbType.VarChar).Value = contact;
                cmd.Parameters.AddWithValue("@Address", SqlDbType.VarChar).Value = address;
                cmd.Parameters.AddWithValue("@Email", SqlDbType.VarChar).Value = email;
                cmd.Parameters.AddWithValue("@Password", SqlDbType.VarChar).Value = pass;
                cmd.Parameters.AddWithValue("@Status", SqlDbType.VarChar).Value = status;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

    }
}
