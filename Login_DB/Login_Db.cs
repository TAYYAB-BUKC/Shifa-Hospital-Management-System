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

namespace Login_DB
{
	public class Login_Db
	{
		public static string con = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;

		public void Btn_Login(Bunifu.Framework.UI.BunifuMetroTextbox Email, Bunifu.Framework.UI.BunifuMetroTextbox Password, Form loginForm, Form mainForm, string Role)
		{
			try
			{
				SqlConnection sql = new SqlConnection(con);
				sql.Open();
				SqlCommand cmd = new SqlCommand("Login", sql) { CommandType = CommandType.StoredProcedure };
				cmd.Parameters.AddWithValue("@Email", SqlDbType.VarChar).Value = Convert.ToString(Email.Text);
				cmd.Parameters.AddWithValue("@Password", SqlDbType.VarChar).Value = Convert.ToString(Password.Text);
				cmd.Parameters.AddWithValue("@Role", SqlDbType.VarChar).Value = Role;
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
	}
}