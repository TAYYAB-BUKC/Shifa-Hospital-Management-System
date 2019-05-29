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

namespace PatientCheckup
{
    public class checkup_Controller
    {
        Patientcheckup_db logib_Db = new Patientcheckup_db();

        public void Login(Bunifu.Framework.UI.BunifuMetroTextbox PatientEmail, Bunifu.Framework.UI.BunifuMetroTextbox DoctorEmail,Bunifu.Framework.UI.BunifuMetroTextbox symptoms,Bunifu.Framework.UI.BunifuMetroTextbox diagnosis, Form loginform, Form Mainform, string Role)
        {
            if (PatientEmail.Text == "" || DoctorEmail.Text == "" || symptoms.Text == "" ||diagnosis.Text == "" || String.IsNullOrEmpty(Role))
            {
                MessageBox.Show("Please Fill the Fields First", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                logib_Db.Btn_Login(PatientEmail, DoctorEmail,symptoms,diagnosis, loginform, Mainform, Role);
            }
        }
    }
}
