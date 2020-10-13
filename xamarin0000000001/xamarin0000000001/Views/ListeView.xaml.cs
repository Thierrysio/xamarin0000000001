using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace xamarin0000000001.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListeView : ContentPage
    {
        public ListeView()
        {
            InitializeComponent();
            BindingContext = new ListeViewModel();
        }
    }
}