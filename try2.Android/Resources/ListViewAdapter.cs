using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using try2.Android.Resources.Model;
using Java.Lang;

namespace try2.Android.Resources.Model
{
    class ListViewAdapter
    {
        public class ver : Java.Lang.Object
        {
            public TextView txtUsuario { get; set; }
            public TextView txtpass { get; set; }
        }
        public class AdaptVerLista : BaseAdapter
        {
            private Activity actividad;
            private List<Person> lstUsers;
            public AdaptVerLista(Activity actividad, List<Person> lstUsers)
            {
                this.actividad = actividad;
                this.lstUsers = lstUsers;
            }
            public override int Count
            {
                get
                {
                    return lstUsers.Count;
                }
            }

            public override Java.Lang.Object GetItem(int position)
            {
                return null;
            }

            public override long GetItemId(int position)
            {
                return lstUsers[position].id;
            }

            public override View GetView(int position, View convertView, ViewGroup parent)
            {/* 
                var view = convertView ?? actividad.LayoutInflater.Inflate(Resource.Layout.list_view_dataTemplate, parent,false);
                var txtUsuario = view.FindById<TextView>(Resource.Id.Text1);
                var txtpass = view.FindById<TextView>(Resource.Id.Text2);

                txtUsuario.Text = lstUsers[position].usuario;
                txtpass.Text = lstUsers[position].password;*/
                return null;
            }
        }
    }
}