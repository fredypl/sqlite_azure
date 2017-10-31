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
    public partial class DataPage : ContentPage
    {
        public ObservableCollection<_13090301> Items { get; set; }
        public static MobileServiceClient Cliente;
        public static IMobileServiceTable<_13090301> Tabla;
       // MobileServiceUser usuario;

        public DataPage()
        {
            InitializeComponent();
            Cliente = new MobileServiceClient(AzureConecction.URLAzure);           
            Tabla = Cliente.GetTable<_13090301>();
            LeerTabla();

           
        }

        async void Handle_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;
            await Navigation.PushModalAsync(new SelectPage(e.SelectedItem as _13090301));
        }

        private void Insertar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new InsertPage());
        }

        private async void LeerTabla()
        {
            IEnumerable<_13090301> elementos = await Tabla.ToEnumerableAsync();
            Items = new ObservableCollection<_13090301>(elementos);
            BindingContext = this;
        }

        private  void Recuperar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Recuperados());

        }
        
        //private async void login_Clicked(object sender, EventArgs e)
        //{
        //    usuario = await App.Authenticator.Authenticate();
        //    if(App.Authenticator !=null)
        //    {
        //        if(usuario !=null)
        //        {
        //            await DisplayAlert("USUARIO AUTENTICADO", usuario.UserId, "OK");

        //        }
        //    }

        //}
    }
}