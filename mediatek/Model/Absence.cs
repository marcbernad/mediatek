using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediatek.Model
{
    /// <summary>
    /// Classe métier liée à la table Absence
    /// </summary>
    public class Absence
    {
        /// <summary>
        /// valorise les propriétés
        /// </summary>
        /// <param name="idpersonnel"></param>
        /// <param name="motif"></param>
        /// <param name="dateDebut"></param>
        /// <param name="dateFin"></param>
        public Absence(int idpersonnel, DateTime dateDebut, DateTime dateFin, Motif motif)
        {
            this.Idpersonnel = idpersonnel;
            this.Motif = motif;
            this.DateDebut = dateDebut;
            this.DateFin = dateFin;

        }

        /// <summary>
        /// getter sur IdPersonnel
        /// </summary>
        public int Idpersonnel { get; }

        /// <summary>
        /// getter et setter sur IdMotif
        /// </summary>
        public Motif Motif { get; set; }

        /// <summary>
        /// getter et setter sur DateDebut
        /// </summary>
        public DateTime DateDebut { get; set; }

        /// <summary>
        /// getter et setter sur DateFin
        /// </summary>
        public DateTime DateFin { get; set; }
    }
}