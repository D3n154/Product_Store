namespace Proiect
{
    partial class VanzatorMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxParola = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAprobare = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.C = new System.Windows.Forms.TextBox();
            this.txtPret = new System.Windows.Forms.TextBox();
            this.txtVanzator = new System.Windows.Forms.TextBox();
            this.txtPretMin = new System.Windows.Forms.TextBox();
            this.txtDescriere = new System.Windows.Forms.TextBox();
            this.chkNegociabil = new System.Windows.Forms.CheckBox();
            this.btnVanzare = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.lstProduse = new System.Windows.Forms.ListBox();
            this.btnAnulare = new System.Windows.Forms.Button();
            this.listBoxOferte = new System.Windows.Forms.ListBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnActionare = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.lstAprobareProd = new System.Windows.Forms.ListBox();
            this.btnDa = new System.Windows.Forms.Button();
            this.btnNu = new System.Windows.Forms.Button();
            this.NuNeg = new System.Windows.Forms.Button();
            this.DaNeg = new System.Windows.Forms.Button();
            this.lstAprobareProdNeg = new System.Windows.Forms.ListBox();
            this.label15 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(86, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aprobare cont";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(68, 88);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(167, 22);
            this.textBoxEmail.TabIndex = 1;
            this.textBoxEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxEmail_KeyPress);
            // 
            // textBoxParola
            // 
            this.textBoxParola.Location = new System.Drawing.Point(68, 140);
            this.textBoxParola.Name = "textBoxParola";
            this.textBoxParola.Size = new System.Drawing.Size(167, 22);
            this.textBoxParola.TabIndex = 2;
            this.textBoxParola.UseSystemPasswordChar = true;
            this.textBoxParola.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxParola_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Parola:";
            // 
            // btnAprobare
            // 
            this.btnAprobare.Location = new System.Drawing.Point(90, 189);
            this.btnAprobare.Name = "btnAprobare";
            this.btnAprobare.Size = new System.Drawing.Size(94, 30);
            this.btnAprobare.TabIndex = 5;
            this.btnAprobare.Text = "Aprobare";
            this.btnAprobare.UseVisualStyleBackColor = true;
            this.btnAprobare.Click += new System.EventHandler(this.btnAprobare_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(355, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Vanzare produs";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(281, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Nume:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(292, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Pret:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(319, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 17);
            this.label7.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(256, 300);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "Descriere:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(251, 395);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 17);
            this.label10.TabIndex = 12;
            this.label10.Text = "Pret minim:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(261, 253);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 17);
            this.label11.TabIndex = 13;
            this.label11.Text = "Vanzator:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(304, 96);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 17);
            this.label12.TabIndex = 14;
            this.label12.Text = "ID:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(345, 93);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(167, 22);
            this.txtID.TabIndex = 15;
            this.txtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPret_KeyPress);
            // 
            // C
            // 
            this.C.Location = new System.Drawing.Point(345, 143);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(167, 22);
            this.C.TabIndex = 16;
            this.C.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNume_KeyPress);
            // 
            // txtPret
            // 
            this.txtPret.Location = new System.Drawing.Point(345, 197);
            this.txtPret.Name = "txtPret";
            this.txtPret.Size = new System.Drawing.Size(167, 22);
            this.txtPret.TabIndex = 17;
            this.txtPret.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPret_KeyPress);
            // 
            // txtVanzator
            // 
            this.txtVanzator.Location = new System.Drawing.Point(345, 248);
            this.txtVanzator.Name = "txtVanzator";
            this.txtVanzator.Size = new System.Drawing.Size(167, 22);
            this.txtVanzator.TabIndex = 18;
            this.txtVanzator.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVanzator_KeyPress);
            // 
            // txtPretMin
            // 
            this.txtPretMin.Enabled = false;
            this.txtPretMin.Location = new System.Drawing.Point(345, 390);
            this.txtPretMin.Name = "txtPretMin";
            this.txtPretMin.Size = new System.Drawing.Size(167, 22);
            this.txtPretMin.TabIndex = 19;
            this.txtPretMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPretMinim_KeyPress);
            // 
            // txtDescriere
            // 
            this.txtDescriere.Location = new System.Drawing.Point(345, 297);
            this.txtDescriere.Name = "txtDescriere";
            this.txtDescriere.Size = new System.Drawing.Size(167, 22);
            this.txtDescriere.TabIndex = 20;
            this.txtDescriere.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescriere_KeyPress);
            // 
            // chkNegociabil
            // 
            this.chkNegociabil.AutoSize = true;
            this.chkNegociabil.Location = new System.Drawing.Point(295, 345);
            this.chkNegociabil.Name = "chkNegociabil";
            this.chkNegociabil.Size = new System.Drawing.Size(96, 21);
            this.chkNegociabil.TabIndex = 21;
            this.chkNegociabil.Text = "Negociabil";
            this.chkNegociabil.UseVisualStyleBackColor = true;
            this.chkNegociabil.CheckedChanged += new System.EventHandler(this.chkNegociabil_CheckedChanged);
            // 
            // btnVanzare
            // 
            this.btnVanzare.Location = new System.Drawing.Point(379, 446);
            this.btnVanzare.Name = "btnVanzare";
            this.btnVanzare.Size = new System.Drawing.Size(94, 30);
            this.btnVanzare.TabIndex = 22;
            this.btnVanzare.Text = "Vanzare";
            this.btnVanzare.UseVisualStyleBackColor = true;
            this.btnVanzare.Click += new System.EventHandler(this.btnVanzare_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(605, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 24);
            this.label9.TabIndex = 23;
            this.label9.Text = "Anulare vanzare";
            // 
            // lstProduse
            // 
            this.lstProduse.FormattingEnabled = true;
            this.lstProduse.ItemHeight = 16;
            this.lstProduse.Location = new System.Drawing.Point(557, 88);
            this.lstProduse.Name = "lstProduse";
            this.lstProduse.Size = new System.Drawing.Size(227, 148);
            this.lstProduse.TabIndex = 24;
            // 
            // btnAnulare
            // 
            this.btnAnulare.Location = new System.Drawing.Point(609, 253);
            this.btnAnulare.Name = "btnAnulare";
            this.btnAnulare.Size = new System.Drawing.Size(94, 30);
            this.btnAnulare.TabIndex = 25;
            this.btnAnulare.Text = "Anulare";
            this.btnAnulare.UseVisualStyleBackColor = true;
            this.btnAnulare.Click += new System.EventHandler(this.btnAnulare_Click);
            // 
            // listBoxOferte
            // 
            this.listBoxOferte.FormattingEnabled = true;
            this.listBoxOferte.ItemHeight = 16;
            this.listBoxOferte.Location = new System.Drawing.Point(825, 88);
            this.listBoxOferte.Name = "listBoxOferte";
            this.listBoxOferte.Size = new System.Drawing.Size(228, 148);
            this.listBoxOferte.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.Location = new System.Drawing.Point(842, 30);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(211, 24);
            this.label13.TabIndex = 27;
            this.label13.Text = "Aprobare/Anulare oferta";
            // 
            // btnActionare
            // 
            this.btnActionare.Location = new System.Drawing.Point(863, 253);
            this.btnActionare.Name = "btnActionare";
            this.btnActionare.Size = new System.Drawing.Size(169, 30);
            this.btnActionare.TabIndex = 28;
            this.btnActionare.Text = "Aprobare/Anulare ";
            this.btnActionare.UseVisualStyleBackColor = true;
            this.btnActionare.Click += new System.EventHandler(this.btnActionare_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.Location = new System.Drawing.Point(54, 260);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(153, 24);
            this.label14.TabIndex = 29;
            this.label14.Text = "Aprobare produs";
            // 
            // lstAprobareProd
            // 
            this.lstAprobareProd.FormattingEnabled = true;
            this.lstAprobareProd.ItemHeight = 16;
            this.lstAprobareProd.Location = new System.Drawing.Point(20, 312);
            this.lstAprobareProd.Name = "lstAprobareProd";
            this.lstAprobareProd.Size = new System.Drawing.Size(215, 116);
            this.lstAprobareProd.TabIndex = 30;
            // 
            // btnDa
            // 
            this.btnDa.Location = new System.Drawing.Point(20, 445);
            this.btnDa.Name = "btnDa";
            this.btnDa.Size = new System.Drawing.Size(94, 33);
            this.btnDa.TabIndex = 31;
            this.btnDa.Text = "DA";
            this.btnDa.UseVisualStyleBackColor = true;
            this.btnDa.Click += new System.EventHandler(this.btnDa_Click);
            // 
            // btnNu
            // 
            this.btnNu.Location = new System.Drawing.Point(141, 446);
            this.btnNu.Name = "btnNu";
            this.btnNu.Size = new System.Drawing.Size(94, 33);
            this.btnNu.TabIndex = 32;
            this.btnNu.Text = "NU";
            this.btnNu.UseVisualStyleBackColor = true;
            this.btnNu.Click += new System.EventHandler(this.btnNu_Click);
            // 
            // NuNeg
            // 
            this.NuNeg.Location = new System.Drawing.Point(797, 467);
            this.NuNeg.Name = "NuNeg";
            this.NuNeg.Size = new System.Drawing.Size(94, 33);
            this.NuNeg.TabIndex = 36;
            this.NuNeg.Text = "NU";
            this.NuNeg.UseVisualStyleBackColor = true;
            this.NuNeg.Click += new System.EventHandler(this.NuNeg_Click);
            // 
            // DaNeg
            // 
            this.DaNeg.Location = new System.Drawing.Point(676, 467);
            this.DaNeg.Name = "DaNeg";
            this.DaNeg.Size = new System.Drawing.Size(94, 33);
            this.DaNeg.TabIndex = 35;
            this.DaNeg.Text = "DA";
            this.DaNeg.UseVisualStyleBackColor = true;
            this.DaNeg.Click += new System.EventHandler(this.DaNeg_Click);
            // 
            // lstAprobareProdNeg
            // 
            this.lstAprobareProdNeg.FormattingEnabled = true;
            this.lstAprobareProdNeg.ItemHeight = 16;
            this.lstAprobareProdNeg.Location = new System.Drawing.Point(676, 336);
            this.lstAprobareProdNeg.Name = "lstAprobareProdNeg";
            this.lstAprobareProdNeg.Size = new System.Drawing.Size(215, 116);
            this.lstAprobareProdNeg.TabIndex = 34;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label15.Location = new System.Drawing.Point(672, 300);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(245, 24);
            this.label15.TabIndex = 33;
            this.label15.Text = "Aprobare produs negociabil";
            // 
            // VanzatorMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 523);
            this.Controls.Add(this.NuNeg);
            this.Controls.Add(this.DaNeg);
            this.Controls.Add(this.lstAprobareProdNeg);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnNu);
            this.Controls.Add(this.btnDa);
            this.Controls.Add(this.lstAprobareProd);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnActionare);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.listBoxOferte);
            this.Controls.Add(this.btnAnulare);
            this.Controls.Add(this.lstProduse);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnVanzare);
            this.Controls.Add(this.chkNegociabil);
            this.Controls.Add(this.txtDescriere);
            this.Controls.Add(this.txtPretMin);
            this.Controls.Add(this.txtVanzator);
            this.Controls.Add(this.txtPret);
            this.Controls.Add(this.C);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAprobare);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxParola);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "VanzatorMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VanzatorMainForm";
            this.Load += new System.EventHandler(this.VanzatorMainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxParola;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAprobare;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox C;
        private System.Windows.Forms.TextBox txtPret;
        private System.Windows.Forms.TextBox txtVanzator;
        private System.Windows.Forms.TextBox txtPretMin;
        private System.Windows.Forms.TextBox txtDescriere;
        private System.Windows.Forms.CheckBox chkNegociabil;
        private System.Windows.Forms.Button btnVanzare;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox lstProduse;
        private System.Windows.Forms.Button btnAnulare;
        private System.Windows.Forms.ListBox listBoxOferte;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnActionare;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ListBox lstAprobareProd;
        private System.Windows.Forms.Button btnDa;
        private System.Windows.Forms.Button btnNu;
        private System.Windows.Forms.Button NuNeg;
        private System.Windows.Forms.Button DaNeg;
        private System.Windows.Forms.ListBox lstAprobareProdNeg;
        private System.Windows.Forms.Label label15;
    }
}