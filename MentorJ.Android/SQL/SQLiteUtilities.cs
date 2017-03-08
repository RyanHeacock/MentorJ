
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
using MentorJ.Android.Models;
using MentorJWcfService;
using MentorJ.Android.Utilities;

namespace MentorJWcfService
{
     public partial class tblUserInfo
    {

        public static string createDatabase(string path)
        {
            try
            {
                var connection = new SQLiteAsyncConnection(path);
                {
                    connection.CreateTableAsync<tblUserInfo>();
                    return "Database created";
                }
            }
            catch (SQLiteException ex)
            {
                return ex.Message;
            }
        }

        

        public static string insertUpdateData(tblUserInfo data, string path)
        {
            try
            {
                var db = new SQLiteAsyncConnection(path);
                if (db.InsertAsync(data).ToString() == 0.ToString())
                    db.UpdateAsync(data);

                return "Single data file inserted or updated";
            }
            catch (SQLiteException ex)
            {
                return ex.Message;
            }
        }

        public static tblUserInfo getRecord(tblUserInfo data, string path)
        {
            try
            {
                var db = new SQLiteAsyncConnection(path);
                long userid = data.UserID;
                // for a non-parameterless query
                var query = db.GetAsync<tblUserInfo>(t => t.UserID == userid).Result;
                //var query = table.Where(x => (x.UserID == userid)); //Linq Query  
                if (query != null)
                {
                    return query;
                }
                return null;
            }
            catch (SQLiteException ex)
            {
                throw ex;
            }
            //Get specific student  
        }

        public static tblUserInfo getRecord(long userid, string path)
        {
            try
            {
                var db = new SQLiteAsyncConnection(path);
                // for a non-parameterless query
                var query = db.GetAsync<tblUserInfo>(t => t.UserID == userid).Result;
                //var query = table.Where(x => (x.UserID == userid)); //Linq Query  
                if (query != null)
                {
                    return query;
                }
                return null;
            }
            catch (SQLiteException ex)
            {
                throw ex;
            }
            //Get specific student  
        }

        public static bool deleteRecord(tblUserInfo data, string path)
        {
            try
            {
                var db = new SQLiteAsyncConnection(path);
                long userid = data.UserID;
                var query = db.GetAsync<tblUserInfo>(t => t.UserID == userid).Result;
                if (query != null)
                {
                    return db.DeleteAsync(query).IsCompleted;
                }
                return false;
            }
            catch (SQLiteException ex)
            {
                throw ex;
            }

        }

    }
}