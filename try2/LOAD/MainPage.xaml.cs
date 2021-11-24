using Android.Telephony;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;

namespace try2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void entering(object sender, System.EventArgs e)
        {
            string nombre, pass;
            nombre = user.Text;
            pass = clave.Text;
           /* if (nombre != "Henry" || pass != "123")
            {

            }
            else
            {*/
                this.Navigation.PushModalAsync(new Login());
            /*}*/
        }
        async void Show()
        {
            var ans = await DisplayAlert("------", "¿Seguro que quieres salir?", "YES", "NO");
            if (ans)
            {
                Environment.Exit(0);
            }
            else
            {

            }
        }
        private void salir(object sender, System.EventArgs e)
        {
            Show();
            // Environment.Exit(0);
        }
    }

}
