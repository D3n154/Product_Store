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
    public partial class VanzatorMainForm : Form
    {
        private const string filePath = "produse.txt"; 

        public VanzatorMainForm()
        {
            InitializeComponent();
            chkNegociabil.CheckedChanged += chkNegociabil_CheckedChanged;
            LoadProduse();
        }

        private void btnAprobare_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cererea a fost trimisă cu succes!", "Cerere trimisă", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBoxEmail.Text = string.Empty;
            textBoxParola.Text = string.Empty;
        }

        private void VanzatorMainForm_Load(object sender, EventArgs e)
        {
            string filePath = "oferte_asteptare.txt"; 

            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);

                foreach (string line in lines)
                {
                    listBoxOferte.Items.Add(line);
                }
            }

           

            string[] produse = File.ReadAllLines("asteptare.txt");

            foreach (string produs in produse)
            {
                lstAprobareProd.Items.Add(produs);
            }

            string[] produseNeg = File.ReadAllLines("asteptare_neg.txt");
            
            foreach (string produsNeg in produseNeg)
            {
                lstAprobareProdNeg.Items.Add(produsNeg);
            }
        }

        private void btnVanzare_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            string nume = C.Text;
            decimal pret = decimal.Parse(txtPret.Text);
            string vanzator = txtVanzator.Text;
            string descriere = txtDescriere.Text;
            bool esteNegociabil = chkNegociabil.Checked;
            decimal pretMinim = 0;

            if (!string.IsNullOrEmpty(txtPretMin.Text))
            {
                pretMinim = decimal.Parse(txtPretMin.Text);
            }

            Produs produs = new Produs(id, nume, pret, vanzator, descriere, esteNegociabil, pretMinim);

            SaveProdus(produs);

            txtID.Text = string.Empty;
            C.Text = string.Empty;
            txtPret.Text = string.Empty;
            txtVanzator.Text = string.Empty;
            txtDescriere.Text = string.Empty;
            chkNegociabil.Checked = false;
            txtPretMin.Text = string.Empty;
        }

        private void chkNegociabil_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNegociabil.Checked)
            {
                txtPretMin.Enabled = true;
            }
            else
            {
                txtPretMin.Enabled = false;
                txtPretMin.Text = string.Empty; 
            }
        }

        private void SaveProdus(Produs produs)
        {
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                string produsText = $"{produs.Id}; {produs.Nume}; {produs.Pret}; {produs.Vanzator}; {produs.Descriere}; {produs.EsteNegociabil}; {produs.PretMinim}";
                writer.WriteLine(produsText);
            }

            string negociabilText = produs.EsteNegociabil ? "negociabil" : "nu este negociabil";
            string produsTextListBox = $"{produs.Id}, {produs.Nume}; {produs.Pret}; {produs.Vanzator}; {produs.Descriere}; {negociabilText};  {produs.PretMinim}";
            lstProduse.Items.Add(produsTextListBox);
           
            MessageBox.Show("Produsul a fost pus la vânzare.");
            
        }
        private int ExtractIdFromText(string text)
        {
            int punctuationIndex = text.IndexOfAny(new char[] { ';' });

            if (punctuationIndex != -1)
            {
                string idText = text.Substring(0, punctuationIndex).Trim();
                
                if (int.TryParse(idText, out int id))
                {
                    return id;
                }
            }
  
            return -1;
        }
        private void btnAnulare_Click(object sender, EventArgs e)
        {
            if (lstProduse.SelectedItem != null)
            {
                string selectedText = lstProduse.SelectedItem.ToString();

                int id = ExtractIdFromText(selectedText);

                if (id != -1)
                {
                    RemoveProdus(id);

                    MessageBox.Show("Produsul a fost șters.");
                }
                else
                {
                    MessageBox.Show("Eroare: Produsul selectat nu are un Id valid.");
                }
            }
            else
            {
                MessageBox.Show("Selectați un produs pentru a-l șterge.");
            }
        }

        private void RemoveProdus(int id)
        {
            string[] lines = File.ReadAllLines(filePath);
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (string line in lines)
                {
                    string[] fields = line.Split(';');
                    
                    if (fields.Length >= 1 && int.TryParse(fields[0].Trim(), out int produsId) && produsId == id)
                    {
                        continue;
                    }
                    
                    writer.WriteLine(line);
                }
            }
            
            lstProduse.Items.RemoveAt(lstProduse.SelectedIndex);
        }

        private void LoadProduse()
        {
            string[] lines = File.ReadAllLines(filePath);
            
            foreach (string line in lines)
            {
                string[] fields = line.Split(';');
                
                if (fields.Length >= 6)
                {
                    string id = fields[0];
                    string nume = fields[1]; 
                    string pret = fields[2];
                    string vanzator = fields[3];
                    string descriere = fields[4];
                    string negociabil = fields[5];
                    if (fields[5].Trim() == "True")
                        negociabil = "negociabil";
                    else
                        negociabil = "nu este negociabil";
                    string pretmin = fields[6];
                   
                    string produsText = $"{id}; {nume}; {pret}; {vanzator}; {descriere}; {negociabil}; {pretmin}";
                    lstProduse.Items.Add(produsText);
                }
            }
        }

        private void btnActionare_Click(object sender, EventArgs e)
        {
            if (listBoxOferte.SelectedIndex != -1)
            {
                string ofertaSelectata = listBoxOferte.SelectedItem.ToString();
                
                string[] ofertaParti = ofertaSelectata.Split(';');
                
                int idProdusOferta = int.Parse(ofertaParti[0].Trim());
                
                decimal pretPropus = decimal.Parse(ofertaParti[2].Trim());
                
                string[] produse = File.ReadAllLines("produse.txt");
                produse = produse.Where(p => !string.IsNullOrWhiteSpace(p)).ToArray();

                bool ofertaBuna=false;

                foreach (string produs in produse)
                {
                    string[] produsParti = produs.Split(';');
                   
                    int idProdus = int.Parse(produsParti[0].Trim());
                    
                    string tipVanzare = produsParti[5].Trim();
                 
                    if (idProdus == idProdusOferta && tipVanzare == "True")
                    {
                        decimal pretMinim = decimal.Parse(produsParti[6].Trim());
                        
                        if (pretPropus >= pretMinim)
                        {
                            ofertaBuna = true;
               
                        }
                        else
                        {
                            ofertaBuna = false;
                           
                        }

                    }

                }

                if (ofertaBuna == true)
                    MessageBox.Show("Oferta a fost aprobata cu succes!");
                else
                {
                    RemoveOferta(idProdusOferta);
                    MessageBox.Show("Oferta a fost anulata!");
                }
            }
            else
            {
                MessageBox.Show("Selectați o oferta din lista.");
            }

            listBoxOferte.Items.RemoveAt(listBoxOferte.SelectedIndex);

        }
        private void RemoveOferta(int id)
        {
            string[] lines = File.ReadAllLines("oferte.txt");
            using (StreamWriter writer = new StreamWriter("oferte.txt"))
            {
                foreach (string line in lines)
                {
                    string[] fields = line.Split(';');
                    
                    if (fields.Length >= 1 && int.TryParse(fields[0].Trim(), out int ofertaId) && ofertaId == id)
                    {
                       
                        continue;
                    }

                    writer.WriteLine(line);
                }
            }

            listBoxOferte.Items.RemoveAt(listBoxOferte.SelectedIndex);
        }

        private void btnDa_Click(object sender, EventArgs e)
        {
            if (lstAprobareProd.SelectedIndex != -1)
            {
                string produsSelectat = lstAprobareProd.SelectedItem.ToString();

                string[] produsParti = produsSelectat.Split(';');

                string numeProdus = produsParti[0].Trim();

                decimal pretProdus = decimal.Parse(produsParti[1].Trim());
                
                string numeCumparator = produsParti[2].Trim();

                using (StreamWriter writer = new StreamWriter("prod_aprobate.txt", true))
                {
                    writer.WriteLine($"{numeProdus}; {pretProdus}; {numeCumparator}");
                }

                MessageBox.Show("Produsul a fost aprobat pentru vanzare!");
            }
            else
            {
                MessageBox.Show("Selectați un produs din listă.");
            }

            lstAprobareProd.Items.RemoveAt(lstAprobareProd.SelectedIndex);
        }

        private void btnNu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Produsul nu a fost aprobat pentru vanzare!");
            lstAprobareProd.Items.RemoveAt(lstAprobareProd.SelectedIndex);
        }

        private void DaNeg_Click(object sender, EventArgs e)
        {
            if (lstAprobareProdNeg.SelectedIndex != -1)
            {
                string produsSelectat = lstAprobareProdNeg.SelectedItem.ToString();
                
                string[] produsParti = produsSelectat.Split(';');
                
                string numeProdus = produsParti[0].Trim();
                
                decimal pretProdus = decimal.Parse(produsParti[1].Trim());
                
                string numeCumparator = produsParti[2].Trim();

                using (StreamWriter writer = new StreamWriter("prodNeg_aprobate.txt", true))
                {
                    writer.WriteLine($"{numeProdus}; {pretProdus}; {numeCumparator}");
                }

                MessageBox.Show("Produsul a fost aprobat pentru vanzare!");
            }
            else
            {
                MessageBox.Show("Selectați un produs din listă.");
            }
            lstAprobareProdNeg.Items.RemoveAt(lstAprobareProdNeg.SelectedIndex);
        }

        private void NuNeg_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Produsul nu a fost aprobat pentru vanzare!");
            lstAprobareProdNeg.Items.RemoveAt(lstAprobareProdNeg.SelectedIndex);
        }

        private void textBoxParola_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; 

                MessageBox.Show("Introduceți doar litere și cifre!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtNume_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;

                MessageBox.Show("Introduceți doar litere!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPret_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; 

                MessageBox.Show("Introduceți doar numere de tip real!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtVanzator_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; 

                MessageBox.Show("Introduceți doar litere!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtDescriere_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; 

                MessageBox.Show("Introduceți doar litere!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPretMinim_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; 

                MessageBox.Show("Introduceți doar numere de tip real!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxEmail_KeyPress(object sender, KeyPressEventArgs e)
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

  

      

