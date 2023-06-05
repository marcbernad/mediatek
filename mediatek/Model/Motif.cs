namespace mediatek.Model
{
    /// <summary>
    /// classe métier liée à la table motif
    /// </summary>
    public class Motif
    {
        /// <summary>
        /// valorise les propriétés
        /// </summary>
        /// <param name="idMotif"></param>
        /// <param name="libelle"></param>
        public Motif(int idMotif, string libelle)
        {
            this.IdMotif = idMotif;
            this.Libelle = libelle;

        }

        /// <summary>
        /// getter sur IdMotif
        /// </summary>
        public int IdMotif { get; }

        /// <summary>
        /// getter et setter sur Libelle
        /// </summary>
        public string Libelle { get; set; }

        /// <summary>
        /// Définit l'information à afficher (juste le libelle)
        /// </summary>
        /// <returns>libelle du motif</returns>
        public override string ToString()
        {
            return this.Libelle;
        }
    }
}
