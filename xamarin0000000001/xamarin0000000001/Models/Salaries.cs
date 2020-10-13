using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace xamarin0000000001.Models
{
    class Salaries
    {
        #region Attributs
        public static List<Salaries> CollClasseSalaries = new List<Salaries>();

        private string _nom;
        private string _prenom;
        private string _photo;

        #endregion

        #region Constructeurs
        public Salaries(string nom, string prenom, string photo)
        {
            Nom = nom;
            Prenom = prenom;
            Photo = photo;
            Salaries.CollClasseSalaries.Add(this);
        }

        #endregion

        #region Getters Setters
        public string Nom { get => _nom; set => _nom = value; }
        public string Prenom { get => _prenom; set => _prenom = value; }
        public string Photo { get => _photo; set => _photo = value; }

        #endregion

        #region Methodes
        public static ObservableCollection<Salaries> ListingSalaries()
        {
            ObservableCollection<Salaries> resultat = new ObservableCollection<Salaries>();

            foreach (Salaries leSalarie in Salaries.CollClasseSalaries)
            {
                resultat.Add(leSalarie);
            }
            return resultat;
        }
        #endregion
    }
}
