﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace try2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CONGRAT : ContentPage
    {
        public struct notess1
        {
            public int notita1;
        }
        int nota;
 
        public CONGRAT(Sumas.notess notas)
        {

            InitializeComponent();
            int note = notas.notita;

            resultado.Text = note.ToString();
            nota = int.Parse(resultado.Text);
            if (nota >= 90 && nota<=100)
            {
                avnz.IsEnabled = true;
                repre.Source = "excelente.gif";
                message.Text = "PUEDES AVANZAR A LA SIGUIENTE UNIDAD";
                message.TextColor = Color.Green;
            }
            else if (nota >=60 && nota <=89)
            {
                avnz.IsEnabled = true;
                repre.Source = "goodjob.gif";
                message.Text = "PUEDES AVANZAR A LA SIGUIENTE UNIDAD";
                message.TextColor = Color.Green;
            }
            else if(nota <=59 && nota >= 0)
            {
                avnz.IsEnabled = false;
                repre.Source = "happy.gif";
                repre.HeightRequest=250;
                message.Text = "LO HAS INTENTADO \n NO HAS OBTENIDO LA NOTA MÍNIMA PARA CONTINUAR";
                message.TextColor = Color.Red;
            }
        }
        public void revers(object sender, System.EventArgs e)
        {
            Sumas sm = new Sumas();
            sm.value = true;
          //  this.Navigation.PushModalAsync(sm);
        }
        private void cancelar(object sender, System.EventArgs e)
        {            
            Main mn = new Main();
            this.Navigation.PushModalAsync(mn);
        }
        private void avance(object sender, System.EventArgs e)
        {
            /* notess1 notes1;
             notes1.notita1=nota; notes1*/
            this.Navigation.PushModalAsync(new Sumar_2do());
        }
    }
}