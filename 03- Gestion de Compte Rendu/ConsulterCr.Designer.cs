namespace ppe3
{
    partial class ConsulterCr
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
            this.comboBox1visiteurs = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.comboboxcr = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonretour = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxregion = new System.Windows.Forms.ComboBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.compteRenduBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.praticDataSet = new ppe3.praticDataSet();
            this.praticDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.compteRenduTableAdapter = new ppe3.praticDataSetTableAdapters.CompteRenduTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.compteRenduBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.praticDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.praticDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1visiteurs
            // 
            this.comboBox1visiteurs.FormattingEnabled = true;
            this.comboBox1visiteurs.Location = new System.Drawing.Point(88, 68);
            this.comboBox1visiteurs.Name = "comboBox1visiteurs";
            this.comboBox1visiteurs.Size = new System.Drawing.Size(121, 21);
            this.comboBox1visiteurs.TabIndex = 0;
            this.comboBox1visiteurs.SelectedIndexChanged += new System.EventHandler(this.comboBox1visiteurs_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Visiteurs:";
            // 
            // comboboxcr
            // 
            this.comboboxcr.FormattingEnabled = true;
            this.comboboxcr.Location = new System.Drawing.Point(88, 112);
            this.comboboxcr.Name = "comboboxcr";
            this.comboboxcr.Size = new System.Drawing.Size(121, 21);
            this.comboboxcr.TabIndex = 3;
            this.comboboxcr.SelectedIndexChanged += new System.EventHandler(this.comboboxcr_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Compte rendu:";
            // 
            // buttonretour
            // 
            this.buttonretour.Location = new System.Drawing.Point(36, 259);
            this.buttonretour.Name = "buttonretour";
            this.buttonretour.Size = new System.Drawing.Size(75, 23);
            this.buttonretour.TabIndex = 5;
            this.buttonretour.Text = "Retour";
            this.buttonretour.UseVisualStyleBackColor = true;
            this.buttonretour.Click += new System.EventHandler(this.buttonretour_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Région:";
            // 
            // comboBoxregion
            // 
            this.comboBoxregion.FormattingEnabled = true;
            this.comboBoxregion.Location = new System.Drawing.Point(88, 23);
            this.comboBoxregion.Name = "comboBoxregion";
            this.comboBoxregion.Size = new System.Drawing.Size(121, 21);
            this.comboBoxregion.TabIndex = 7;
            this.comboBoxregion.SelectedIndexChanged += new System.EventHandler(this.comboBoxregion_SelectedIndexChanged);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(350, 252);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(257, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Spécialisation:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(350, 204);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(257, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Quantité:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(350, 111);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 33;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(350, 68);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 32;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(350, 26);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 31;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(350, 157);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 30;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(582, 26);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(193, 227);
            this.richTextBox1.TabIndex = 29;
            this.richTextBox1.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(508, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Bilan:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(258, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Echantillon:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(258, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Motif:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(258, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Praticien:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(258, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Date:";
            // 
            // compteRenduBindingSource
            // 
            this.compteRenduBindingSource.DataMember = "CompteRendu";
            this.compteRenduBindingSource.DataSource = this.praticDataSet;
            // 
            // praticDataSet
            // 
            this.praticDataSet.DataSetName = "praticDataSet";
            this.praticDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // praticDataSetBindingSource
            // 
            this.praticDataSetBindingSource.DataSource = this.praticDataSet;
            this.praticDataSetBindingSource.Position = 0;
            // 
            // compteRenduTableAdapter
            // 
            this.compteRenduTableAdapter.ClearBeforeFill = true;
            // 
            // ConsulterCr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 320);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboBoxregion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonretour);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboboxcr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1visiteurs);
            this.Name = "ConsulterCr";
            this.Text = "ConsulterCr";
            this.Load += new System.EventHandler(this.ConsulterCr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.compteRenduBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.praticDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.praticDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1visiteurs;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.ComboBox comboboxcr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonretour;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxregion;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.BindingSource praticDataSetBindingSource;
        private praticDataSet praticDataSet;
        private System.Windows.Forms.BindingSource compteRenduBindingSource;
        private praticDataSetTableAdapters.CompteRenduTableAdapter compteRenduTableAdapter;
    }
}