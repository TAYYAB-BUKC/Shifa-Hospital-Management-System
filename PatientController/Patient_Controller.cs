using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hosital_Management_System
{
    class PatientController
    {
        public class Patient_Controller
        {
            Patient_db patient_Db = new Patient_db();

            public void Patient(Bunifu.Framework.UI.BunifuMetroTextbox FirstName, Bunifu.Framework.UI.BunifuMetroTextbox LastName, Bunifu.Framework.UI.BunifuMetroTextbox Gender, Bunifu.Framework.UI.BunifuMetroTextbox BloodGroup, Bunifu.Framework.UI.BunifuMetroTextbox BirthDate, Bunifu.Framework.UI.BunifuMetroTextbox Phone, Bunifu.Framework.UI.BunifuMetroTextbox Address, Bunifu.Framework.UI.BunifuMetroTextbox Email, Bunifu.Framework.UI.BunifuMetroTextbox Password, Bunifu.Framework.UI.BunifuMetroTextbox Status, Bunifu.Framework.UI.BunifuMetroTextbox Picture, Form loginform, Form Mainform, string Role)
            {
                if (FirstName.Text == "" || LastName.Text == "" || Gender.Text == "" || BloodGroup.Text == "" || BirthDate.Text == "" || Phone.Text == "" || Address.Text == "" || Email.Text == "" || Password.Text == "" || Status.Text == "" || Picture.Text == "" || String.IsNullOrEmpty(Role))
                {
                    MessageBox.Show("Please Fill the Fields First", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Patient_db.bunifuFlatButton20(FirstName, LastName, Gender, BloodGroup, BirthDate, Phone, Address, Email, Password, Status, Picture, loginform, Mainform, Role);
                }
            }
        }
    }
}
