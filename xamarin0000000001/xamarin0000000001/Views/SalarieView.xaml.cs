using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using xamarin0000000001.ViewsModels;

namespace xamarin0000000001.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SalarieView : ContentPage
    {
        public SalarieView()
        {
            InitializeComponent();
            BindingContext = new SalarieViewModel();
        }
    }
}