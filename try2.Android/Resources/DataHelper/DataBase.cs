using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using SQLite;



namespace try2.Android.Resources.Model
{
    public class DataBase
    {
        string folder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
        public bool CreateDataBase()
        {
            try
            {
                using (var conexion = new SQLiteConnection(System.IO.Path.Combine(folder, "Persons.db")))
                {
                    conexion.CreateTable<Person>();
                    return true;
                }
            }
            catch (SQLiteException ex)
            {
                Log.Info("SQLiteEx", ex.Message);
                return false;
            }
        }
        public bool InsertPerson(Person person)
        {
            try
            {
                using (var conexion = new SQLiteConnection(System.IO.Path.Combine(folder, "Persons.db")))
                {
                    conexion.Insert(person);
                    return true;
                }
            }
            catch (SQLiteException ex)
            {
                Log.Info("SQLiteEx", ex.Message);
                return false;
            }
        }
        public List<Person> SelectTablePerson()
        {
            try
            {
                using (var conexion = new SQLiteConnection(System.IO.Path.Combine(folder, "Persons.db")))
                {
                    return conexion.Table<Person>().ToList();
                }
            }
            catch (SQLiteException ex)
            {
                Log.Info("SQLiteEx", ex.Message);
                return null;
            }
        }
        public bool DeletePerson(Person person)
        {
            try
            {
                using (var conexion = new SQLiteConnection(System.IO.Path.Combine(folder, "Persons.db")))
                {
                    conexion.Delete(person);
                    return true;
                }
            }
            catch (SQLiteException ex)
            {
                Log.Info("SQLiteEx", ex.Message);
                return false;
            }
        }

    }
}