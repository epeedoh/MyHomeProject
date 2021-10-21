using MyHomeProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyHomeProject.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailsPropertySelect : ContentPage
    {
        public DetailsPropertySelect(ProprieteResource Propriete)
        {
            InitializeComponent();
            this.Propriete = Propriete;
            BindingContext = this;
        }

        private void GoBack(object sender, EventArgs e)
        {
            this.Navigation.PopAsync();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            DetailsView.TranslationY = 500;
            DetailsView.TranslateTo(0, 0, 500, Easing.SinInOut);
        }

        //public Propriete Propriete { get; set; }
        public ProprieteResource Propriete { get; set; }


    }
}