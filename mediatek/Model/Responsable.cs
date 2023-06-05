namespace mediatek.Model
{
    /// <summary>
    /// classe métier liée à la table Responsable
    /// </summary>
    public class Responsable
    {
        /// <summary>
        /// valorise les propriétés
        /// </summary>
        /// <param name="login"></param>
        /// <param name="pwd"></param>
        public Responsable(string login, string pwd)
        {
            this.Login = login;
            this.Pwd = pwd;

        }

        /// <summary>
        /// getter et setter sur Login
        /// </summary>
        public string Login { get; set; }

        /// <summary>
        /// getter et setter sur Pwd
        /// </summary>
        public string Pwd { get; set; }
    }
}