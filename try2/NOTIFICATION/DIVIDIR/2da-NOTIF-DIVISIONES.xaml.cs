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
    public partial class _2da_NOTIF_DIVISIONES : ContentPage
    {
        public _2da_NOTIF_DIVISIONES(SEGUNDO_DIVISIONES.notess notas)
        {
            InitializeComponent();
            int note = notas.notita;

            resultado.Text = note.ToString();
            int nota = int.Parse(resultado.Text);
            if (nota >= 90 && nota <= 100)
            {
                avnz.IsVisible = false;
                avnz.Text = "FINALIZAR";
                repre.Source = "excelente.gif";
            }
            else if (nota >= 60 && nota <= 89)
            {
                avnz.IsVisible = false;
                repre.Source = "goodjob.gif";
                avnz.Text = "FINALIZAR";
            }
            else if (nota <= 59 && nota >= 0)
            {
                repre.Source = "happy.gif";
                repre.HeightRequest = 250;
                message.Text = "LO HAS INTENTADO \n PUEDES FINALIZAR O INTENTARLO OTRA VEZ";
                message.TextColor = Color.Red;
            }
        }
        private void trya(object sender, System.EventArgs e)
        {
            this.Navigation.PushModalAsync(new SEGUNDO_DIVISIONES());
        }
        private void fin(object sender, System.EventArgs e)
        {
            this.Navigation.PushModalAsync(new Main());
        }
    }
}