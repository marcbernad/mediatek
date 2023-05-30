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
        /// <param name="idPersonnel"></param>
        /// <param name="idMotif"></param>
        /// <param name="dateDebut"></param>
        /// <param name="dateFin"></param>
        public Absence(int idPersonnel, int idMotif, DateTime dateDebut, DateTime dateFin)
        {
            this.IdPersonnel = idPersonnel;
            this.IdMotif = idMotif;
            this.DateDebut = dateDebut;
            this.DateFin = dateFin;

        }

        /// <summary>
        /// getter sur IdPersonnel
        /// </summary>
        public int IdPersonnel { get; }

        /// <summary>
        /// getter sur IdMotif
        /// </summary>
        public int IdMotif { get; }

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