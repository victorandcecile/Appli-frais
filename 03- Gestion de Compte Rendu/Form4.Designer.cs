namespace ppe3
{
    partial class Form4
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
            this.components = new System.ComponentModel.Container();
            this.comboBoxmedecin = new System.Windows.Forms.ComboBox();
            this.label1praticien = new System.Windows.Forms.Label();
            this.button1retour = new System.Windows.Forms.Button();
            this.praticDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.praticDataSet = new ppe3.praticDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.moyenne = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.praticDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.praticDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxmedecin
            // 
            this.comboBoxmedecin.FormattingEnabled = true;
            this.comboBoxmedecin.Location = new System.Drawing.Point(48, 78);
            this.comboBoxmedecin.Name = "comboBoxmedecin";
            this.comboBoxmedecin.Size = new System.Drawing.Size(121, 21);
            this.comboBoxmedecin.TabIndex = 0;
            this.comboBoxmedecin.SelectedIndexChanged += new System.EventHandler(this.comboBoxmedecin_SelectedIndexChanged);
            // 
            // label1praticien
            // 
            this.label1praticien.AutoSize = true;
            this.label1praticien.Location = new System.Drawing.Point(48, 24);
            this.label1praticien.Name = "label1praticien";
            this.label1praticien.Size = new System.Drawing.Size(56, 13);
            this.label1praticien.TabIndex = 1;
            this.label1praticien.Text = "Praticiens:";
            // 
            // button1retour
            // 
            this.button1retour.Location = new System.Drawing.Point(48, 394);
            this.button1retour.Name = "button1retour";
            this.button1retour.Size = new System.Drawing.Size(75, 23);
            this.button1retour.TabIndex = 2;
            this.button1retour.Text = "Retour";
            this.button1retour.UseVisualStyleBackColor = true;
            this.button1retour.Click += new System.EventHandler(this.button1retour_Click);
            // 
            // praticDataSetBindingSource
            // 
            this.praticDataSetBindingSource.DataSource = this.praticDataSet;
            this.praticDataSetBindingSource.Position = 0;
            // 
            // praticDataSet
            // 
            this.praticDataSet.DataSetName = "praticDataSet";
            this.praticDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nom:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Prénom:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Spécialisation:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Rue:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Numéro de rue:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Code Postal:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(131, 136);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(131, 163);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 11;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(131, 194);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 12;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(131, 224);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 13;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(131, 250);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 14;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(131, 276);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(82, 316);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Note:";
            // 
            // moyenne
            // 
            this.moyenne.Location = new System.Drawing.Point(131, 313);
            this.moyenne.Name = "moyenne";
            this.moyenne.Size = new System.Drawing.Size(28, 20);
            this.moyenne.TabIndex = 17;

            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 448);
            this.Controls.Add(this.moyenne);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1retour);
            this.Controls.Add(this.label1praticien);
            this.Controls.Add(this.comboBoxmedecin);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.praticDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.praticDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxmedecin;
        private System.Windows.Forms.Label label1praticien;
        private System.Windows.Forms.Button button1retour;
        private System.Windows.Forms.BindingSource praticDataSetBindingSource;
        private praticDataSet praticDataSet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox moyenne;
    }
}