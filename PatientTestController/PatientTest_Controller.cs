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
namespace PatientTestController
{
    public class PatientTest_Controller
    {
        PatientTest_db patienttest_db = newPatientTest_db();

        public void Login(Bunifu.Framework.UI.BunifuMetroTextbox PatientEmail, Bunifu.Framework.UI.BunifuMetroTextbox DoctorEmail, Bunifu.Framework.UI.BunifuMetroTextbox TestDate, Bunifu.Framework.UI.BunifuMetroTextbox DeliveryDate, Bunifu.Framework.UI.BunifuMetroTextbox PaymentStatus, Form loginform, Form Mainform, string Role)
        {
            if (PatientEmail.Text == "" || DoctorEmail.Text == "" || TestDate.Text == "" || DeliveryDate.Text == "" || PaymentStatus.Text == "" || String.IsNullOrEmpty(Role))
            {
                MessageBox.Show("Please Fill the Fields First", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                patienttest_db.Btn_PatientTest(PatientEmail, DoctorEmail, TestDate, DeliveryDate,PaymentStatus, loginform, Mainform, Role);
            }
        }
    }
}
