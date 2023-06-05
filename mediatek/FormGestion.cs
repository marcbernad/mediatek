using mediatek.controller;
using mediatek.Model;
using mediatek.dal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mediatek
{
    /// <summary>
    /// fenêtre de gestion du personnel
    /// </summary>
    public partial class FormGestion : Form
    {
        /// <summary>
        /// Booléen pour savoir si une modification de personnel est demandée
        /// </summary>
        private Boolean enCoursDeModifPersonnel = false;
        /// <summary>
        /// Booléen pour savoir si une modification d'absence est demandée
        /// </summary>
        private Boolean enCoursDeModifAbsence = false;
        /// <summary>
        /// Objet pour gérer la liste des personnels
        /// </summary>
        private readonly BindingSource bdgPersonnel = new BindingSource();
        /// <summary>
        /// Objet pour gérer la liste des services
        /// </summary>
        private readonly BindingSource bdgService = new BindingSource();
        /// <summary>
        /// Objet pour gérer la liste des absences
        /// </summary>
        private readonly BindingSource bdgAbsence = new BindingSource();
        /// <summary>
        /// Objet pour gérer la liste des motifs
        /// </summary>
        private readonly BindingSource bdgMotif = new BindingSource();
        /// <summary>
        /// Controleur de la fenêtre
        /// </summary>
        private FormGestionController controller;


        /// <summary>
        /// Conrtuction des composants graphiques et appel des autres initialisations
        /// </summary>
        public FormGestion()
        {
            InitializeComponent();
            Init();
        }

        /// <summary>
        /// Initialisations :
        /// Création du controleur et remplissage des listes
        /// </summary>
        private void Init()
        {
            controller = new FormGestionController();
            RemplirListePersonnels();
            RemplirListeServices();
            EnCoursDeModifPersonnel(false);
        }

        /// <summary>
        /// Affiche les personnels
        /// </summary>
        private void RemplirListePersonnels()
        {
            List<Personnel> lesPersonnels = controller.GetLesPersonnels();
            bdgPersonnel.DataSource = lesPersonnels;
            dgvPersonnel.DataSource = bdgPersonnel;
            dgvPersonnel.Columns["idpersonnel"].Visible = false;
            dgvPersonnel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        /// <summary>
        /// Affiche les services
        /// </summary>
        private void RemplirListeServices()
        {
            List<Service> lesServices = controller.GetLesServices();
            bdgService.DataSource = lesServices;
            cboService.DataSource = bdgService;
        }

        private void RemplirListeMotifs()
        {
            List<Motif> lesMotifs = controller.GetLesMotifs();
            bdgMotif.DataSource = lesMotifs;
            cboMotif.DataSource = bdgMotif;
        }

        /// <summary>
        /// Affiche les absences
        /// </summary>
        private void RemplirListeAbsences(Personnel personnel)
        {
            List<Absence> lesAbsences = controller.GetLesAbsences(personnel);
            bdgAbsence.DataSource = lesAbsences;
            dgvPersonnel.DataSource = bdgAbsence;
            dgvPersonnel.Columns["idpersonnel"].Visible = false;
            dgvPersonnel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        /// <summary>
        /// Modification d'affichage suivant si on est en cours de modif ou d'ajout d'un personnel
        /// </summary>
        /// <param name="modif"></param>
        private void EnCoursDeModifPersonnel(Boolean modif)
        {
            grbSaisiePersonnel.Enabled = true;
            enCoursDeModifPersonnel = modif;
            grbPersonnel.Enabled = !modif;
            grbSaisieAbsences.Enabled = false;
            if (modif)
            {
                grbSaisiePersonnel.Text = "modifier un personnel";
            }
            else
            {
                grbSaisiePersonnel.Text = "ajouter un personnel";
                txtNom.Text = "";
                txtPrenom.Text = "";
                txtTel.Text = "";
                txtMail.Text = "";
               
            }
        }

        /// <summary>
        /// Modification d'affichage suivant si on est ou non en cours de modif des absences
        /// </summary>
        /// <param name="modif"></param>
        private void EnCoursDeModifAbsences(Boolean modif)
        {
            grbSaisiePersonnel.Enabled = false;
            grbSaisieAbsences.Enabled = true;
            enCoursDeModifAbsence = modif;

            grbAbsences.Enabled = !modif;
            if (modif)
            {
                grbSaisieAbsences.Text = "modifier une absence";
            }
            else
            {
                grbSaisieAbsences.Text = "ajouter une absence";
                dtpDebut.Value = DateTime.Today;
                dtpFin.Value = DateTime.Today.AddDays(1);
            }
        }

        private void btnModifierPersonnel_Click(object sender, EventArgs e)
        {
            if (dgvPersonnel.SelectedRows.Count > 0)
            {
                EnCoursDeModifPersonnel(true);
                Personnel personnel = (Personnel)bdgPersonnel.List[bdgPersonnel.Position];
                txtNom.Text = personnel.Nom;
                txtPrenom.Text = personnel.Prenom;
                txtTel.Text = personnel.Tel;
                txtMail.Text = personnel.Mail;
                cboService.SelectedIndex = cboService.FindStringExact(personnel.Service.Nom);
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }
        }

        /// <summary>
        /// annule l'action en cours après confirmation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment annuler ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (grbSaisiePersonnel.Enabled)
                {
                    EnCoursDeModifPersonnel(false);
                }
                else
                {
                    EnCoursDeModifAbsences(false);
                }
            }
        }

        /// <summary>
        /// supprime un personnel après confirmation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupprimerPersonnel_Click(object sender, EventArgs e)
        {
            if (dgvPersonnel.SelectedRows.Count > 0)
            {
                Personnel personnel = (Personnel)bdgPersonnel.List[bdgPersonnel.Position];
                if (MessageBox.Show("Voulez-vous vraiment supprimer " + personnel.Nom + " " + personnel.Prenom + " ?", "Confirmation de suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    controller.DelPersonnel(personnel);
                    RemplirListePersonnels();
                }
            }
            else
            {
                 MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }
        }

        /// <summary>
        /// enregistre l'action en cours
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            if (grbSaisiePersonnel.Enabled)
            {

                if (!txtNom.Text.Equals("") && !txtPrenom.Text.Equals("") && !txtTel.Text.Equals("") && !txtMail.Text.Equals("") && cboService.SelectedIndex != -1)
                {
                    Service service = (Service)bdgService.List[bdgService.Position];
                    if (enCoursDeModifPersonnel)
                    {
                        Personnel personnel = (Personnel)bdgPersonnel.List[bdgPersonnel.Position];
                        personnel.Nom = txtNom.Text;
                        personnel.Prenom = txtPrenom.Text;
                        personnel.Tel = txtTel.Text;
                        personnel.Mail = txtMail.Text;
                        personnel.Service = service;
                        if (MessageBox.Show("Voulez-vous vraiment appliquer ces modifications ?", "Confirmation de modification", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            controller.UpdatePersonnel(personnel);
                        }
                    }
                    else
                    {
                        Personnel personnel = new Personnel(0, txtNom.Text, txtPrenom.Text, txtTel.Text, txtMail.Text, service);
                        controller.AddPersonnel(personnel);
                    }
                        RemplirListePersonnels();
                        EnCoursDeModifPersonnel(false);
                }
                else
                {
                    MessageBox.Show("Tous les champs doivent être remplis.", "Information");
                }
            }
            else if (grbSaisieAbsences.Enabled)
            {
                if (dtpDebut.Value != null && dtpFin.Value != null && cboMotif.SelectedIndex != -1)
                {
                    Personnel personnelAbsence = (Personnel)bdgPersonnel.List[bdgPersonnel.Position];
                    Motif motif = (Motif)bdgMotif.List[bdgMotif.Position];
                    if (enCoursDeModifAbsence)
                    {
                        Absence absence = (Absence)bdgAbsence.List[bdgAbsence.Position];
                        absence.DateDebut = dtpDebut.Value;
                        absence.DateFin = dtpFin.Value;
                        absence.Motif = motif;
                        if (dtpDebut.Value < dtpFin.Value)
                        {
                            if (MessageBox.Show("Voulez-vous vraiment appliquer ces modifications ?", "Confirmation de modification", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                controller.UpdateAbsence(absence);
                            }
                        }
                        else
                        {
                            MessageBox.Show("La date de fin ne peut pas être antérieure à la date de début.", "Alerte");
                        }
                    }
                    else
                    {
                        Absence absence = new Absence(personnelAbsence.Idpersonnel, dtpDebut.Value, dtpFin.Value, motif);
                        if (dtpDebut.Value < dtpFin.Value)
                        {
                            controller.AddAbsence(absence);
                        }
                        else
                        {
                            MessageBox.Show("La date de fin ne peut pas être antérieure à la date de début.", "Alerte");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Tous les champs doivent être remplis.", "Information");
                }
                Personnel personnel = (Personnel)bdgPersonnel.List[bdgPersonnel.Position];
                RemplirListeAbsences(personnel);
                RemplirListeMotifs();
                EnCoursDeModifAbsences(false);
            }
        }

        private void btnAfficherAbsences_Click(object sender, EventArgs e)
        {
            if (dgvPersonnel.SelectedRows.Count > 0)
            {
                Personnel personnel = (Personnel)bdgPersonnel.List[bdgPersonnel.Position];
                RemplirListeAbsences(personnel);
                RemplirListeMotifs();
                EnCoursDeModifAbsences(false);

            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }
        }

        private void btnAfficherPersonnel_Click(object sender, EventArgs e)
        {
            RemplirListePersonnels();
            RemplirListeServices();
            EnCoursDeModifPersonnel(false);
        }

        private void btnModifierAbsences_Click(object sender, EventArgs e)
        {
            if (dgvPersonnel.SelectedRows.Count > 0)
            {
                EnCoursDeModifAbsences(true);
                Absence absence = (Absence)bdgAbsence.List[bdgAbsence.Position];
                dtpDebut.Value = absence.DateDebut;
                dtpFin.Value = absence.DateFin;
                cboMotif.SelectedIndex = cboMotif.FindStringExact(absence.Motif.Libelle);
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }
        }

        private void btnSupprimerAbsences_Click(object sender, EventArgs e)
        {
            if (dgvPersonnel.SelectedRows.Count > 0)
            {
                Absence absence = (Absence)bdgAbsence.List[bdgAbsence.Position];
                if (MessageBox.Show("Voulez-vous vraiment supprimer cette absence ?", "Confirmation de suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    controller.DelAbsence(absence);
                    Personnel personnel = (Personnel)bdgPersonnel.List[bdgPersonnel.Position];
                    RemplirListeAbsences(personnel);
                }
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }
        }
    }
}
