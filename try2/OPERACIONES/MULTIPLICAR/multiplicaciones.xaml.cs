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
    public partial class multiplicaciones : ContentPage
    {
        public multiplicaciones()
        {
            InitializeComponent();
        }
        void Click(object sender, System.EventArgs e)
        {
            this.IsVisible = false;
            this.Navigation.PushModalAsync(new Main());
        }
        public int puntos;
        public struct notess
        {
            public int notita;
        }
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
            k.Text = "0";
            l.Text = "0";
            m.Text = "0";
            n.Text = "0";
            o.Text = "0";
            p.Text = "0";
            q.Text = "0";
            r.Text = "0";
            s.Text = "0";
        }
        void PASARDATOS(object sender, System.EventArgs e)
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
            if (k.Text == "")
            {
                k.Text = "0";
            }
            if (l.Text == "")
            {
                l.Text = "0";
            }
            if (m.Text == "")
            {
                m.Text = "0";
            }
            if (n.Text == "")
            {
                n.Text = "0";
            }
            if (o.Text == "")
            {
                o.Text = "0";
            }
            if (p.Text == "")
            {
                p.Text = "0";
            }
            if (q.Text == "")
            {
                q.Text = "0";
            }
            if (r.Text == "")
            {
                r.Text = "0";
            }
            if (s.Text == "")
            {
                s.Text = "0";
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
                int kk = int.Parse(k.Text);
                int ll = int.Parse(l.Text);
                int mm = int.Parse(m.Text);
                int nn = int.Parse(n.Text);
                int oo = int.Parse(o.Text);
                int pp = int.Parse(p.Text);
                int qq = int.Parse(q.Text);
                int rr = int.Parse(r.Text);
                int ss = int.Parse(s.Text);

                if (aa == 12)
                {
                    puntos += 5;
                }
                if (bb == 42)
                {
                    puntos += 5;
                }
                if (cc == 56)
                {
                    puntos += 5;
                }
                if (dd == 72)
                {
                    puntos += 5;
                }
                if (eee == 70)
                {
                    puntos += 5;
                }
                if (ff == 24)
                {
                    puntos += 5;
                }
                if (gg == 48)
                {
                    puntos += 5;
                }
                if (hh == 35)
                {
                    puntos += 5;
                }
                if (ii == 100)
                {
                    puntos += 5;
                }
                if (jj == 90)
                {
                    puntos += 5;
                }
                if (kk == 242)
                {
                    puntos += 5;
                }
                if (ll == 70)
                {
                    puntos += 5;
                }
                if (mm == 66)
                {
                    puntos += 5;
                }
                if (nn == 130)
                {
                    puntos += 5;
                }
                if (oo == 1440)
                {
                    puntos += 6;
                }
                if (pp == 200)
                {
                    puntos += 6;
                }
                if (qq == 75)
                {
                    puntos += 6;
                }
                if (rr == 38)
                {
                    puntos += 6;
                }
                if (ss == 184)
                {
                    puntos += 6;
                }
                dat.Text = puntos.ToString();
                ntss.notita = int.Parse(dat.Text);
                CONGRATSS cg = new CONGRATSS(ntss);
                this.Navigation.PushModalAsync(cg);
                clean();
            }
            catch (Exception)
            {

            } 
        }
    }
}