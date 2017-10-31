using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.WindowsAzure.MobileServices;
using System.Threading.Tasks;


using Foundation;
using UIKit;

namespace sqlite_azure.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate //, ISQLAzure
    {


        //private MobileServiceUser usuario;
        //public async Task<MobileServiceUser> Authenticate()
        //{
        //    var message = string.Empty;
        //    try
        //    {
        //        usuario = await sqlite_azure.DataPage.Cliente.LoginAsync(UIApplication.SharedApplication.KeyWindow.RootViewController,MobileServiceAuthenticationProvider.Facebook, "http://tesh.azurewebsites.net/.auth/login/facebook/callback");
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
        //   UIAlertView avAlert = new UIAlertView("Resultado de Autenticacion",message,null,"ok",null);
        //   avAlert.Show();
        //    return usuario;
        //}



        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();
            //App.Init(this);//inicilizar la alicacion
            LoadApplication(new App());

            return base.FinishedLaunching(app, options);
        }
    }
}
