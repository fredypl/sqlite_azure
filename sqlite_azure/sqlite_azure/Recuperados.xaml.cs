using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using System.Collections.ObjectModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Microsoft.WindowsAzure.MobileServices;
namespace sqlite_azure
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Recuperados : ContentPage
    {
        public ObservableCollection<_13090301> Items { get; set; }
        public static MobileServiceClient Cliente;
        public static IMobileServiceTable<_13090301> Tabla;
        public Recuperados()
        {
            InitializeComponent();
            Cliente = new MobileServiceClient(AzureConecction.URLAzure);
            Tabla = Cliente.GetTable<_13090301>();
            LeerTabla();
        }

        async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;
            await Navigation.PushModalAsync(new Recuperaciones(e.SelectedItem as _13090301));

        }
      
        private async void LeerTabla()
        {
            IEnumerable<_13090301> elementos = await Tabla.IncludeDeleted().ToEnumerableAsync();
            Items = new ObservableCollection<_13090301>(elementos);
            BindingContext = this;
        }
    }
}