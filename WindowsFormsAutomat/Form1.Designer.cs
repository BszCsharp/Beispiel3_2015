namespace WindowsFormsAutomat
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxArtikel = new System.Windows.Forms.ComboBox();
            this.labelPreis = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonZahlen = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.button5C = new System.Windows.Forms.Button();
            this.button10C = new System.Windows.Forms.Button();
            this.button20C = new System.Windows.Forms.Button();
            this.button50C = new System.Windows.Forms.Button();
            this.button1E = new System.Windows.Forms.Button();
            this.button2E = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.labelRueck = new System.Windows.Forms.Label();
            this.labelMeldung = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelSumme = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Artikel";
            // 
            // comboBoxArtikel
            // 
            this.comboBoxArtikel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxArtikel.FormattingEnabled = true;
            this.comboBoxArtikel.Location = new System.Drawing.Point(29, 47);
            this.comboBoxArtikel.Name = "comboBoxArtikel";
            this.comboBoxArtikel.Size = new System.Drawing.Size(257, 28);
            this.comboBoxArtikel.TabIndex = 1;
            this.comboBoxArtikel.SelectedIndexChanged += new System.EventHandler(this.comboBoxArtikel_SelectedIndexChanged);
            // 
            // labelPreis
            // 
            this.labelPreis.AutoSize = true;
            this.labelPreis.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPreis.Location = new System.Drawing.Point(329, 50);
            this.labelPreis.Name = "labelPreis";
            this.labelPreis.Size = new System.Drawing.Size(42, 26);
            this.labelPreis.TabIndex = 2;
            this.labelPreis.Text = "0,0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Münzen";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Summe";
            // 
            // buttonZahlen
            // 
            this.buttonZahlen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonZahlen.Location = new System.Drawing.Point(29, 228);
            this.buttonZahlen.Name = "buttonZahlen";
            this.buttonZahlen.Size = new System.Drawing.Size(141, 26);
            this.buttonZahlen.TabIndex = 5;
            this.buttonZahlen.Text = "zahlen";
            this.buttonZahlen.UseVisualStyleBackColor = true;
            this.buttonZahlen.Click += new System.EventHandler(this.buttonZahlen_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.Location = new System.Drawing.Point(314, 228);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(141, 26);
            this.buttonReset.TabIndex = 6;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // button5C
            // 
            this.button5C.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5C.Location = new System.Drawing.Point(3, 3);
            this.button5C.Name = "button5C";
            this.button5C.Size = new System.Drawing.Size(60, 54);
            this.button5C.TabIndex = 7;
            this.button5C.Tag = "0,05";
            this.button5C.Text = "5 Cent";
            this.button5C.UseVisualStyleBackColor = true;
            this.button5C.Click += new System.EventHandler(this.buttonMoney_Click);
            // 
            // button10C
            // 
            this.button10C.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10C.Location = new System.Drawing.Point(73, 3);
            this.button10C.Name = "button10C";
            this.button10C.Size = new System.Drawing.Size(60, 54);
            this.button10C.TabIndex = 8;
            this.button10C.Tag = "0,1";
            this.button10C.Text = "10 Cent";
            this.button10C.UseVisualStyleBackColor = true;
            this.button10C.Click += new System.EventHandler(this.buttonMoney_Click);
            // 
            // button20C
            // 
            this.button20C.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button20C.Location = new System.Drawing.Point(143, 3);
            this.button20C.Name = "button20C";
            this.button20C.Size = new System.Drawing.Size(60, 54);
            this.button20C.TabIndex = 9;
            this.button20C.Tag = "0,2";
            this.button20C.Text = "20 Cent";
            this.button20C.UseVisualStyleBackColor = true;
            this.button20C.Click += new System.EventHandler(this.buttonMoney_Click);
            // 
            // button50C
            // 
            this.button50C.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button50C.Location = new System.Drawing.Point(213, 3);
            this.button50C.Name = "button50C";
            this.button50C.Size = new System.Drawing.Size(60, 54);
            this.button50C.TabIndex = 10;
            this.button50C.Tag = "0,50";
            this.button50C.Text = "50 Cent";
            this.button50C.UseVisualStyleBackColor = true;
            this.button50C.Click += new System.EventHandler(this.buttonMoney_Click);
            // 
            // button1E
            // 
            this.button1E.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1E.Location = new System.Drawing.Point(283, 3);
            this.button1E.Name = "button1E";
            this.button1E.Size = new System.Drawing.Size(60, 54);
            this.button1E.TabIndex = 11;
            this.button1E.Tag = "1";
            this.button1E.Text = "1 €";
            this.button1E.UseVisualStyleBackColor = true;
            this.button1E.Click += new System.EventHandler(this.buttonMoney_Click);
            // 
            // button2E
            // 
            this.button2E.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2E.Location = new System.Drawing.Point(353, 3);
            this.button2E.Name = "button2E";
            this.button2E.Size = new System.Drawing.Size(65, 54);
            this.button2E.TabIndex = 12;
            this.button2E.Tag = "2";
            this.button2E.Text = "2 €";
            this.button2E.UseVisualStyleBackColor = true;
            this.button2E.Click += new System.EventHandler(this.buttonMoney_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Rückgeld";
            // 
            // labelRueck
            // 
            this.labelRueck.AutoSize = true;
            this.labelRueck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRueck.Location = new System.Drawing.Point(152, 280);
            this.labelRueck.Name = "labelRueck";
            this.labelRueck.Size = new System.Drawing.Size(18, 20);
            this.labelRueck.TabIndex = 14;
            this.labelRueck.Text = "0";
            // 
            // labelMeldung
            // 
            this.labelMeldung.AutoSize = true;
            this.labelMeldung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMeldung.Location = new System.Drawing.Point(31, 315);
            this.labelMeldung.Name = "labelMeldung";
            this.labelMeldung.Size = new System.Drawing.Size(0, 20);
            this.labelMeldung.TabIndex = 15;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.Controls.Add(this.button5C, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button10C, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button20C, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.button50C, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1E, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.button2E, 5, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(29, 121);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(426, 60);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // labelSumme
            // 
            this.labelSumme.AutoSize = true;
            this.labelSumme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSumme.Location = new System.Drawing.Point(144, 196);
            this.labelSumme.Name = "labelSumme";
            this.labelSumme.Size = new System.Drawing.Size(18, 20);
            this.labelSumme.TabIndex = 17;
            this.labelSumme.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 358);
            this.Controls.Add(this.labelSumme);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.labelMeldung);
            this.Controls.Add(this.labelRueck);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonZahlen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelPreis);
            this.Controls.Add(this.comboBoxArtikel);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Automat";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxArtikel;
        private System.Windows.Forms.Label labelPreis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonZahlen;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button button5C;
        private System.Windows.Forms.Button button10C;
        private System.Windows.Forms.Button button20C;
        private System.Windows.Forms.Button button50C;
        private System.Windows.Forms.Button button1E;
        private System.Windows.Forms.Button button2E;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelRueck;
        private System.Windows.Forms.Label labelMeldung;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelSumme;
    }
}

