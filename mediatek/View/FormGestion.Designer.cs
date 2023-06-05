namespace mediatek.View
{
    /// <summary>
    /// formulaire de gestion
    /// </summary>
    partial class FormGestion
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
            this.grbPersonnel = new System.Windows.Forms.GroupBox();
            this.btnAfficherPersonnel = new System.Windows.Forms.Button();
            this.btnSupprimerPersonnel = new System.Windows.Forms.Button();
            this.btnModifierPersonnel = new System.Windows.Forms.Button();
            this.grbAbsences = new System.Windows.Forms.GroupBox();
            this.btnSupprimerAbsences = new System.Windows.Forms.Button();
            this.btnAfficherAbsences = new System.Windows.Forms.Button();
            this.btnModifierAbsences = new System.Windows.Forms.Button();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.cboService = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grbSaisiePersonnel = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.grbSaisieAbsences = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboMotif = new System.Windows.Forms.ComboBox();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.dtpDebut = new System.Windows.Forms.DateTimePicker();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.dgvPersonnel = new System.Windows.Forms.DataGridView();
            this.lblAffichage = new System.Windows.Forms.Label();
            this.grbPersonnel.SuspendLayout();
            this.grbAbsences.SuspendLayout();
            this.grbSaisiePersonnel.SuspendLayout();
            this.grbSaisieAbsences.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnel)).BeginInit();
            this.SuspendLayout();
            // 
            // grbPersonnel
            // 
            this.grbPersonnel.Controls.Add(this.btnAfficherPersonnel);
            this.grbPersonnel.Controls.Add(this.btnSupprimerPersonnel);
            this.grbPersonnel.Controls.Add(this.btnModifierPersonnel);
            this.grbPersonnel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbPersonnel.Location = new System.Drawing.Point(935, 30);
            this.grbPersonnel.Name = "grbPersonnel";
            this.grbPersonnel.Size = new System.Drawing.Size(322, 305);
            this.grbPersonnel.TabIndex = 1;
            this.grbPersonnel.TabStop = false;
            this.grbPersonnel.Text = "Personnel";
            // 
            // btnAfficherPersonnel
            // 
            this.btnAfficherPersonnel.Location = new System.Drawing.Point(78, 60);
            this.btnAfficherPersonnel.Name = "btnAfficherPersonnel";
            this.btnAfficherPersonnel.Size = new System.Drawing.Size(169, 44);
            this.btnAfficherPersonnel.TabIndex = 19;
            this.btnAfficherPersonnel.Text = "afficher";
            this.btnAfficherPersonnel.UseVisualStyleBackColor = true;
            this.btnAfficherPersonnel.Click += new System.EventHandler(this.btnAfficherPersonnel_Click);
            // 
            // btnSupprimerPersonnel
            // 
            this.btnSupprimerPersonnel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSupprimerPersonnel.Location = new System.Drawing.Point(78, 221);
            this.btnSupprimerPersonnel.Name = "btnSupprimerPersonnel";
            this.btnSupprimerPersonnel.Size = new System.Drawing.Size(169, 44);
            this.btnSupprimerPersonnel.TabIndex = 3;
            this.btnSupprimerPersonnel.Text = "supprimer";
            this.btnSupprimerPersonnel.UseVisualStyleBackColor = false;
            this.btnSupprimerPersonnel.Click += new System.EventHandler(this.btnSupprimerPersonnel_Click);
            // 
            // btnModifierPersonnel
            // 
            this.btnModifierPersonnel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnModifierPersonnel.Location = new System.Drawing.Point(78, 139);
            this.btnModifierPersonnel.Name = "btnModifierPersonnel";
            this.btnModifierPersonnel.Size = new System.Drawing.Size(169, 44);
            this.btnModifierPersonnel.TabIndex = 2;
            this.btnModifierPersonnel.Text = "modifier";
            this.btnModifierPersonnel.UseVisualStyleBackColor = false;
            this.btnModifierPersonnel.Click += new System.EventHandler(this.btnModifierPersonnel_Click);
            // 
            // grbAbsences
            // 
            this.grbAbsences.Controls.Add(this.btnSupprimerAbsences);
            this.grbAbsences.Controls.Add(this.btnAfficherAbsences);
            this.grbAbsences.Controls.Add(this.btnModifierAbsences);
            this.grbAbsences.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbAbsences.Location = new System.Drawing.Point(935, 370);
            this.grbAbsences.Name = "grbAbsences";
            this.grbAbsences.Size = new System.Drawing.Size(322, 291);
            this.grbAbsences.TabIndex = 2;
            this.grbAbsences.TabStop = false;
            this.grbAbsences.Text = "Absences";
            // 
            // btnSupprimerAbsences
            // 
            this.btnSupprimerAbsences.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSupprimerAbsences.Location = new System.Drawing.Point(78, 219);
            this.btnSupprimerAbsences.Name = "btnSupprimerAbsences";
            this.btnSupprimerAbsences.Size = new System.Drawing.Size(169, 44);
            this.btnSupprimerAbsences.TabIndex = 6;
            this.btnSupprimerAbsences.Text = "supprimer";
            this.btnSupprimerAbsences.UseVisualStyleBackColor = false;
            this.btnSupprimerAbsences.Click += new System.EventHandler(this.btnSupprimerAbsences_Click);
            // 
            // btnAfficherAbsences
            // 
            this.btnAfficherAbsences.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAfficherAbsences.Location = new System.Drawing.Point(78, 56);
            this.btnAfficherAbsences.Name = "btnAfficherAbsences";
            this.btnAfficherAbsences.Size = new System.Drawing.Size(169, 44);
            this.btnAfficherAbsences.TabIndex = 3;
            this.btnAfficherAbsences.Text = "afficher";
            this.btnAfficherAbsences.UseVisualStyleBackColor = false;
            this.btnAfficherAbsences.Click += new System.EventHandler(this.btnAfficherAbsences_Click);
            // 
            // btnModifierAbsences
            // 
            this.btnModifierAbsences.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnModifierAbsences.Location = new System.Drawing.Point(78, 137);
            this.btnModifierAbsences.Name = "btnModifierAbsences";
            this.btnModifierAbsences.Size = new System.Drawing.Size(169, 44);
            this.btnModifierAbsences.TabIndex = 5;
            this.btnModifierAbsences.Text = "modifier";
            this.btnModifierAbsences.UseVisualStyleBackColor = false;
            this.btnModifierAbsences.Click += new System.EventHandler(this.btnModifierAbsences_Click);
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(101, 43);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(285, 30);
            this.txtNom.TabIndex = 3;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(101, 110);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(285, 30);
            this.txtPrenom.TabIndex = 4;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(101, 176);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(285, 30);
            this.txtTel.TabIndex = 5;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(101, 233);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(285, 30);
            this.txtMail.TabIndex = 6;
            // 
            // cboService
            // 
            this.cboService.FormattingEnabled = true;
            this.cboService.Location = new System.Drawing.Point(101, 298);
            this.cboService.Name = "cboService";
            this.cboService.Size = new System.Drawing.Size(285, 33);
            this.cboService.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "nom : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "prénom :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "tel : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "mail :";
            // 
            // grbSaisiePersonnel
            // 
            this.grbSaisiePersonnel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.grbSaisiePersonnel.Controls.Add(this.label8);
            this.grbSaisiePersonnel.Controls.Add(this.txtNom);
            this.grbSaisiePersonnel.Controls.Add(this.label4);
            this.grbSaisiePersonnel.Controls.Add(this.txtPrenom);
            this.grbSaisiePersonnel.Controls.Add(this.label3);
            this.grbSaisiePersonnel.Controls.Add(this.txtTel);
            this.grbSaisiePersonnel.Controls.Add(this.label2);
            this.grbSaisiePersonnel.Controls.Add(this.txtMail);
            this.grbSaisiePersonnel.Controls.Add(this.label1);
            this.grbSaisiePersonnel.Controls.Add(this.cboService);
            this.grbSaisiePersonnel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbSaisiePersonnel.Location = new System.Drawing.Point(48, 588);
            this.grbSaisiePersonnel.Name = "grbSaisiePersonnel";
            this.grbSaisiePersonnel.Size = new System.Drawing.Size(413, 380);
            this.grbSaisiePersonnel.TabIndex = 12;
            this.grbSaisiePersonnel.TabStop = false;
            this.grbSaisiePersonnel.Text = "Saisie personnel :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 301);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 25);
            this.label8.TabIndex = 14;
            this.label8.Text = "service :";
            // 
            // grbSaisieAbsences
            // 
            this.grbSaisieAbsences.Controls.Add(this.label7);
            this.grbSaisieAbsences.Controls.Add(this.label5);
            this.grbSaisieAbsences.Controls.Add(this.label6);
            this.grbSaisieAbsences.Controls.Add(this.cboMotif);
            this.grbSaisieAbsences.Controls.Add(this.dtpFin);
            this.grbSaisieAbsences.Controls.Add(this.dtpDebut);
            this.grbSaisieAbsences.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbSaisieAbsences.Location = new System.Drawing.Point(504, 588);
            this.grbSaisieAbsences.Name = "grbSaisieAbsences";
            this.grbSaisieAbsences.Size = new System.Drawing.Size(370, 380);
            this.grbSaisieAbsences.TabIndex = 13;
            this.grbSaisieAbsences.TabStop = false;
            this.grbSaisieAbsences.Text = "Saisie Absences :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 304);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "motif :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "date début :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "date fin :";
            // 
            // cboMotif
            // 
            this.cboMotif.FormattingEnabled = true;
            this.cboMotif.Location = new System.Drawing.Point(142, 301);
            this.cboMotif.Name = "cboMotif";
            this.cboMotif.Size = new System.Drawing.Size(200, 33);
            this.cboMotif.TabIndex = 14;
            // 
            // dtpFin
            // 
            this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFin.Location = new System.Drawing.Point(142, 202);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(200, 30);
            this.dtpFin.TabIndex = 14;
            // 
            // dtpDebut
            // 
            this.dtpDebut.CustomFormat = "";
            this.dtpDebut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDebut.Location = new System.Drawing.Point(142, 90);
            this.dtpDebut.Name = "dtpDebut";
            this.dtpDebut.Size = new System.Drawing.Size(200, 30);
            this.dtpDebut.TabIndex = 14;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.Location = new System.Drawing.Point(992, 849);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(216, 50);
            this.btnAnnuler.TabIndex = 14;
            this.btnAnnuler.Text = "annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnregistrer.Location = new System.Drawing.Point(992, 725);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(216, 50);
            this.btnEnregistrer.TabIndex = 15;
            this.btnEnregistrer.Text = "enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // dgvPersonnel
            // 
            this.dgvPersonnel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonnel.Location = new System.Drawing.Point(59, 77);
            this.dgvPersonnel.Name = "dgvPersonnel";
            this.dgvPersonnel.RowHeadersWidth = 62;
            this.dgvPersonnel.RowTemplate.Height = 28;
            this.dgvPersonnel.Size = new System.Drawing.Size(854, 491);
            this.dgvPersonnel.TabIndex = 16;
            // 
            // lblAffichage
            // 
            this.lblAffichage.AutoSize = true;
            this.lblAffichage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAffichage.Location = new System.Drawing.Point(55, 30);
            this.lblAffichage.Name = "lblAffichage";
            this.lblAffichage.Size = new System.Drawing.Size(236, 29);
            this.lblAffichage.TabIndex = 17;
            this.lblAffichage.Text = "Liste des personnels";
            // 
            // FormGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 997);
            this.Controls.Add(this.lblAffichage);
            this.Controls.Add(this.dgvPersonnel);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.grbSaisieAbsences);
            this.Controls.Add(this.grbSaisiePersonnel);
            this.Controls.Add(this.grbAbsences);
            this.Controls.Add(this.grbPersonnel);
            this.Name = "FormGestion";
            this.Text = "Gestion personnel";
            this.grbPersonnel.ResumeLayout(false);
            this.grbAbsences.ResumeLayout(false);
            this.grbSaisiePersonnel.ResumeLayout(false);
            this.grbSaisiePersonnel.PerformLayout();
            this.grbSaisieAbsences.ResumeLayout(false);
            this.grbSaisieAbsences.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grbPersonnel;
        private System.Windows.Forms.Button btnSupprimerPersonnel;
        private System.Windows.Forms.Button btnModifierPersonnel;
        private System.Windows.Forms.GroupBox grbAbsences;
        private System.Windows.Forms.Button btnSupprimerAbsences;
        private System.Windows.Forms.Button btnAfficherAbsences;
        private System.Windows.Forms.Button btnModifierAbsences;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.ComboBox cboService;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grbSaisiePersonnel;
        private System.Windows.Forms.GroupBox grbSaisieAbsences;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboMotif;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.DateTimePicker dtpDebut;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.DataGridView dgvPersonnel;
        private System.Windows.Forms.Label lblAffichage;
        private System.Windows.Forms.Button btnAfficherPersonnel;
    }
}