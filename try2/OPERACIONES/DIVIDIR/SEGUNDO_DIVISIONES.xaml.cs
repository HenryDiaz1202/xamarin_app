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
    public partial class SEGUNDO_DIVISIONES : ContentPage
    {
        public SEGUNDO_DIVISIONES()
        {
            InitializeComponent();
        }
        public int puntos;
        public void clean()
        {
            a.Text = "0";
            b.Text = "0";
            c.Text = "0";
            d.Text = "0";
            eE.Text = "0";
            f.Text = "0";
            g.Text = "0";
            h.Text = "0";
            i.Text = "0";
            j.Text = "0";
        }
        public struct notess
        {
            public int notita;
        }
        public void datos(object sender, System.EventArgs e)
        {
            puntos = 0;
            notess ntss;
            if (a.Text == "")
            {
                a.Text = "0";
            }
            if (b.Text == "")
            {
                b.Text = "0";
            }
            if (c.Text == "")
            {
                c.Text = "0";
            }
            if (d.Text == "")
            {
                d.Text = "0";
            }
            if (eE.Text == "")
            {
                eE.Text = "0";
            }
            if (f.Text == "")
            {
                f.Text = "0";
            }
            if (g.Text == "")
            {
                g.Text = "0";
            }
            if (h.Text == "")
            {
                h.Text = "0";
            }
            if (i.Text == "")
            {
                i.Text = "0";
            }
            if (j.Text == "")
            {
                j.Text = "0";
            }
            try
            {
                int aa = int.Parse(a.Text);
                int bb = int.Parse(b.Text);
                int cc = int.Parse(c.Text);
                int dd = int.Parse(d.Text);
                int eee = int.Parse(eE.Text);
                int ff = int.Parse(f.Text);
                int gg = int.Parse(g.Text);
                int hh = int.Parse(h.Text);
                int ii = int.Parse(i.Text);
                int jj = int.Parse(j.Text);

                if (aa == 12)
                {
                    puntos += 10;
                }
                if (bb == 31)
                {
                    puntos += 10;
                }
                if (cc == 17)
                {
                    puntos += 10;
                }
                if (dd == 9)
                {
                    puntos += 10;
                }
                if (eee == 50)
                {
                    puntos += 10;
                }
                if (ff == 4)
                {
                    puntos += 10;
                }
                if (gg == 25)
                {
                    puntos += 10;
                }
                if (hh == 5)
                {
                    puntos += 10;
                }
                if (ii == 12)
                {
                    puntos += 10;
                }
                if (jj == 23)
                {
                    puntos += 10;
                }
                ntss.notita = puntos;
                _2da_NOTIF_DIVISIONES ntf = new _2da_NOTIF_DIVISIONES(ntss);
                this.Navigation.PushModalAsync(ntf);
                clean();
            }
            catch (Exception)
            {

            }
        }
    }
}