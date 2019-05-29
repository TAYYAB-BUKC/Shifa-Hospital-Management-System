using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatientTest_db
{
    public class PatientTest_db
    {
        public static string con = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;
        public static void Insert(string patientemail, string procname, string doctoremail, string testdate, string deliverydate, string paymentstatus)
        {
            try
            {
                SqlConnection sql = new SqlConnection(con);
                sql.Open();
                SqlCommand cmd = new SqlCommand(procname, sql) { CommandType = CommandType.StoredProcedure };
                cmd.Parameters.AddWithValue("@Patient_Email", SqlDbType.VarChar).Value = patientemail;
                cmd.Parameters.AddWithValue("@Doctor_Email", SqlDbType.VarChar).Value = doctoremail;
                cmd.Parameters.AddWithValue("@TestDate", SqlDbType.DateTime).Value = testdate;
                cmd.Parameters.AddWithValue("@DeliveryDate", SqlDbType.DateTime).Value = deliverydate;
                cmd.Parameters.AddWithValue("@Payment_Status", SqlDbType.VarChar).Value = paymentstatus;
                
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public static void Update(string patientemail, string procname, string doctoremail, string testdate, string deliverydate, string paymentstatus)
        {
            try
            {
                SqlConnection sql = new SqlConnection(con);
                sql.Open();
                SqlCommand cmd = new SqlCommand(procname, sql) { CommandType = CommandType.StoredProcedure };
                cmd.Parameters.AddWithValue("@Patient_Email", SqlDbType.VarChar).Value = patientemail;
                cmd.Parameters.AddWithValue("@Doctor_Email", SqlDbType.VarChar).Value = doctoremail;
                cmd.Parameters.AddWithValue("@TestDate", SqlDbType.VarChar).Value = testdate;
                cmd.Parameters.AddWithValue("@DeliveryDate", SqlDbType.VarChar).Value = deliverydate;
                cmd.Parameters.AddWithValue("@Payment_Status", SqlDbType.VarChar).Value = paymentstatus;
                
                cmd.ExecuteNonQuery();
                Console.WriteLine("Query runs perfectly");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Query not runs perfectly");
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public static void Faculty_Deletion(string patientemail, string procname, string doctoremail, string testdate, string deliverydate, string paymentstatus)
        {
            try
            {
                SqlConnection sql = new SqlConnection(con);
                sql.Open();
                SqlCommand cmd = new SqlCommand("Faculty_Deletion", sql) { CommandType = CommandType.StoredProcedure };
                cmd.Parameters.AddWithValue("@Patient_Email", SqlDbType.VarChar).Value = patientemail;
                cmd.Parameters.AddWithValue("@Doctor_Email", SqlDbType.VarChar).Value = doctoremail;
                cmd.Parameters.AddWithValue("@TestDate", SqlDbType.DateTime).Value = testdate;
                cmd.Parameters.AddWithValue("@DeliveryDate", SqlDbType.DateTime).Value = deliverydate;
                cmd.Parameters.AddWithValue("@Payment_Status", SqlDbType.VarChar).Value = paymentstatus;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        public static void PatientTest_Edit(string patientemail, string procname, string doctoremail, string testdate, string deliverydate, string paymentstatus)
        {
            try
            {
                SqlConnection sql = new SqlConnection(con);
                sql.Open();
                SqlCommand cmd = new SqlCommand("PatientTest_Edit", sql) { CommandType = CommandType.StoredProcedure };
                cmd.Parameters.AddWithValue("@Patient_Email", SqlDbType.VarChar).Value = patientemail;
                cmd.Parameters.AddWithValue("@Doctor_Email", SqlDbType.VarChar).Value =doctoremail;
                cmd.Parameters.AddWithValue("@TestDate", SqlDbType.DateTime).Value = testdate;
                cmd.Parameters.AddWithValue("@DeliveryDate", SqlDbType.DateTime).Value = deliverydate;
                cmd.Parameters.AddWithValue("@Payment_Status", SqlDbType.VarChar).Value = paymentstatus;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
