using MyHomeProject.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace MyHomeProject.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}