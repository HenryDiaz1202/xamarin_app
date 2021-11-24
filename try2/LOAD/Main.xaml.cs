using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.Xaml;

namespace try2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Main : ContentPage
    {
        public Main()
        {
            InitializeComponent();
        }
        void sumar(object sender, System.EventArgs e) 
        {
            this.Navigation.PushModalAsync(new Sumas());
        }
        void restar(object sender, System.EventArgs e)
        {
            this.Navigation.PushModalAsync(new restas());
        }
        void multiplicar(object sender, System.EventArgs e)
        {
            this.Navigation.PushModalAsync(new multiplicaciones());
        }
        void dividir(object sender, System.EventArgs e)
        {
            this.Navigation.PushModalAsync(new divisiones());
        }
        public void users(object sender, System.EventArgs e)
        {
            this.Navigation.PushModalAsync(new Usuarios());
        }
        async void Show()
        {
            var ans = await DisplayAlert("------", "¿Seguro que quieres salir, cualquier avance se perderá?", "YES", "NO");
            if (ans)
            {
                Environment.Exit(0);
            }
            else
            {

            }
        }
        public void salir(object sender, System.EventArgs e)
        {
            Show();
        }
    }
}