using MyHomeProject.Models;
using MyHomeProject.ViewModels;
using MyHomeProject.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyHomeProject
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {

        MainPageViewModel viewModel;
        public MainPage()
        {
            InitializeComponent();
            //this.BindingContext = this;
            BindingContext = viewModel = new MainPageViewModel();
        }

        public List<TypePropriete> PropertyTypeList => GetPropertyTypes();
        //public List<Propriete> PropertyList => GetProperties();

        private List<TypePropriete> GetPropertyTypes()
        {
            return new List<TypePropriete>
            {
                new TypePropriete { TypeName = "Tout" },
                new TypePropriete { TypeName = "Studio" },
                new TypePropriete { TypeName = "4 Lit" },
                new TypePropriete { TypeName = "3 Lit" },
                new TypePropriete { TypeName = "Bureau" }
            };
        }

        //private List<Propriete> GetProperties()
        //{
        //    return new List<Propriete>
        //    {
        //        new Propriete { Image = "apt1.png", Address = "2162 Plateau Ave, Sorbonne", Location = "Plateau", Price = "30 000 000 CFA", Bed = "4 Lit", Bath = "3 Salle Bain", Space = "1600 M²", Details = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Bibendum est ultricies integer quis. Iaculis urna id volutpat lacus laoreet. Mauris vitae ultricies leo integer malesuada. Ac odio tempor orci dapibus ultrices in. Egestas diam in arcu cursus euismod. Dictum fusce ut" },
        //        new Propriete { Image = "apt2.png", Address = "2168 Vallon Paule, Paco", Location = "Vallon", Price = "30 000 000 CFA", Bed = "3 Lit", Bath = "1 Salle Bain", Space = "1600 M²", Details = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Bibendum est ultricies integer quis. Iaculis urna id volutpat lacus laoreet. Mauris vitae ultricies leo integer malesuada. Ac odio tempor orci dapibus ultrices in. Egestas diam in arcu cursus euismod. Dictum fusce ut" },
        //        new Propriete { Image = "apt3.png", Address = "2112 Bingerville , LA", Location = "Bingerville", Price = "30 000 000 CFA", Bed = "2 Lit", Bath = "2 Salle Bain", Space = "1600 M²", Details = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Bibendum est ultricies integer quis. Iaculis urna id volutpat lacus laoreet. Mauris vitae ultricies leo integer malesuada. Ac odio tempor orci dapibus ultrices in. Egestas diam in arcu cursus euismod. Dictum fusce ut" },
        //    };
        //}

        private async void PropertySelected(object sender, EventArgs e)
        {
            //var property = (sender as View).BindingContext as Propriete;
            var property = (sender as View).BindingContext as ProprieteResource;
            await this.Navigation.PushAsync(new DetailsPropertySelect(property));
        }

        private void SelectType(object sender, EventArgs e)
        {
            var view = sender as View;
            var parent = view.Parent as StackLayout;

            foreach (var child in parent.Children)
            {
                VisualStateManager.GoToState(child, "Normal");
                ChangeTextColor(child, "#707070");
            }

            VisualStateManager.GoToState(view, "Selected");
            ChangeTextColor(view, "#FFFFFF");
        }

        private void ChangeTextColor(View child, string hexColor)
        {
            var txtCtrl = child.FindByName<Label>("PropertyTypeName");

            if (txtCtrl != null)
                txtCtrl.TextColor = Color.FromHex(hexColor);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            if (viewModel.ListPropriete.Count == 0)
                viewModel.LoadPropertyCommand.Execute(null);

            //viewModel.LoadPropertyTypeCommand.Execute(null);

        }

    }



    //public class TypePropriete
    //{
    //    public string TypeName { get; set; }
    //}

    //public class Propriete
    //{
    //    public string Id => Guid.NewGuid().ToString("N");
    //    public string PropertyName { get; set; }
    //    public string Image { get; set; }
    //    public string Address { get; set; }
    //    public string Location { get; set; }
    //    public string Price { get; set; }
    //    public string Bed { get; set; }
    //    public string Bath { get; set; }
    //    public string Space { get; set; }
    //    public string Details { get; set; }
    //}
}