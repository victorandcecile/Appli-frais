namespace ppe3
{
    partial class Form8
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
            this.bilan = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.medecincr = new System.Windows.Forms.Label();
            this.daterdv = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.retourcr = new System.Windows.Forms.Button();
            this.ajoutercr = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox1mot = new System.Windows.Forms.TextBox();
            this.richTextBox1bil = new System.Windows.Forms.RichTextBox();
            this.textBox2quant = new System.Windows.Forms.TextBox();
            this.comboBox1med = new System.Windows.Forms.ComboBox();
            this.comboBox2ech = new System.Windows.Forms.ComboBox();
            this.user = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.note1 = new System.Windows.Forms.Label();
            this.note = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bilan
            // 
            this.bilan.AutoSize = true;
            this.bilan.Location = new System.Drawing.Point(34, 223);
            this.bilan.Name = "bilan";
            this.bilan.Size = new System.Drawing.Size(33, 13);
            this.bilan.TabIndex = 29;
            this.bilan.Text = "Bilan:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 372);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Quantité:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Echantillon:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Motif:";
            // 
            // medecincr
            // 
            this.medecincr.AutoSize = true;
            this.medecincr.Location = new System.Drawing.Point(34, 134);
            this.medecincr.Name = "medecincr";
            this.medecincr.Size = new System.Drawing.Size(51, 13);
            this.medecincr.TabIndex = 20;
            this.medecincr.Text = "Medecin:";
            // 
            // daterdv
            // 
            this.daterdv.AutoSize = true;
            this.daterdv.Location = new System.Drawing.Point(34, 83);
            this.daterdv.Name = "daterdv";
            this.daterdv.Size = new System.Drawing.Size(33, 13);
            this.daterdv.TabIndex = 19;
            this.daterdv.Text = "Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Rapports de Visite";
            // 
            // retourcr
            // 
            this.retourcr.Location = new System.Drawing.Point(266, 405);
            this.retourcr.Name = "retourcr";
            this.retourcr.Size = new System.Drawing.Size(75, 23);
            this.retourcr.TabIndex = 23;
            this.retourcr.Text = "Retour";
            this.retourcr.UseVisualStyleBackColor = true;
            this.retourcr.Click += new System.EventHandler(this.retourcr_Click);
            // 
            // ajoutercr
            // 
            this.ajoutercr.Location = new System.Drawing.Point(361, 405);
            this.ajoutercr.Name = "ajoutercr";
            this.ajoutercr.Size = new System.Drawing.Size(142, 23);
            this.ajoutercr.TabIndex = 24;
            this.ajoutercr.Text = "Ajouter le Compte Rendu";
            this.ajoutercr.UseVisualStyleBackColor = true;
            this.ajoutercr.Click += new System.EventHandler(this.ajoutercr_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(94, 83);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 30;
            // 
            // textBox1mot
            // 
            this.textBox1mot.Location = new System.Drawing.Point(94, 175);
            this.textBox1mot.Name = "textBox1mot";
            this.textBox1mot.Size = new System.Drawing.Size(258, 20);
            this.textBox1mot.TabIndex = 31;
            // 
            // richTextBox1bil
            // 
            this.richTextBox1bil.Location = new System.Drawing.Point(94, 220);
            this.richTextBox1bil.Name = "richTextBox1bil";
            this.richTextBox1bil.Size = new System.Drawing.Size(247, 96);
            this.richTextBox1bil.TabIndex = 32;
            this.richTextBox1bil.Text = "";
            // 
            // textBox2quant
            // 
            this.textBox2quant.Location = new System.Drawing.Point(94, 369);
            this.textBox2quant.Name = "textBox2quant";
            this.textBox2quant.Size = new System.Drawing.Size(100, 20);
            this.textBox2quant.TabIndex = 33;
            // 
            // comboBox1med
            // 
            this.comboBox1med.FormattingEnabled = true;
            this.comboBox1med.Location = new System.Drawing.Point(94, 131);
            this.comboBox1med.Name = "comboBox1med";
            this.comboBox1med.Size = new System.Drawing.Size(121, 21);
            this.comboBox1med.TabIndex = 34;
            // 
            // comboBox2ech
            // 
            this.comboBox2ech.FormattingEnabled = true;
            this.comboBox2ech.Location = new System.Drawing.Point(94, 335);
            this.comboBox2ech.Name = "comboBox2ech";
            this.comboBox2ech.Size = new System.Drawing.Size(121, 21);
            this.comboBox2ech.TabIndex = 35;
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.Location = new System.Drawing.Point(638, 27);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(27, 13);
            this.user.TabIndex = 36;
            this.user.Text = "user";
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(641, 44);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(15, 13);
            this.id.TabIndex = 37;
            this.id.Text = "id";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(550, 219);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(34, 21);
            this.comboBox1.TabIndex = 40;
            // 
            // note1
            // 
            this.note1.AutoSize = true;
            this.note1.Location = new System.Drawing.Point(590, 223);
            this.note1.Name = "note1";
            this.note1.Size = new System.Drawing.Size(24, 13);
            this.note1.TabIndex = 39;
            this.note1.Text = "/10";
            // 
            // note
            // 
            this.note.AutoSize = true;
            this.note.Location = new System.Drawing.Point(513, 220);
            this.note.Name = "note";
            this.note.Size = new System.Drawing.Size(33, 13);
            this.note.TabIndex = 38;
            this.note.Text = "Note:";
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 502);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.note1);
            this.Controls.Add(this.note);
            this.Controls.Add(this.id);
            this.Controls.Add(this.user);
            this.Controls.Add(this.comboBox2ech);
            this.Controls.Add(this.comboBox1med);
            this.Controls.Add(this.textBox2quant);
            this.Controls.Add(this.richTextBox1bil);
            this.Controls.Add(this.textBox1mot);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.bilan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ajoutercr);
            this.Controls.Add(this.retourcr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.medecincr);
            this.Controls.Add(this.daterdv);
            this.Controls.Add(this.label1);
            this.Name = "Form8";
            this.Text = "Form8";
            this.Load += new System.EventHandler(this.Form8_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label bilan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label medecincr;
        private System.Windows.Forms.Label daterdv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button retourcr;
        private System.Windows.Forms.Button ajoutercr;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1mot;
        private System.Windows.Forms.RichTextBox richTextBox1bil;
        private System.Windows.Forms.TextBox textBox2quant;
        private System.Windows.Forms.ComboBox comboBox1med;
        private System.Windows.Forms.ComboBox comboBox2ech;
        private System.Windows.Forms.Label user;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label note1;
        private System.Windows.Forms.Label note;
    }
}