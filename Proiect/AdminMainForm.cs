using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Proiect
{
    public partial class AdminMainForm : Form
    {
        string numeFisier = "vanzatori.txt";
        
        private List<string> vanzatori;

        public AdminMainForm()
        {
            InitializeComponent();
           
            vanzatori = new List<string>();
        }

        private void btnVerifica_Click(object sender, EventArgs e)
        {
            string numeVanzator = txtNumeVanzator.Text;

            if (vanzatori.Contains(numeVanzator))
            {
                MessageBox.Show("Vânzătorul există în sistem.");
            }
            else
            {
                MessageBox.Show("Vânzătorul nu există în sistem.");
            }
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            string numeVanzator = txtNumeVanzator.Text;

            if (!string.IsNullOrEmpty(numeVanzator))
            {
                vanzatori.Add(numeVanzator);
                File.AppendAllText(numeFisier, numeVanzator + Environment.NewLine);
                MessageBox.Show("Vânzătorul a fost adăugat cu succes.");
                txtNumeVanzator.Clear();
            }
            else
            {
                MessageBox.Show("Vă rugăm introduceți un nume de vânzător valid.");
            }
        }

        private void AdminMainForm_Load(object sender, EventArgs e)
        {

            if (File.Exists(numeFisier))
            {
                string[] linii = File.ReadAllLines(numeFisier);
                vanzatori.AddRange(linii);
            }
            else
            {
                MessageBox.Show("Fișierul cu vânzători nu există.");
            }
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; 

                MessageBox.Show("Introduceți doar litere!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      
    }
}
