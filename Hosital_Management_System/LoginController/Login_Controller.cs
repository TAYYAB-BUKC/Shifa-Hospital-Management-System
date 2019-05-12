using Login_DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginController
{
	public class Login_Controller
	{
		Login_Db logib_Db = new Login_Db();

		public void Login(Bunifu.Framework.UI.BunifuMetroTextbox Email, Bunifu.Framework.UI.BunifuMetroTextbox Password, Form loginform, Form Mainform,string Role)
		{
			if (Email.Text == "" || Password.Text == "" || String.IsNullOrEmpty(Role))
			{
				MessageBox.Show("Please Fill the Fields First", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				logib_Db.Btn_Login(Email, Password, loginform, Mainform, Role);
			}
		}
	}
}
