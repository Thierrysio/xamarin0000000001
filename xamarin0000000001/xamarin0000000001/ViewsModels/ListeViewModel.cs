using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using xamarin0000000001.Models;

namespace xamarin0000000001.Views
{
    class ListeViewModel : INotifyPropertyChanged
    {
        #region Attributs
        private ObservableCollection<Salaries> _maListeSalarie;


        #endregion

        #region Constructeurs
        public ListeViewModel()
        {
            MaListeSalaries = Salaries.ListingSalaries();
        }
        #endregion

        #region Getters Setters
        public ObservableCollection<Salaries> MaListeSalaries
        {
            get
            {

                return _maListeSalarie;
            }

            set
            {
                _maListeSalarie = value;
                OnPropertyChanged(nameof(MaListeSalaries));
            }
        }
        #endregion

        #region Methodes
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
