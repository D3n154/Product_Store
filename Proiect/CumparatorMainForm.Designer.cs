namespace Proiect
{
    partial class CumparatorMainForm
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
            this.labelCont = new System.Windows.Forms.Label();
            this.lblEmailC = new System.Windows.Forms.Label();
            this.lblParolaC = new System.Windows.Forms.Label();
            this.txtEmailC = new System.Windows.Forms.TextBox();
            this.txtParolaC = new System.Windows.Forms.TextBox();
            this.btnCreare = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lstVizualizare = new System.Windows.Forms.ListBox();
            this.btnVizualizare = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIdProdus = new System.Windows.Forms.TextBox();
            this.txtNumeCumparator = new System.Windows.Forms.TextBox();
            this.txtPretPropus = new System.Windows.Forms.TextBox();
            this.btnTrimite = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lstProdCum = new System.Windows.Forms.ListBox();
            this.btnVerificare = new System.Windows.Forms.Button();
            this.lstProdAprob = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCumparare = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNumeCump = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lstProdNeg = new System.Windows.Forms.ListBox();
            this.lstProdAprobNeg = new System.Windows.Forms.ListBox();
            this.btnVerificareNeg = new System.Windows.Forms.Button();
            this.btnCumparareNeg = new System.Windows.Forms.Button();
            this.txtCumparatorNeg = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPretNeg = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtProdusCautat = new System.Windows.Forms.TextBox();
            this.txtProdusGasit = new System.Windows.Forms.TextBox();
            this.btnCauta = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelCont
            // 
            this.labelCont.AutoSize = true;
            this.labelCont.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCont.Location = new System.Drawing.Point(90, 22);
            this.labelCont.Name = "labelCont";
            this.labelCont.Size = new System.Drawing.Size(108, 24);
            this.labelCont.TabIndex = 0;
            this.labelCont.Text = "Creare cont";
            // 
            // lblEmailC
            // 
            this.lblEmailC.AutoSize = true;
            this.lblEmailC.Location = new System.Drawing.Point(12, 88);
            this.lblEmailC.Name = "lblEmailC";
            this.lblEmailC.Size = new System.Drawing.Size(46, 17);
            this.lblEmailC.TabIndex = 1;
            this.lblEmailC.Text = "Email:";
            // 
            // lblParolaC
            // 
            this.lblParolaC.AutoSize = true;
            this.lblParolaC.Location = new System.Drawing.Point(5, 161);
            this.lblParolaC.Name = "lblParolaC";
            this.lblParolaC.Size = new System.Drawing.Size(53, 17);
            this.lblParolaC.TabIndex = 2;
            this.lblParolaC.Text = "Parola:";
            // 
            // txtEmailC
            // 
            this.txtEmailC.Location = new System.Drawing.Point(64, 83);
            this.txtEmailC.Name = "txtEmailC";
            this.txtEmailC.Size = new System.Drawing.Size(184, 22);
            this.txtEmailC.TabIndex = 3;
            this.txtEmailC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmailC_KeyPress);
            // 
            // txtParolaC
            // 
            this.txtParolaC.Location = new System.Drawing.Point(64, 158);
            this.txtParolaC.Name = "txtParolaC";
            this.txtParolaC.Size = new System.Drawing.Size(184, 22);
            this.txtParolaC.TabIndex = 4;
            this.txtParolaC.UseSystemPasswordChar = true;
            this.txtParolaC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtParolaC_KeyPress);
            // 
            // btnCreare
            // 
            this.btnCreare.Location = new System.Drawing.Point(94, 218);
            this.btnCreare.Name = "btnCreare";
            this.btnCreare.Size = new System.Drawing.Size(112, 39);
            this.btnCreare.TabIndex = 5;
            this.btnCreare.Text = "Creare";
            this.btnCreare.UseVisualStyleBackColor = true;
            this.btnCreare.Click += new System.EventHandler(this.btnCreare_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(309, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Vizualizare lista produse";
            // 
            // lstVizualizare
            // 
            this.lstVizualizare.FormattingEnabled = true;
            this.lstVizualizare.ItemHeight = 16;
            this.lstVizualizare.Location = new System.Drawing.Point(283, 83);
            this.lstVizualizare.Name = "lstVizualizare";
            this.lstVizualizare.Size = new System.Drawing.Size(238, 132);
            this.lstVizualizare.TabIndex = 7;
            // 
            // btnVizualizare
            // 
            this.btnVizualizare.Location = new System.Drawing.Point(343, 232);
            this.btnVizualizare.Name = "btnVizualizare";
            this.btnVizualizare.Size = new System.Drawing.Size(124, 39);
            this.btnVizualizare.TabIndex = 8;
            this.btnVizualizare.Text = "Vizualizare";
            this.btnVizualizare.UseVisualStyleBackColor = true;
            this.btnVizualizare.Click += new System.EventHandler(this.btnVizualizare_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(737, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Oferta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(572, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "ID produs:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(527, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nume cumparator:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(566, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Pret propus:";
            // 
            // txtIdProdus
            // 
            this.txtIdProdus.Location = new System.Drawing.Point(679, 88);
            this.txtIdProdus.Name = "txtIdProdus";
            this.txtIdProdus.Size = new System.Drawing.Size(186, 22);
            this.txtIdProdus.TabIndex = 13;
            this.txtIdProdus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdProdus_KeyPress);
            // 
            // txtNumeCumparator
            // 
            this.txtNumeCumparator.Location = new System.Drawing.Point(679, 141);
            this.txtNumeCumparator.Name = "txtNumeCumparator";
            this.txtNumeCumparator.Size = new System.Drawing.Size(186, 22);
            this.txtNumeCumparator.TabIndex = 14;
            this.txtNumeCumparator.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeCumparator_KeyPress);
            // 
            // txtPretPropus
            // 
            this.txtPretPropus.Location = new System.Drawing.Point(679, 193);
            this.txtPretPropus.Name = "txtPretPropus";
            this.txtPretPropus.Size = new System.Drawing.Size(186, 22);
            this.txtPretPropus.TabIndex = 15;
            this.txtPretPropus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPretPropus_KeyPress);
            // 
            // btnTrimite
            // 
            this.btnTrimite.Location = new System.Drawing.Point(710, 241);
            this.btnTrimite.Name = "btnTrimite";
            this.btnTrimite.Size = new System.Drawing.Size(114, 40);
            this.btnTrimite.TabIndex = 16;
            this.btnTrimite.Text = "Trimite";
            this.btnTrimite.UseVisualStyleBackColor = true;
            this.btnTrimite.Click += new System.EventHandler(this.btnTrimite_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(49, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 24);
            this.label6.TabIndex = 17;
            this.label6.Text = "Lista de produse";
            // 
            // lstProdCum
            // 
            this.lstProdCum.FormattingEnabled = true;
            this.lstProdCum.ItemHeight = 16;
            this.lstProdCum.Location = new System.Drawing.Point(36, 340);
            this.lstProdCum.Name = "lstProdCum";
            this.lstProdCum.Size = new System.Drawing.Size(203, 132);
            this.lstProdCum.TabIndex = 18;
            // 
            // btnVerificare
            // 
            this.btnVerificare.Location = new System.Drawing.Point(105, 531);
            this.btnVerificare.Name = "btnVerificare";
            this.btnVerificare.Size = new System.Drawing.Size(134, 39);
            this.btnVerificare.TabIndex = 19;
            this.btnVerificare.Text = "Verificare";
            this.btnVerificare.UseVisualStyleBackColor = true;
            this.btnVerificare.Click += new System.EventHandler(this.btnVerificare_Click_1);
            // 
            // lstProdAprob
            // 
            this.lstProdAprob.FormattingEnabled = true;
            this.lstProdAprob.ItemHeight = 16;
            this.lstProdAprob.Location = new System.Drawing.Point(343, 352);
            this.lstProdAprob.Name = "lstProdAprob";
            this.lstProdAprob.Size = new System.Drawing.Size(224, 116);
            this.lstProdAprob.TabIndex = 20;
            
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(339, 305);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(228, 24);
            this.label7.TabIndex = 21;
            this.label7.Text = "Lista de produse aprobate";
            // 
            // btnCumparare
            // 
            this.btnCumparare.Location = new System.Drawing.Point(387, 491);
            this.btnCumparare.Name = "btnCumparare";
            this.btnCumparare.Size = new System.Drawing.Size(134, 39);
            this.btnCumparare.TabIndex = 22;
            this.btnCumparare.Text = "Cumparare";
            this.btnCumparare.UseVisualStyleBackColor = true;
            this.btnCumparare.Click += new System.EventHandler(this.btnCumparare_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 491);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 17);
            this.label8.TabIndex = 23;
            this.label8.Text = "Nume cumparator:";
            // 
            // txtNumeCump
            // 
            this.txtNumeCump.Location = new System.Drawing.Point(139, 491);
            this.txtNumeCump.Name = "txtNumeCump";
            this.txtNumeCump.Size = new System.Drawing.Size(129, 22);
            this.txtNumeCump.TabIndex = 24;
            this.txtNumeCump.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeCump_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(615, 305);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(225, 24);
            this.label9.TabIndex = 25;
            this.label9.Text = "Lista produse negociabile";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(888, 319);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(178, 24);
            this.label10.TabIndex = 26;
            this.label10.Text = "Nogocieri acceptate";
            // 
            // lstProdNeg
            // 
            this.lstProdNeg.FormattingEnabled = true;
            this.lstProdNeg.ItemHeight = 16;
            this.lstProdNeg.Location = new System.Drawing.Point(618, 352);
            this.lstProdNeg.Name = "lstProdNeg";
            this.lstProdNeg.Size = new System.Drawing.Size(221, 100);
            this.lstProdNeg.TabIndex = 27;
            // 
            // lstProdAprobNeg
            // 
            this.lstProdAprobNeg.FormattingEnabled = true;
            this.lstProdAprobNeg.ItemHeight = 16;
            this.lstProdAprobNeg.Location = new System.Drawing.Point(864, 361);
            this.lstProdAprobNeg.Name = "lstProdAprobNeg";
            this.lstProdAprobNeg.Size = new System.Drawing.Size(221, 100);
            this.lstProdAprobNeg.TabIndex = 28;
            // 
            // btnVerificareNeg
            // 
            this.btnVerificareNeg.Location = new System.Drawing.Point(663, 536);
            this.btnVerificareNeg.Name = "btnVerificareNeg";
            this.btnVerificareNeg.Size = new System.Drawing.Size(134, 39);
            this.btnVerificareNeg.TabIndex = 29;
            this.btnVerificareNeg.Text = "Verificare";
            this.btnVerificareNeg.UseVisualStyleBackColor = true;
            this.btnVerificareNeg.Click += new System.EventHandler(this.btnVerificareNeg_Click);
            // 
            // btnCumparareNeg
            // 
            this.btnCumparareNeg.Location = new System.Drawing.Point(912, 491);
            this.btnCumparareNeg.Name = "btnCumparareNeg";
            this.btnCumparareNeg.Size = new System.Drawing.Size(134, 39);
            this.btnCumparareNeg.TabIndex = 30;
            this.btnCumparareNeg.Text = "Cumparare";
            this.btnCumparareNeg.UseVisualStyleBackColor = true;
            this.btnCumparareNeg.Click += new System.EventHandler(this.btnCumparareNeg_Click);
            // 
            // txtCumparatorNeg
            // 
            this.txtCumparatorNeg.Location = new System.Drawing.Point(710, 474);
            this.txtCumparatorNeg.Name = "txtCumparatorNeg";
            this.txtCumparatorNeg.Size = new System.Drawing.Size(129, 22);
            this.txtCumparatorNeg.TabIndex = 32;
            this.txtCumparatorNeg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCumparatorNeg_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(586, 474);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 17);
            this.label11.TabIndex = 31;
            this.label11.Text = "Nume cumparator:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(618, 508);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 17);
            this.label12.TabIndex = 33;
            this.label12.Text = "Pret propus:";
            // 
            // txtPretNeg
            // 
            this.txtPretNeg.Location = new System.Drawing.Point(710, 508);
            this.txtPretNeg.Name = "txtPretNeg";
            this.txtPretNeg.Size = new System.Drawing.Size(129, 22);
            this.txtPretNeg.TabIndex = 34;
            this.txtPretNeg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPretNeg_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.Location = new System.Drawing.Point(943, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(139, 24);
            this.label13.TabIndex = 35;
            this.label13.Text = "Cautare produs";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(889, 86);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 17);
            this.label14.TabIndex = 36;
            this.label14.Text = "Nume:";
            // 
            // txtProdusCautat
            // 
            this.txtProdusCautat.Location = new System.Drawing.Point(960, 86);
            this.txtProdusCautat.Name = "txtProdusCautat";
            this.txtProdusCautat.Size = new System.Drawing.Size(125, 22);
            this.txtProdusCautat.TabIndex = 37;
            this.txtProdusCautat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProdusCautat_KeyPress);
            // 
            // txtProdusGasit
            // 
            this.txtProdusGasit.Location = new System.Drawing.Point(912, 232);
            this.txtProdusGasit.Name = "txtProdusGasit";
            this.txtProdusGasit.Size = new System.Drawing.Size(202, 22);
            this.txtProdusGasit.TabIndex = 38;
            // 
            // btnCauta
            // 
            this.btnCauta.Location = new System.Drawing.Point(960, 158);
            this.btnCauta.Name = "btnCauta";
            this.btnCauta.Size = new System.Drawing.Size(125, 40);
            this.btnCauta.TabIndex = 39;
            this.btnCauta.Text = "Cauta";
            this.btnCauta.UseVisualStyleBackColor = true;
            this.btnCauta.Click += new System.EventHandler(this.btnCauta_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(849, 237);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 17);
            this.label15.TabIndex = 40;
            this.label15.Text = "Produs:";
            // 
            // CumparatorMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 582);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnCauta);
            this.Controls.Add(this.txtProdusGasit);
            this.Controls.Add(this.txtProdusCautat);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtPretNeg);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtCumparatorNeg);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnCumparareNeg);
            this.Controls.Add(this.btnVerificareNeg);
            this.Controls.Add(this.lstProdAprobNeg);
            this.Controls.Add(this.lstProdNeg);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtNumeCump);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnCumparare);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lstProdAprob);
            this.Controls.Add(this.btnVerificare);
            this.Controls.Add(this.lstProdCum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnTrimite);
            this.Controls.Add(this.txtPretPropus);
            this.Controls.Add(this.txtNumeCumparator);
            this.Controls.Add(this.txtIdProdus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnVizualizare);
            this.Controls.Add(this.lstVizualizare);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCreare);
            this.Controls.Add(this.txtParolaC);
            this.Controls.Add(this.txtEmailC);
            this.Controls.Add(this.lblParolaC);
            this.Controls.Add(this.lblEmailC);
            this.Controls.Add(this.labelCont);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CumparatorMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CumparatorMainForm";
            this.Load += new System.EventHandler(this.CumparatorMainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCont;
        private System.Windows.Forms.Label lblEmailC;
        private System.Windows.Forms.Label lblParolaC;
        private System.Windows.Forms.TextBox txtEmailC;
        private System.Windows.Forms.TextBox txtParolaC;
        private System.Windows.Forms.Button btnCreare;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstVizualizare;
        private System.Windows.Forms.Button btnVizualizare;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIdProdus;
        private System.Windows.Forms.TextBox txtNumeCumparator;
        private System.Windows.Forms.TextBox txtPretPropus;
        private System.Windows.Forms.Button btnTrimite;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lstProdCum;
        private System.Windows.Forms.Button btnVerificare;
        private System.Windows.Forms.ListBox lstProdAprob;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCumparare;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNumeCump;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox lstProdNeg;
        private System.Windows.Forms.ListBox lstProdAprobNeg;
        private System.Windows.Forms.Button btnVerificareNeg;
        private System.Windows.Forms.Button btnCumparareNeg;
        private System.Windows.Forms.TextBox txtCumparatorNeg;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPretNeg;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtProdusCautat;
        private System.Windows.Forms.TextBox txtProdusGasit;
        private System.Windows.Forms.Button btnCauta;
        private System.Windows.Forms.Label label15;
    }
}