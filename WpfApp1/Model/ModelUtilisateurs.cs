using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class ModelUtilisateurs
    {
        public ModelUtilisateurs()
        {
            id = -1;
        }
        public ModelUtilisateurs(string prenom, string nom)
        {
            if (!string.IsNullOrEmpty(prenom))
            {
                this.prenom = prenom;
            }
            else
            {
                throw new Exception("Prenom Pas ok");
            }
            if (!string.IsNullOrEmpty(nom))
            {
                this.nom = nom;
            }
            else
            {
                throw new Exception("Prenom Pas ok");
            }

        }
        public int id { get; set; }

        public string prenom { get;  set; }
        public string nom { get;  set; }

    }
}
