namespace ppe3
{
    partial class Form3
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBoxmedecin = new System.Windows.Forms.ComboBox();
            this.daterdv = new System.Windows.Forms.Label();
            this.medecincr = new System.Windows.Forms.Label();
            this.textBoxmotif = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.retourcr = new System.Windows.Forms.Button();
            this.ajoutercr = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxquantite = new System.Windows.Forms.TextBox();
            this.comboBoxechantillon = new System.Windows.Forms.ComboBox();
            this.bilan = new System.Windows.Forms.Label();
            this.richTextBoxbilan = new System.Windows.Forms.RichTextBox();
            this.user = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            this.note = new System.Windows.Forms.Label();
            this.note1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkBoxrmplacant = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(259, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rapports de Visite";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Location = new System.Drawing.Point(77, 62);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // comboBoxmedecin
            // 
            this.comboBoxmedecin.FormattingEnabled = true;
            this.comboBoxmedecin.Location = new System.Drawing.Point(77, 102);
            this.comboBoxmedecin.Name = "comboBoxmedecin";
            this.comboBoxmedecin.Size = new System.Drawing.Size(121, 21);
            this.comboBoxmedecin.TabIndex = 2;
            // 
            // daterdv
            // 
            this.daterdv.AutoSize = true;
            this.daterdv.Location = new System.Drawing.Point(12, 68);
            this.daterdv.Name = "daterdv";
            this.daterdv.Size = new System.Drawing.Size(33, 13);
            this.daterdv.TabIndex = 3;
            this.daterdv.Text = "Date:";
            // 
            // medecincr
            // 
            this.medecincr.AutoSize = true;
            this.medecincr.Location = new System.Drawing.Point(13, 109);
            this.medecincr.Name = "medecincr";
            this.medecincr.Size = new System.Drawing.Size(51, 13);
            this.medecincr.TabIndex = 4;
            this.medecincr.Text = "Medecin:";
            // 
            // textBoxmotif
            // 
            this.textBoxmotif.Location = new System.Drawing.Point(77, 137);
            this.textBoxmotif.Multiline = true;
            this.textBoxmotif.Name = "textBoxmotif";
            this.textBoxmotif.Size = new System.Drawing.Size(237, 20);
            this.textBoxmotif.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Motif:";
            // 
            // retourcr
            // 
            this.retourcr.Location = new System.Drawing.Point(77, 340);
            this.retourcr.Name = "retourcr";
            this.retourcr.Size = new System.Drawing.Size(75, 23);
            this.retourcr.TabIndex = 7;
            this.retourcr.Text = "Retour";
            this.retourcr.UseVisualStyleBackColor = true;
            this.retourcr.Click += new System.EventHandler(this.retourcr_Click);
            // 
            // ajoutercr
            // 
            this.ajoutercr.Location = new System.Drawing.Point(172, 340);
            this.ajoutercr.Name = "ajoutercr";
            this.ajoutercr.Size = new System.Drawing.Size(142, 23);
            this.ajoutercr.TabIndex = 8;
            this.ajoutercr.Text = "Ajouter le Compte Rendu";
            this.ajoutercr.UseVisualStyleBackColor = true;
            this.ajoutercr.Click += new System.EventHandler(this.ajoutercr_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Echantillon:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Quantité:";
            // 
            // textBoxquantite
            // 
            this.textBoxquantite.Location = new System.Drawing.Point(77, 288);
            this.textBoxquantite.Name = "textBoxquantite";
            this.textBoxquantite.Size = new System.Drawing.Size(100, 20);
            this.textBoxquantite.TabIndex = 12;
            // 
            // comboBoxechantillon
            // 
            this.comboBoxechantillon.FormattingEnabled = true;
            this.comboBoxechantillon.Location = new System.Drawing.Point(77, 259);
            this.comboBoxechantillon.Name = "comboBoxechantillon";
            this.comboBoxechantillon.Size = new System.Drawing.Size(121, 21);
            this.comboBoxechantillon.TabIndex = 13;
            // 
            // bilan
            // 
            this.bilan.AutoSize = true;
            this.bilan.Location = new System.Drawing.Point(19, 173);
            this.bilan.Name = "bilan";
            this.bilan.Size = new System.Drawing.Size(33, 13);
            this.bilan.TabIndex = 14;
            this.bilan.Text = "Bilan:";
            // 
            // richTextBoxbilan
            // 
            this.richTextBoxbilan.Location = new System.Drawing.Point(77, 173);
            this.richTextBoxbilan.Name = "richTextBoxbilan";
            this.richTextBoxbilan.Size = new System.Drawing.Size(237, 52);
            this.richTextBoxbilan.TabIndex = 15;
            this.richTextBoxbilan.Text = "";
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.Location = new System.Drawing.Point(522, 13);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(27, 13);
            this.user.TabIndex = 16;
            this.user.Text = "user";
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(525, 39);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(15, 13);
            this.id.TabIndex = 17;
            this.id.Text = "id";
            // 
            // note
            // 
            this.note.AutoSize = true;
            this.note.Location = new System.Drawing.Point(362, 137);
            this.note.Name = "note";
            this.note.Size = new System.Drawing.Size(33, 13);
            this.note.TabIndex = 18;
            this.note.Text = "Note:";
            // 
            // note1
            // 
            this.note1.AutoSize = true;
            this.note1.Location = new System.Drawing.Point(439, 140);
            this.note1.Name = "note1";
            this.note1.Size = new System.Drawing.Size(24, 13);
            this.note1.TabIndex = 20;
            this.note1.Text = "/10";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(399, 136);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(34, 21);
            this.comboBox1.TabIndex = 21;
            // 
            // checkBoxrmplacant
            // 
            this.checkBoxrmplacant.AutoSize = true;
            this.checkBoxrmplacant.Location = new System.Drawing.Point(383, 62);
            this.checkBoxrmplacant.Name = "checkBoxrmplacant";
            this.checkBoxrmplacant.Size = new System.Drawing.Size(83, 17);
            this.checkBoxrmplacant.TabIndex = 22;
            this.checkBoxrmplacant.Text = "Remplacant";
            this.checkBoxrmplacant.UseVisualStyleBackColor = true;
            this.checkBoxrmplacant.CheckedChanged += new System.EventHandler(this.checkBoxrmplacant_CheckedChanged);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 382);
            this.Controls.Add(this.checkBoxrmplacant);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.note1);
            this.Controls.Add(this.note);
            this.Controls.Add(this.id);
            this.Controls.Add(this.user);
            this.Controls.Add(this.richTextBoxbilan);
            this.Controls.Add(this.bilan);
            this.Controls.Add(this.comboBoxechantillon);
            this.Controls.Add(this.textBoxquantite);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ajoutercr);
            this.Controls.Add(this.retourcr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxmotif);
            this.Controls.Add(this.medecincr);
            this.Controls.Add(this.daterdv);
            this.Controls.Add(this.comboBoxmedecin);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBoxmedecin;
        private System.Windows.Forms.Label daterdv;
        private System.Windows.Forms.Label medecincr;
        private System.Windows.Forms.TextBox textBoxmotif;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button retourcr;
        private System.Windows.Forms.Button ajoutercr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxquantite;
        private System.Windows.Forms.ComboBox comboBoxechantillon;
        private System.Windows.Forms.Label bilan;
        private System.Windows.Forms.RichTextBox richTextBoxbilan;
        private System.Windows.Forms.Label user;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Label note;
        private System.Windows.Forms.Label note1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox checkBoxrmplacant;
    }
}