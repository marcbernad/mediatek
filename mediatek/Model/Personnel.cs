using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediatek.Model
{
    /// <summary>
    /// classe métier liée à la table Personnel
    /// </summary>
    public class Personnel
    {
        /// <summary>
        /// valorise les propriétés
        /// </summary>
        /// <param name="idpersonnel"></param>
        /// <param name="idservice"></param>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="tel"></param>
        /// <param name="mail"></param>
        public Personnel(int idpersonnel, int idservice, string nom, string prenom, string tel, string mail)
        {
            this.Idpersonnel = idpersonnel;
            this.Idservice = idservice;
            this.Nom = nom;
            this.Prenom = prenom;
            this.Tel = tel;
            this.Mail = mail;
        }

        /// <summary>
        /// getter sur IdPersonnel
        /// </summary>
        public int Idpersonnel { get; }

        /// <summary>
        /// getter sur IdService
        /// </summary>
        public int Idservice { get; }

        /// <summary>
        /// getter et setter sur Nom
        /// </summary>
        public string Nom { get; set; }

        /// <summary>
        /// getter et setter sur Prenom
        /// </summary>
        public string Prenom { get; set; }

        /// <summary>
        /// getter et setter sur Tel
        /// </summary>
        public string Tel { get; set; }

        /// <summary>
        /// getter et setter sur Mail
        /// </summary>
        public string Mail { get; set; }
    }
}