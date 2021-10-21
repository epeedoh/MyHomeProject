using MyHomeProject.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MyHomeProject.ViewModels
{
    public class PropertyDetailViewModel : BaseViewModel
    {

        public PropertyDetailViewModel()
        {

        }

        AppMobileServiceGenerique data = new AppMobileServiceGenerique();
        private bool _IsLoading;
        private bool _Show;

        public Command LoadPropertyDetailCommand { get; set; }









    }
}
