using mediatek.Model;
using mediatek.controller;
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
    public partial class FormConnexion : Form
    {
        /// <summary>
        /// Contrôleur de la fenêtre
        /// </summary>
        private FormConnexionController controller;

        /// <summary>
        /// Conrtuction des composants graphiques et appel des autres initialisations
        /// </summary>
        public FormConnexion()
        {
            InitializeComponent();
            Init();
        }

        /// <summary>
        /// Initialisations : 
        /// Création du controleur
        /// </summary>
        private void Init()
        {
            controller = new FormConnexionController();
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            String login = txtLogin.Text;
            String pwd = txtPwd.Text;
            if (String.IsNullOrEmpty(login) || String.IsNullOrEmpty(pwd))
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Information");
            }
            else
            {
                Responsable responsable = new Responsable(login, pwd);
                if (controller.ControleAuthentification(responsable))
                {
                    FormGestion frm = new FormGestion();
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Authentification incorrecte", "Alerte");
                }
            }
        }
    }
}
