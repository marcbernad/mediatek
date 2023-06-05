using mediatek.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediatek.dal
{
    /// <summary>
    /// classe permettant de gérer les demandes concernant les absences
    /// </summary>
    class AbsenceAccess
    {
        /// <summary>
        /// Instance unique de l'accès aux données
        /// </summary>
        private readonly Access access = null;

        /// <summary>
        /// Constructeur pour créer l'accès aux données
        /// </summary>
        public AbsenceAccess()
        {
            access = Access.GetInstance();
        }

        /// <summary>
        /// Récupère et retourne les absences d'un personnel
        /// </summary>
        /// <returns>liste des absences d'un personnel</returns>
        public List<Absence> GetLesAbsences(Personnel personnel)
        {
            List<Absence> lesAbsences = new List<Absence>();
            if (access.Manager != null)
            {
                string req = "select a.idpersonnel, datedebut, datefin, m.idmotif, m.libelle ";
                req += "from absence a join motif m on (a.idmotif=m.idmotif) ";
                req += "join personnel p on (a.idpersonnel=p.idpersonnel) ";
                req += "where a.idpersonnel=@idpersonnel ";
                req += "order by datedebut desc;";
                Dictionary<string, object> parameters = new Dictionary<string, object> {
                    {"@idpersonnel", personnel.Idpersonnel }
                };
                try
                {
                    List<Object[]> records = access.Manager.ReqSelect(req, parameters);
                    if (records != null)
                    {
                        foreach (Object[] record in records)
                        {
                            Motif motif = new Motif((int)record[3], (string)record[4]);
                            Absence absencePersonnel = new Absence((int)record[0], (DateTime)record[1], (DateTime)record[2], motif);
                            lesAbsences.Add(absencePersonnel);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
            }
            return lesAbsences;
        }

        /// <summary>
        /// Demande de suppression d'une absence
        /// </summary>
        /// <param name="absence">objet developpeur à supprimer</param>
        public void DelAbsence(Absence absence)
        {
            if (access.Manager != null)
            {
                string req = "delete from absence where idpersonnel = @idpersonnel and datedebut = @datedebut;";
                Dictionary<string, object> parameters = new Dictionary<string, object> {
                    {"@idpersonnel", absence.Idpersonnel },
                    {"@datedebut", absence.DateDebut }
                };
                try
                {
                    access.Manager.ReqUpdate(req, parameters);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
            }
        }



        /// <summary>
        /// Demande d'ajout d'une absence
        /// </summary>
        /// <param name="absence">objet developpeur à ajouter</param>
        public void AddAbsence(Absence absence)
        {
            if (access.Manager != null)
            {
                string req = "insert into absence(idpersonnel, datedebut, idmotif, datefin) ";
                req += "values (@idpersonnel, @datedebut, @idmotif, @datefin);";
                Console.WriteLine(req);
                Dictionary<string, object> parameters = new Dictionary<string, object> {
                    { "@idpersonnel", absence.Idpersonnel },                   
                    { "@datedebut", absence.DateDebut },
                    { "@idmotif", absence.Motif.IdMotif },
                    { "@datefin", absence.DateFin },
                };
                try
                {
                    access.Manager.ReqUpdate(req, parameters);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
            }
        }

        /// <summary>
        /// Demande de modification d'une absence
        /// </summary>
        /// <param name="absence">objet developpeur à modifier</param>
        public void UpdateAbsence(Absence absence)
        {
            if (access.Manager != null)
            {
                string req = "update absence set datedebut = @datedebut, idmotif = @idmotif, datefin = @datefin ";
                req += "where idpersonnel = @idpersonnel and datedebut=@datedebut;";
                Dictionary<string, object> parameters = new Dictionary<string, object> {
                    { "@idpersonnel", absence.Idpersonnel },
                    { "@datedebut", absence.DateDebut },
                    { "@idmotif", absence.Motif.IdMotif },
                    { "@datefin", absence.DateFin },
                };
                try
                {
                    access.Manager.ReqUpdate(req, parameters);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
            }
        }
    }
}
