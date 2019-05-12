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

		public void Login(Bunifu.Framework.UI.BunifuMetroTextbox email, Bunifu.Framework.UI.BunifuMetroTextbox password, Form loginform, Form Mainform)
		{
			logib_Db.Btn_Login(email, password, loginform, Mainform);
		}
	}
}
