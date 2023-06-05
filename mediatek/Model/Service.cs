using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediatek.Model
{
    /// <summary>
    /// classe métier liée à la table Service
    /// </summary>
    public class Service
    {
        /// <summary>
        /// valorise les propriétés
        /// </summary>
        /// <param name="idservice"></param>
        /// <param name="nom"></param>
        public Service(int idservice, string nom)
        {
            this.Idservice = idservice;
            this.Nom = nom;
        }

        /// <summary>
        /// getter sur IdService
        /// </summary>
        public int Idservice { get; }

        /// <summary>
        /// getter et setter sur Nom
        /// </summary>
        public string Nom { get; set; }


        /// <summary>
        /// Définit l'information à afficher (juste le nom)
        /// </summary>
        /// <returns>nom du service</returns>
        public override string ToString()
        {
            return this.Nom;
        }
    }
}
