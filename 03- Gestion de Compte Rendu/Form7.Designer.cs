namespace ppe3
{
    partial class accueil_delegue
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
            this.buttonretour = new System.Windows.Forms.Button();
            this.linkLabelconsultevisite = new System.Windows.Forms.LinkLabel();
            this.linkLabelconsultecr = new System.Windows.Forms.LinkLabel();
            this.linkLabelsaisiecr = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonretour
            // 
            this.buttonretour.Location = new System.Drawing.Point(44, 319);
            this.buttonretour.Name = "buttonretour";
            this.buttonretour.Size = new System.Drawing.Size(96, 23);
            this.buttonretour.TabIndex = 0;
            this.buttonretour.Text = "Se déconnecter";
            this.buttonretour.UseVisualStyleBackColor = true;
            this.buttonretour.Click += new System.EventHandler(this.buttonretour_Click);
            // 
            // linkLabelconsultevisite
            // 
            this.linkLabelconsultevisite.AutoSize = true;
            this.linkLabelconsultevisite.Location = new System.Drawing.Point(41, 57);
            this.linkLabelconsultevisite.Name = "linkLabelconsultevisite";
            this.linkLabelconsultevisite.Size = new System.Drawing.Size(115, 13);
            this.linkLabelconsultevisite.TabIndex = 1;
            this.linkLabelconsultevisite.TabStop = true;
            this.linkLabelconsultevisite.Text = "Saisir un compte rendu";
            this.linkLabelconsultevisite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelconsultevisite_LinkClicked);
            // 
            // linkLabelconsultecr
            // 
            this.linkLabelconsultecr.AutoSize = true;
            this.linkLabelconsultecr.Location = new System.Drawing.Point(41, 96);
            this.linkLabelconsultecr.Name = "linkLabelconsultecr";
            this.linkLabelconsultecr.Size = new System.Drawing.Size(145, 13);
            this.linkLabelconsultecr.TabIndex = 2;
            this.linkLabelconsultecr.TabStop = true;
            this.linkLabelconsultecr.Text = "Consulter les comptes rendus";
            this.linkLabelconsultecr.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelconsultecr_LinkClicked);
            // 
            // linkLabelsaisiecr
            // 
            this.linkLabelsaisiecr.AutoSize = true;
            this.linkLabelsaisiecr.Location = new System.Drawing.Point(41, 139);
            this.linkLabelsaisiecr.Name = "linkLabelsaisiecr";
            this.linkLabelsaisiecr.Size = new System.Drawing.Size(0, 13);
            this.linkLabelsaisiecr.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bienvenue";
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.Location = new System.Drawing.Point(261, 13);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(27, 13);
            this.user.TabIndex = 6;
            this.user.Text = "user";
            // 
            // accueil_delegue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 374);
            this.Controls.Add(this.user);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linkLabelsaisiecr);
            this.Controls.Add(this.linkLabelconsultecr);
            this.Controls.Add(this.linkLabelconsultevisite);
            this.Controls.Add(this.buttonretour);
            this.Name = "accueil_delegue";
            this.Text = "Accueil";
            this.Load += new System.EventHandler(this.accueil_delegue_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonretour;
        private System.Windows.Forms.LinkLabel linkLabelconsultevisite;
        private System.Windows.Forms.LinkLabel linkLabelconsultecr;
        private System.Windows.Forms.LinkLabel linkLabelsaisiecr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label user;
    }
}