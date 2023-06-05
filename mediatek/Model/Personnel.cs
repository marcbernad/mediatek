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
        /// <param name="service"></param>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="tel"></param>
        /// <param name="mail"></param>
        public Personnel(int idpersonnel, string nom, string prenom, string tel, string mail, Service service)
        {
            this.Idpersonnel = idpersonnel;
            this.Nom = nom;
            this.Prenom = prenom;
            this.Tel = tel;
            this.Mail = mail;
            this.Service = service;
        }

        /// <summary>
        /// getter sur IdPersonnel
        /// </summary>
        public int Idpersonnel { get; }

        /// <summary>
        /// getter et setter sur Service
        /// </summary>
        public Service Service { get; set; }

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