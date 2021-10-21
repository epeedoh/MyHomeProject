using MyHomeProject.Models;
using MyHomeProject.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MyHomeProject.ViewModels
{
   public class MainPageViewModel : BaseViewModel
    {
        AppMobileServiceGenerique data = new AppMobileServiceGenerique();


        public MainPageViewModel()
        {
            LoadPropertyCommand = new Command(async () => await GetAllPropertyAsync());
            ListPropriete = new ObservableCollection<ProprieteResource>();
        }

        private bool _IsLoading;
        private bool _Show;

        public Command LoadPropertyCommand { get; set; }
        public Command LoadTypePropertyCommand { get; set; }
        //public Command LoadPropertyTypeCommand { get; set; }
        public ObservableCollection<ProprieteResource> ListPropriete { get; set; }
        public ObservableCollection<TypePropriete> ListTypeDePropriete { get; set; }


        public List<TypePropriete> PropertyTypeList => GetPropertyTypes();


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


        public bool IsLoading
        {
            get { return _IsLoading; }

            set
            {
                _IsLoading = value;
                OnPropertyChanged();
            }
        }

        public bool Show
        {
            get { return _Show; }
            set
            {
                _Show = value;
                OnPropertyChanged();
            }
        }

 

        private async Task GetAllPropertyAsync()
        {
            ListPropriete.Clear();

            try
            {
                var result = await data.PostSharp<PropertyResponse>("", Constants.GetAllPropriete);

                if(result != null)
                {
                    if(result.Proprietes != null)
                    {
                        foreach(var item in result.Proprietes)
                        {
                            ListPropriete.Add(item); 
                        }
                    }
                }
            }catch(Exception ex)
            {
                throw ex;
            }
        }


    }
}
