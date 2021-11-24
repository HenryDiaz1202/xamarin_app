using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SQLite;

namespace try2.Android.Resources.Model
{
    public class Person
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        public string usuario { get; set; }
        public string password { get; set; }
    }
}