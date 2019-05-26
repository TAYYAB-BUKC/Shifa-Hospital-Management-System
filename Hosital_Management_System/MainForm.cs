using Hosital_Management_System.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Hosital_Management_System
{
    public partial class MainForm : Form
    {
        private bool isCollapsed;
		private string RoleCheck;

		public MainForm(string roleCheck)
		{
			InitializeComponent();
			RoleCheck = roleCheck;
			if (RoleCheck.Equals("Administrator"))
			{
				Pn_AddTest.Visible = false;
				Pn_Bed.Visible = false;
				Pn_BedAllotment.Visible = false;
				Pn_BedCategory.Visible = false;
				Pn_DoctorsSiteMap.Visible = false;
				Pn_EditAccountants.Visible = false;
				Pn_EditDoctor.Visible = false;
				Pn_EditLaboratories.Visible = false;
				Pn_EditNurse.Visible = false;
				Pn_EditPharmacist.Visible = false;
				Pn_ExpenseCategories.Visible = false;
				Pn_Expenses.Visible = false;
				Pn_Home.Visible = false;
				Pn_LaboratoristSiteMap.Visible = false;
				Pn_LabTest.Visible = false;
				Pn_LabTestCategories.Visible = false;
				Pn_ManageAccountants.Visible = false;
				Pn_ManageBedAllotment.Visible = false;
				Pn_ManageBedCategories.Visible = false;
				Pn_ManageBeds.Visible = false;
				Pn_ManageDoctor.Visible = false;
				Pn_ManageExpenseCategories.Visible = false;
				Pn_ManageExpenses.Visible = false;
				Pn_ManageLaboratories.Visible = false;
				Pn_ManageLabTest.Visible = false;
				Pn_ManageLabTestCatgories.Visible = false;
				Pn_ManageMedicineCategories.Visible = false;
				Pn_ManageMedicines.Visible = false;
				Pn_ManageNurses.Visible = false;
				Pn_ManagePatientTest.Visible = false;
				Pn_ManagePayment.Visible = false;
				Pn_ManagePaymentCategories.Visible = false;
				Pn_ManageProfile.Visible = false;
				Pn_Medicine.Visible = false;
				Pn_MedicineCategories.Visible = false;
				Pn_NursesSiteMap.Visible = false;
				Pn_PatientTest.Visible = false;
				Pn_Payment.Visible = false;
				Pn_PharmacistSiteMap.Visible = false;
				Pn_ManageLabTestCatgories.Visible = false;
				Pn_ManageMedicineCategories.Visible = false;
				Pn_ManageMedicines.Visible = false;
				Pn_Profile.Visible = false;
				Pn_AdminSiteMap.Visible = true;
				Pn_AdminSiteMap.Location = new Point(373, 53);
				Pn_AdminSiteMap.Size = new Size(929, 723);
			}
			else
			{

			}
		}

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            //panelleft.Height = btn_Dashboard.Height;
            //panelleft.Top = btn_Dashboard.Top;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                Btn_UserManagement.Iconimage_right = Resources.right1;

                panel_UserManagement.Height += 10;
                if (panel_UserManagement.Size == panel_UserManagement.MaximumSize)
                {
                    timer1.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                Btn_UserManagement.Iconimage_right = Resources.left;
                panel_UserManagement.Height -= 10;
                if (panel_UserManagement.Size == panel_UserManagement.MinimumSize)
                {
                    timer1.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
        }

        private void btn_Patient_Click(object sender, EventArgs e)
        {
           
        }

        private void Btn_UserManagement_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void bunifuFlatButton9_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void bunifuFlatButton24_Click(object sender, EventArgs e)
        {
            timer3.Start();
        }

        private void bunifuFlatButton19_Click(object sender, EventArgs e)
        {
            timer4.Start();
        }

        private void bunifuFlatButton14_Click(object sender, EventArgs e)
        {
            timer5.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                Btn_FinanceManagement.Iconimage_right = Resources.right1;

                panel_FinanceManagement.Height += 10;
                if (panel_FinanceManagement.Size == panel_FinanceManagement.MaximumSize)
                {
                    timer2.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                Btn_FinanceManagement.Iconimage_right = Resources.left;
                panel_FinanceManagement.Height -= 10;
                if (panel_FinanceManagement.Size == panel_FinanceManagement.MinimumSize)
                {
                    timer2.Stop();
                    isCollapsed = true;
                }
            }

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                Btn_MedicineManagement.Iconimage_right = Resources.right1;

                panel_MedicineManagement.Height += 10;
                if (panel_MedicineManagement.Size == panel_MedicineManagement.MaximumSize)
                {
                    timer3.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                Btn_MedicineManagement.Iconimage_right = Resources.left;
                panel_MedicineManagement.Height -= 10;
                if (panel_MedicineManagement.Size == panel_MedicineManagement.MinimumSize)
                {
                    timer3.Stop();
                    isCollapsed = true;
                }
            }


        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                Btn_BedManagement.Iconimage_right = Resources.right1;

                panel_BedManagement.Height += 10;
                if (panel_BedManagement.Size == panel_BedManagement.MaximumSize)
                {
                    timer4.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                Btn_BedManagement.Iconimage_right = Resources.left;
                panel_BedManagement.Height -= 10;
                if (panel_BedManagement.Size == panel_BedManagement.MinimumSize)
                {
                    timer4.Stop();
                    isCollapsed = true;
                }
            }


        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                Btn_LabManagement.Iconimage_right = Resources.right1;

                panel_LabManagement.Height += 10;
                if (panel_LabManagement.Size == panel_LabManagement.MaximumSize)
                {
                    timer5.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                Btn_LabManagement.Iconimage_right = Resources.left;
                panel_LabManagement.Height -= 10;
                if (panel_LabManagement.Size == panel_LabManagement.MinimumSize)
                {
                    timer5.Stop();
                    isCollapsed = true;
                }
            }


        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                Btn_Admin_Logout.Iconimage_right = Resources.right1;
                Pn_ManageProfile.Height += 10;
                if (Pn_ManageProfile.Size == Pn_ManageProfile.MaximumSize)
                {
                    timer6.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                Btn_Admin_Logout.Iconimage_right = Resources.left;
                Pn_ManageProfile.Height -= 10;
                if (Pn_ManageProfile.Size == Pn_ManageProfile.MinimumSize)
                {
                    timer6.Stop();
                    isCollapsed = true;
                }
            }


        }

        private void Btn_Admin_Logout_Click(object sender, EventArgs e)
        {
            timer6.Start();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btn_Admin_Logout_Click_1(object sender, EventArgs e)
        {
            timer6.Start();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void bunifuGradientPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton10_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton13_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton12_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton11_Click(object sender, EventArgs e)
        {

        }

        private void Btn_FinanceManagement_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void Btn_UserManagement_Click_1(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Btn_MedicineManagement_Click(object sender, EventArgs e)
        {
            timer3.Start();
        }

        private void Btn_BedManagement_Click(object sender, EventArgs e)
        {
            timer4.Start();

        }

        private void Btn_LabManagement_Click(object sender, EventArgs e)
        {
            timer5.Start();

        }

        private void Btn_Admin_Logout_Click_2(object sender, EventArgs e)
        {
            timer6.Start();
        }

        private void Btn_Admin_Logout_Click_3(object sender, EventArgs e)
        {
            timer6.Start();
        }

        private void panel36_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton20_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }

