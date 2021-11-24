using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace try2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Sumas : ContentPage
    {
        public bool value = false;
       // List<int> notas_sumadas = new List<int> { 8,13,77,21,52,72,15,11,132,33,96,87,48,32,2204,650,379,389,450};
        public Sumas()
        {
            if (value)
            {
                a.TextColor = Color.Red;
            }
            InitializeComponent();
        }
        private void Sumas_Load(object sender, EventArgs e)
        {
           // load();
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

                if (aa == 8)
                {
                    puntos += 5;
                }
                if (bb == 13)
                {
                    puntos += 5;
                }
                if (cc == 77)
                {
                    puntos += 5;
                }
                if (dd == 21)
                {
                    puntos += 5;
                }
                if (eee == 52)
                {
                    puntos += 5;
                }
                if (ff == 72)
                {
                    puntos += 5;
                }
                if (gg == 15)
                {
                    puntos += 5;
                }
                if (hh == 11)
                {
                    puntos += 5;
                }
                if (ii == 132)
                {
                    puntos += 5;
                }
                if (jj == 33)
                {
                    puntos += 5;
                }
                if (kk == 96)
                {
                    puntos += 5;
                }
                if (ll == 87)
                {
                    puntos += 5;
                }
                if (mm == 48)
                {
                    puntos += 5;
                }
                if (nn == 32)
                {
                    puntos += 5;
                }
                if (oo == 2204)
                {
                    puntos += 6;
                }
                if (pp == 650)
                {
                    puntos += 6;
                }
                if (qq == 379)
                {
                    puntos += 6;
                }
                if (rr == 389)
                {
                    puntos += 6;
                }
                if (ss == 350)
                {
                    puntos += 6;
                }
                dat.Text = puntos.ToString();
                ntss.notita = int.Parse(dat.Text);
                CONGRAT cg = new CONGRAT(ntss);
                this.Navigation.PushModalAsync(cg);
                clean();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}