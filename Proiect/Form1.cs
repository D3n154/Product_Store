using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Proiect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            cmbRole.Items.Add("Administrator");
            cmbRole.Items.Add("Vanzator");
            cmbRole.Items.Add("Cumparator");
        }

        private const string adminEmail = "admin@email.com";
        private const string adminPassword = "admin";

        public enum UserRole
        {
            Administrator,
            Vanzator,
            Cumparator
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            string selectedRole = cmbRole.SelectedItem?.ToString();

            if (selectedRole == "Administrator" && email == adminEmail && password == adminPassword)
            {
                MessageBox.Show("Autentificare reușită pentru administrator.", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OpenMainForm(UserRole.Administrator);
            }
            else if (selectedRole == "Vanzator" || selectedRole == "Cumparator")
            {
                MessageBox.Show("Autentificare reușită pentru " + selectedRole + ".", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OpenMainForm(selectedRole == "Vanzator" ? UserRole.Vanzator : UserRole.Cumparator);
            }
            else
            {
                MessageBox.Show("Email sau parolă incorectă.", "Eroare de autentificare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!IsValidEmailKeyPress(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Email-ul introdus nu este valid.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsValidEmailKeyPress(char keyChar)
        {
            if (char.IsLetterOrDigit(keyChar) || keyChar == '@' || keyChar == '.' || keyChar == '_' || keyChar == '-')
            {
                return true; 
            }

            return false; 
        }

        private void OpenMainForm(UserRole role)
        {
            switch (role)
            {
                case UserRole.Administrator:
                    AdminMainForm adminForm = new AdminMainForm();
                    adminForm.Show();
                    break;
                case UserRole.Vanzator:
                    VanzatorMainForm vanzatorForm = new VanzatorMainForm();
                    vanzatorForm.Show();
                    break;
                case UserRole.Cumparator:
                    CumparatorMainForm cumparatorForm = new CumparatorMainForm();
                    cumparatorForm.Show();
                    break;
            }

            this.Hide();
        }

        
    }
}
