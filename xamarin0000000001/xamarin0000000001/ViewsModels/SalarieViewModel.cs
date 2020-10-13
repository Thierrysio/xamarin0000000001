using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using xamarin0000000001.Models;
using xamarin0000000001.Views;

namespace xamarin0000000001.ViewsModels
{
    class SalarieViewModel : INotifyPropertyChanged
    {
        #region Attributs
        private Salaries _leSalarie;
        #endregion

        #region Constructeurs
        public SalarieViewModel()
        {
            CommandeButtonListe = new Command(ActionButtonListe);
            CommandeButtonNewSalarie = new Command(ActionButtonNewSalarie);
            LeSalarie = new Salaries("Disney", "Riri", "https://vignette.wikia.nocookie.net/lemondededisney/images/f/f6/Riri_Duck.png/revision/latest?cb=20130613053049&path-prefix=fr");
        }
        #endregion

        #region Getters Setters
        public ICommand CommandeButtonNewSalarie { get; }
        public ICommand CommandeButtonListe { get; }
        public Salaries LeSalarie
        {
            get
            {
                return _leSalarie;
            }
            set
            {
                if (_leSalarie != value)
                {
                    _leSalarie = value;
                    OnPropertyChanged(nameof(LeSalarie));
                }
            }
        }
        #endregion

            #region Methodes
        public void ActionButtonNewSalarie()
        {
            LeSalarie = new Salaries("Disney", "Fifi", "https://vignette.wikia.nocookie.net/lemondededisney/images/8/86/Fifi_Duck.png/revision/latest?cb=20130707082048&path-prefix=fr");
        }
        public void ActionButtonListe()
        {
            Application.Current.MainPage = new NavigationPage(new ListeView());
        }
            #endregion

        #region notifications
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion


    }
}
