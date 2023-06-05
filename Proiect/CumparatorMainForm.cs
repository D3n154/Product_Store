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
    public partial class CumparatorMainForm : Form
    {
        public CumparatorMainForm()
        {
            InitializeComponent();
        }

        private void btnCreare_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Contul a fost creat cu succes!");
            txtEmailC.Text = string.Empty;
            txtParolaC.Text = string.Empty;
        }

        private void btnVizualizare_Click(object sender, EventArgs e)
        {
            lstVizualizare.Items.Clear();

            string[] lines = File.ReadAllLines("produse.txt");
            foreach (string line in lines)
            {
          
                string[] fields = line.Split(';');

                if (fields.Length >= 4)
                {
                    string nume = fields[1];
                    string pret = fields[2];
                    string vanzator = fields[3];
                    string descriere = fields[4];
                    string negociabil = fields[5];
                    if (fields[5].Trim() == "True")
                        negociabil = "negociabil";
                    else
                        negociabil = "nu este negociabil";

                    string produsText = $"{nume}; {pret}; {vanzator}; {descriere}; {negociabil}";
                    lstVizualizare.Items.Add(produsText);
                    
                }
            }
        }

        private void btnTrimite_Click(object sender, EventArgs e)
        {
            int idProdus = int.Parse(txtIdProdus.Text);
            string numeCumparator = txtNumeCumparator.Text;
            decimal pretPropus = decimal.Parse(txtPretPropus.Text);

            Oferta oferta = new Oferta(idProdus, numeCumparator, pretPropus);
            
            using (StreamWriter writer = new StreamWriter("oferte_asteptare.txt", true))
            {
                string ofertaText = $"{oferta.IdProdus}; {oferta.NumeCumparator}; {oferta.PretPropus}";

                writer.WriteLine(ofertaText);
            }

            MessageBox.Show("Oferta a fost trimisă cu succes!");

            txtIdProdus.Text = string.Empty;
            txtNumeCumparator.Text = string.Empty;
            txtPretPropus.Text = string.Empty;
        }

        private void btnVerificare_Click_1(object sender, EventArgs e)
        {
            if (lstProdCum.SelectedIndex != -1)
            {
                string produsSelectat = lstProdCum.SelectedItem.ToString();

                string[] produsParti = produsSelectat.Split(';');
                
                string numeProdus = produsParti[0].Trim();

                decimal pretProdus = decimal.Parse(produsParti[1].Trim());

                string numeCumparator = txtNumeCump.Text.Trim();

                if (string.IsNullOrEmpty(numeCumparator))
                {
                    MessageBox.Show("Introduceți numele cumpărătorului.");
                    return;
                }
                
                using (StreamWriter writer = new StreamWriter("asteptare.txt", true))
                {
                    writer.WriteLine($"{numeProdus}; {pretProdus}; {numeCumparator}");
                }

                lstProdCum.Items.RemoveAt(lstProdCum.SelectedIndex);

                MessageBox.Show("Produs trimis catre aprobare!");
            }
            else
            {
                MessageBox.Show("Selectati un produs din lista.");
            }

            txtNumeCump.Text = string.Empty;
        }

        private void CumparatorMainForm_Load(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines("produse.txt");

            foreach (string line in lines)
            {
                string[] fields = line.Split(';');
                
                if (fields.Length >= 6)
                {
                    string nume = fields[1]; 
                    string pret = fields[2];
                    string vanzator = fields[3];
                    string descriere = fields[4];
                    string negociabil = fields[5];
                    if (fields[5].Trim() == "True")
                        negociabil = "negociabil";
                    else
                        negociabil = "nu este negociabil";
                   
                    string produsText = $"{nume}; {pret}; {vanzator}; {descriere}; {negociabil}";
                    lstProdCum.Items.Add(produsText);
                }
            }
            string[] linii = File.ReadAllLines("prod_aprobate.txt");

            foreach (string linie in linii)
            {
                lstProdAprob.Items.Add(linie);
            }

            string[] produse = File.ReadAllLines("produse.txt");

            foreach (string produs in produse)
            {
                string[] fields = produs.Split(';');

                if (fields.Length >= 6 && fields[5].Trim().ToLower() == "true")
                {
                    string nume = fields[1].Trim();
                    string pret = fields[2].Trim();
                    string vanzator = fields[3].Trim();
                    string descriere = fields[4].Trim();

                    string produsText = $"{nume}; {pret}; {vanzator}; {descriere}";
                    lstProdNeg.Items.Add(produsText);
                }
            }

            string[] produseNeg = File.ReadAllLines("prodNeg_aprobate.txt");
            
            foreach (string produsNeg in produseNeg)
            {
                lstProdAprobNeg.Items.Add(produsNeg);
            }

        }

        private void btnCumparare_Click(object sender, EventArgs e)
        {
            if (lstProdAprob.SelectedIndex != -1)
            {
                string produsSelectat = lstProdAprob.SelectedItem.ToString();

                string[] produsParti = produsSelectat.Split(';');

                string numeProdus = produsParti[0].Trim();

                decimal pretProdus = decimal.Parse(produsParti[1].Trim());

                string numeCumparator = produsParti[2].Trim();

                using (StreamWriter writer = new StreamWriter("vanzari.txt", true))
                {
                    writer.WriteLine($"{numeProdus}; {pretProdus}; {numeCumparator}");
                }
            }
                MessageBox.Show("Cumpararea s-a realizat cu succes!");

            lstProdAprob.Items.RemoveAt(lstProdAprob.SelectedIndex);
        }

        private void btnVerificareNeg_Click(object sender, EventArgs e)
        {
            if (lstProdNeg.SelectedIndex != -1)
            {
                string produsSelectat = lstProdNeg.SelectedItem.ToString();
                string[] detaliiProdus = produsSelectat.Split(';');

                if (detaliiProdus.Length >= 2)
                {
                    string numeProdus = detaliiProdus[0].Trim();
                    string pretProdus = detaliiProdus[1].Trim();
                    string numeCumparator = txtCumparatorNeg.Text.Trim();
                    string pretPropus = txtPretNeg.Text.Trim();

                    if (!string.IsNullOrEmpty(numeCumparator) && !string.IsNullOrEmpty(pretPropus))
                    {
                        string detaliiVanzare = $"{numeProdus}; {pretProdus}; {numeCumparator}; {pretPropus}";

                        using (StreamWriter sw = File.AppendText("asteptare_neg.txt"))
                        {
                            sw.WriteLine(detaliiVanzare);
                        }

                        MessageBox.Show("Produsul a fost trimis pentru aprobare!");
                    }
                    else
                    {
                        MessageBox.Show("Vă rugăm completați toate câmpurile!");
                    }

                    lstProdNeg.Items.RemoveAt(lstProdNeg.SelectedIndex);
                    txtCumparatorNeg.Text = string.Empty;
                    txtPretNeg.Text = string.Empty;
                }
            }
        }

        private void btnCumparareNeg_Click(object sender, EventArgs e)
        {
            if (lstProdAprobNeg.SelectedIndex != -1)
            {
                string produsSelectat = lstProdAprobNeg.SelectedItem.ToString();

                string[] produsParti = produsSelectat.Split(';');

                string numeProdus = produsParti[0].Trim();

                decimal pretProdus = decimal.Parse(produsParti[1].Trim());

                string numeCumparator = produsParti[2].Trim();

                using (StreamWriter writer = new StreamWriter("vanzari.txt", true))
                {
                    writer.WriteLine($"{numeProdus}; {pretProdus}; {numeCumparator}");
                }
                MessageBox.Show("Cumpararea s-a realizat cu succes!");
            }

              lstProdAprobNeg.Items.RemoveAt(lstProdAprobNeg.SelectedIndex);
        }

        private void btnCauta_Click(object sender, EventArgs e)
        {
            string numeProdusCautat = txtProdusCautat.Text.Trim();

            if (!string.IsNullOrEmpty(numeProdusCautat))
            {
                string[] produse = File.ReadAllLines("produse.txt");

                foreach (string produs in produse)
                {
                    string[] detaliiProdus = produs.Split(';');

                    if (detaliiProdus.Length >= 5 && detaliiProdus[1].Trim() == numeProdusCautat)
                    {
                        string caracteristiciProdus= $"{detaliiProdus[1].Trim()}; {detaliiProdus[2].Trim()}; {detaliiProdus[3].Trim()}; {detaliiProdus[4].Trim()}";

                        txtProdusGasit.Text = caracteristiciProdus;
                        return;
                    }
                }

                MessageBox.Show("Produsul nu a fost găsit!");
            }
            else
            {
                MessageBox.Show("Vă rugăm introduceți numele produsului!");
            }
        }

        private void txtParolaC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; 

                MessageBox.Show("Introduceți doar litere și cifre!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtIdProdus_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; 

                MessageBox.Show("Introduceți doar cifre!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNumeCumparator_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; 

                MessageBox.Show("Introduceți doar litere!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPretPropus_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; 

                MessageBox.Show("Introduceți doar numere de tip real!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtProdusCautat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; 

                MessageBox.Show("Introduceți doar litere!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNumeCump_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; 

                MessageBox.Show("Introduceți doar litere!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCumparatorNeg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; 

                MessageBox.Show("Introduceți doar litere!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPretNeg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; 

                MessageBox.Show("Introduceți doar numere de tip real!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtEmailC_KeyPress(object sender, KeyPressEventArgs e)
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

 
    }
}
