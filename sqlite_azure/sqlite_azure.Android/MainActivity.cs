using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Microsoft.WindowsAzure.MobileServices;
using System.Threading.Tasks;
using Android.Service.Notification;



namespace sqlite_azure.Droid
{
    [Activity(Label = "sqlite_azure", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity//, ISQLAzure
    {
        //private MobileServiceUser usuario;
        //public async Task<MobileServiceUser> Authenticate()
        //{
        //    var message = string.Empty;
        //    try
        //    {
        //        usuario = await sqlite_azure.DataPage.Cliente.LoginAsync(this,MobileServiceAuthenticationProvider.MicrosoftAccount, "http://tesh.azurewebsites.net/.auth/login/facebook/callback");
        //        if (usuario != null)
        //        {
        //            message = string.Format("USUARIO AUTENTICADO {0}.", usuario.UserId);
        //            //await new MessageDialog(usuario.MobileServiceAuthenticationToken, "Token").ShowAsync();
        //        }
        //    }

        //    catch (Exception ex)
        //    {
        //        message = ex.Message;
        //    }
           
        
        //   AlertDialog.Builder builder = new AlertDialog.Builder(this);
        //   builder.SetMessage(message);
        //   builder.SetTitle("Resultado de Autenticacion");
        //   builder.Create().Show();
        //    return usuario;
        //}
            

        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
           // App.Init((ISQLAzure)this); //inicializar la aplicacion
            LoadApplication(new App());
        }
    }
}

