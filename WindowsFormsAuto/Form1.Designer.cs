namespace WindowsFormsAuto
{
    partial class FormStart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStart));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxKennzeichen = new System.Windows.Forms.TextBox();
            this.textBoxVerbrauch = new System.Windows.Forms.TextBox();
            this.textBoxkmStand = new System.Windows.Forms.TextBox();
            this.textBoxMaxFuell = new System.Windows.Forms.TextBox();
            this.buttonAutoErzeugen = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBoxAutos = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonAutosAnzeigen = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kennzeichen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Verbauch";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Km-Stand";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "max. Füllmenge";
            // 
            // textBoxKennzeichen
            // 
            this.textBoxKennzeichen.Location = new System.Drawing.Point(114, 11);
            this.textBoxKennzeichen.Name = "textBoxKennzeichen";
            this.textBoxKennzeichen.Size = new System.Drawing.Size(115, 20);
            this.textBoxKennzeichen.TabIndex = 4;
            // 
            // textBoxVerbrauch
            // 
            this.textBoxVerbrauch.Location = new System.Drawing.Point(114, 59);
            this.textBoxVerbrauch.Name = "textBoxVerbrauch";
            this.textBoxVerbrauch.Size = new System.Drawing.Size(115, 20);
            this.textBoxVerbrauch.TabIndex = 5;
            this.textBoxVerbrauch.Text = "0.0";
            // 
            // textBoxkmStand
            // 
            this.textBoxkmStand.Location = new System.Drawing.Point(114, 102);
            this.textBoxkmStand.Name = "textBoxkmStand";
            this.textBoxkmStand.Size = new System.Drawing.Size(115, 20);
            this.textBoxkmStand.TabIndex = 6;
            this.textBoxkmStand.Text = "0";
            this.textBoxkmStand.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxkmStand_Validating);
            // 
            // textBoxMaxFuell
            // 
            this.textBoxMaxFuell.Location = new System.Drawing.Point(114, 151);
            this.textBoxMaxFuell.Name = "textBoxMaxFuell";
            this.textBoxMaxFuell.Size = new System.Drawing.Size(115, 20);
            this.textBoxMaxFuell.TabIndex = 7;
            this.textBoxMaxFuell.Text = "0.0";
            // 
            // buttonAutoErzeugen
            // 
            this.buttonAutoErzeugen.Location = new System.Drawing.Point(19, 191);
            this.buttonAutoErzeugen.Name = "buttonAutoErzeugen";
            this.buttonAutoErzeugen.Size = new System.Drawing.Size(209, 23);
            this.buttonAutoErzeugen.TabIndex = 8;
            this.buttonAutoErzeugen.Text = "Autobjekt erzeugen";
            this.buttonAutoErzeugen.UseVisualStyleBackColor = true;
            this.buttonAutoErzeugen.Click += new System.EventHandler(this.buttonAutoErzeugen_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonAutoErzeugen);
            this.groupBox1.Controls.Add(this.textBoxMaxFuell);
            this.groupBox1.Controls.Add(this.textBoxkmStand);
            this.groupBox1.Controls.Add(this.textBoxVerbrauch);
            this.groupBox1.Controls.Add(this.textBoxKennzeichen);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 234);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Auto aufnehmen";
            // 
            // listBoxAutos
            // 
            this.listBoxAutos.FormattingEnabled = true;
            this.listBoxAutos.Location = new System.Drawing.Point(369, 34);
            this.listBoxAutos.Name = "listBoxAutos";
            this.listBoxAutos.Size = new System.Drawing.Size(214, 147);
            this.listBoxAutos.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(366, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Liste aller Autos";
            // 
            // buttonAutosAnzeigen
            // 
            this.buttonAutosAnzeigen.Location = new System.Drawing.Point(369, 203);
            this.buttonAutosAnzeigen.Name = "buttonAutosAnzeigen";
            this.buttonAutosAnzeigen.Size = new System.Drawing.Size(214, 23);
            this.buttonAutosAnzeigen.TabIndex = 12;
            this.buttonAutosAnzeigen.Text = "Autos anzeigen";
            this.buttonAutosAnzeigen.UseVisualStyleBackColor = true;
            this.buttonAutosAnzeigen.Click += new System.EventHandler(this.buttonAutosAnzeigen_Click);
            // 
            // FormStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 323);
            this.Controls.Add(this.buttonAutosAnzeigen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBoxAutos);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormStart";
            this.Text = "Autos verwalten";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxKennzeichen;
        private System.Windows.Forms.TextBox textBoxVerbrauch;
        private System.Windows.Forms.TextBox textBoxkmStand;
        private System.Windows.Forms.TextBox textBoxMaxFuell;
        private System.Windows.Forms.Button buttonAutoErzeugen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBoxAutos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonAutosAnzeigen;
    }
}

