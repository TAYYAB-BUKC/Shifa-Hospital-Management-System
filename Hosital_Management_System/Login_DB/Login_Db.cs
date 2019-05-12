using System;
using System.Collections.Generic;
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
		public void Btn_Login(Bunifu.Framework.UI.BunifuMetroTextbox Email, Bunifu.Framework.UI.BunifuMetroTextbox Password, Form loginForm,Form mainForm)
		{
			if (Email.Text == "" || Password.Text == "")
			{
				MessageBox.Show("Please Fill the Fields First", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
			//login code goes here
			}
		}
	}
}
