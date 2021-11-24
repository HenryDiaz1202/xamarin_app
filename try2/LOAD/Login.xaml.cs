using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace try2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
            NavigationPage.SetHasBackButton(this, false);
        }
        void Button_Clicked(object sender, System.EventArgs e)
        {
            this.Navigation.PushModalAsync(new Main());
        }
    }
}