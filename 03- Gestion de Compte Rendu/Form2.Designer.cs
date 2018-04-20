namespace ppe3
{
    partial class Form2
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
            this.quesouhaitezvousfaire = new System.Windows.Forms.Label();
            this.linklabelsaisiecr = new System.Windows.Forms.LinkLabel();
            this.linklabelpraticiens = new System.Windows.Forms.LinkLabel();
            this.linklabelmedicaments = new System.Windows.Forms.LinkLabel();
            this.retourconnexion = new System.Windows.Forms.Button();
            this.consultecr = new System.Windows.Forms.LinkLabel();
            this.labelbienvenue = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // quesouhaitezvousfaire
            // 
            this.quesouhaitezvousfaire.AutoSize = true;
            this.quesouhaitezvousfaire.Location = new System.Drawing.Point(66, 46);
            this.quesouhaitezvousfaire.Name = "quesouhaitezvousfaire";
            this.quesouhaitezvousfaire.Size = new System.Drawing.Size(130, 13);
            this.quesouhaitezvousfaire.TabIndex = 0;
            this.quesouhaitezvousfaire.Text = "Que souhaitez-vous faire?";
            // 
            // linklabelsaisiecr
            // 
            this.linklabelsaisiecr.AutoSize = true;
            this.linklabelsaisiecr.Location = new System.Drawing.Point(66, 92);
            this.linklabelsaisiecr.Name = "linklabelsaisiecr";
            this.linklabelsaisiecr.Size = new System.Drawing.Size(121, 13);
            this.linklabelsaisiecr.TabIndex = 1;
            this.linklabelsaisiecr.TabStop = true;
            this.linklabelsaisiecr.Text = "Saisir un Compte Rendu";
            this.linklabelsaisiecr.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklabelcompterendu_LinkClicked);
            // 
            // linklabelpraticiens
            // 
            this.linklabelpraticiens.AutoSize = true;
            this.linklabelpraticiens.Location = new System.Drawing.Point(66, 134);
            this.linklabelpraticiens.Name = "linklabelpraticiens";
            this.linklabelpraticiens.Size = new System.Drawing.Size(121, 13);
            this.linklabelpraticiens.TabIndex = 2;
            this.linklabelpraticiens.TabStop = true;
            this.linklabelpraticiens.Text = "Rechercher un praticien";
            this.linklabelpraticiens.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklabelpraticiens_LinkClicked);
            // 
            // linklabelmedicaments
            // 
            this.linklabelmedicaments.AutoSize = true;
            this.linklabelmedicaments.Location = new System.Drawing.Point(66, 179);
            this.linklabelmedicaments.Name = "linklabelmedicaments";
            this.linklabelmedicaments.Size = new System.Drawing.Size(139, 13);
            this.linklabelmedicaments.TabIndex = 3;
            this.linklabelmedicaments.TabStop = true;
            this.linklabelmedicaments.Text = "Se renseigner sur un produit";
            this.linklabelmedicaments.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklabelmedicaments_LinkClicked);
            // 
            // retourconnexion
            // 
            this.retourconnexion.Location = new System.Drawing.Point(72, 326);
            this.retourconnexion.Name = "retourconnexion";
            this.retourconnexion.Size = new System.Drawing.Size(100, 23);
            this.retourconnexion.TabIndex = 4;
            this.retourconnexion.Text = "Se déconnecter";
            this.retourconnexion.UseVisualStyleBackColor = true;
            this.retourconnexion.Click += new System.EventHandler(this.retourconnexion_Click);
            // 
            // consultecr
            // 
            this.consultecr.AutoSize = true;
            this.consultecr.Location = new System.Drawing.Point(66, 219);
            this.consultecr.Name = "consultecr";
            this.consultecr.Size = new System.Drawing.Size(193, 13);
            this.consultecr.TabIndex = 5;
            this.consultecr.TabStop = true;
            this.consultecr.Text = "Consulter/Modifier les Comptes Rendus";
            this.consultecr.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.consultecr_LinkClicked);
            // 
            // labelbienvenue
            // 
            this.labelbienvenue.AutoSize = true;
            this.labelbienvenue.Location = new System.Drawing.Point(360, 13);
            this.labelbienvenue.Name = "labelbienvenue";
            this.labelbienvenue.Size = new System.Drawing.Size(58, 13);
            this.labelbienvenue.TabIndex = 6;
            this.labelbienvenue.Text = "Bienvenue";
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.Location = new System.Drawing.Point(414, 13);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(27, 13);
            this.user.TabIndex = 7;
            this.user.Text = "user";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 422);
            this.Controls.Add(this.user);
            this.Controls.Add(this.labelbienvenue);
            this.Controls.Add(this.consultecr);
            this.Controls.Add(this.retourconnexion);
            this.Controls.Add(this.linklabelmedicaments);
            this.Controls.Add(this.linklabelpraticiens);
            this.Controls.Add(this.linklabelsaisiecr);
            this.Controls.Add(this.quesouhaitezvousfaire);
            this.Name = "Form2";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label quesouhaitezvousfaire;
        private System.Windows.Forms.LinkLabel linklabelsaisiecr;
        private System.Windows.Forms.LinkLabel linklabelpraticiens;
        private System.Windows.Forms.LinkLabel linklabelmedicaments;
        private System.Windows.Forms.Button retourconnexion;
        private System.Windows.Forms.LinkLabel consultecr;
        private System.Windows.Forms.Label labelbienvenue;
        private System.Windows.Forms.Label user;
    }
}