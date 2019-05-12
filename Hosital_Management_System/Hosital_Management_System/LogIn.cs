using LoginController;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hosital_Management_System
{
    public partial class LogIn : Form
    {
		Login_Controller login_Controller = new Login_Controller();
        public LogIn()
        {
            InitializeComponent();

        }

		private void BunifuFlatButton_SignIn_Click(object sender, EventArgs e)
		{
			MainForm adminmainForm = new MainForm("Administrator");
			login_Controller.Login(BunifuMetroTextbox_Email,BunifuMetroTextbox_Password,this,adminmainForm,Convert.ToString(Cb_Role.SelectedItem));
		}
	}
}
