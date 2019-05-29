using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;

namespace PatientCheckup_db
{
    public class Patientcheckup_db
    {
        public static string con = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;

        public void Btn_CheckUp(Bunifu.Framework.UI.BunifuMetroTextbox PatientEmail, Bunifu.Framework.UI.BunifuMetroTextbox DoctorEmail,Bunifu.Framework.UI.BunifuMetroTextbox symptoms,Bunifu.Framework.UI.BunifuMetroTextbox diagnosis, Form loginForm, Form mainForm, string Role)
        {
            try
            {
                SqlConnection sql = new SqlConnection(con);
                sql.Open();
                SqlCommand cmd = new SqlCommand("PatientCheckUp", sql) { CommandType = CommandType.StoredProcedure };
                cmd.Parameters.AddWithValue("@Patient_Email", SqlDbType.VarChar).Value = Convert.ToString(PatientEmail.Text);
                cmd.Parameters.AddWithValue("@Doctor_Email", SqlDbType.VarChar).Value = Convert.ToString(DoctorEmail.Text);
                cmd.Parameters.AddWithValue("@Symptoms", SqlDbType.VarChar).Value = symptoms;
                cmd.Parameters.AddWithValue("@Diagnosis", SqlDbType.VarChar).Value = diagnosis;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    if (dt.Rows[0][6].ToString().Equals("Enable"))
                    {
                        if (Role.Equals("Administrator"))
                        {
                            MessageBox.Show("Logged In Successfully...", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            sql.Close();
                            loginForm.Hide();
                            mainForm.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Your Credentials were expired.Please contact to the Administrator if you have any query.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        public static void Update(string regno, string procname, string email, string symptoms, string diagnosis)
        {
            try
            {
                SqlConnection sql = new SqlConnection(con);
                sql.Open();
                SqlCommand cmd = new SqlCommand(procname, sql) { CommandType = CommandType.StoredProcedure };
                cmd.Parameters.AddWithValue("@Patient_Email", SqlDbType.VarChar).Value = regno;
                cmd.Parameters.AddWithValue("@Doctor_Email", SqlDbType.VarChar).Value = email;
                cmd.Parameters.AddWithValue("@Symptoms", SqlDbType.VarChar).Value = symptoms;
                cmd.Parameters.AddWithValue("@Diagnosis", SqlDbType.VarChar).Value = diagnosis;
                
                cmd.ExecuteNonQuery();
                Console.WriteLine("Query runs perfectly");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Query not runs perfectly");
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        public static void PatientCheckUp_Deletion(string patientemail, string doctoremail,string symptoms, string diagnosis)
        {
            try
            {
                SqlConnection sql = new SqlConnection(con);
                sql.Open();
                SqlCommand cmd = new SqlCommand("PatientCheckUp_Deletion", sql) { CommandType = CommandType.StoredProcedure };
                cmd.Parameters.AddWithValue("@PatientEmail", SqlDbType.VarChar).Value = patientemail;
                cmd.Parameters.AddWithValue("@DoctorEmail", SqlDbType.VarChar).Value = doctoremail;
                cmd.Parameters.AddWithValue("@Symptoms", SqlDbType.VarChar).Value = symptoms;
                cmd.Parameters.AddWithValue("@Diagnosis", SqlDbType.VarChar).Value = diagnosis;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public static void PatientCheckUp_Edit(string patientemail, string doctoremail, string symptoms, string diagnosis)
        {
            try
            {
                SqlConnection sql = new SqlConnection(con);
                sql.Open();
                SqlCommand cmd = new SqlCommand("PatientCheckUp_Edit", sql) { CommandType = CommandType.StoredProcedure };
                cmd.Parameters.AddWithValue("@PatientEmail", SqlDbType.VarChar).Value = patientemail;
                cmd.Parameters.AddWithValue("@DoctorEmail", SqlDbType.VarChar).Value = doctoremail;
                cmd.Parameters.AddWithValue("@Symptoms", SqlDbType.VarChar).Value = symptoms;
                cmd.Parameters.AddWithValue("@Diagnosis", SqlDbType.VarChar).Value = diagnosis;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

    }
}
