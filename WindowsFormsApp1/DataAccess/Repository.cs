using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Dapper.Contrib.Extensions;
using System.Data.SQLite;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.DataAccess
{
    public class Repository : IRepository
    {
        private string _cnn = "Data Source=db.sqlite;";

        public Repository()
        {
            DefaultTypeMap.MatchNamesWithUnderscores = true;
        }

        public List<Report> GetAllReports()
        {
            using (var cnn = new SQLiteConnection(_cnn))
            {
                cnn.Open();
                var reports = cnn.GetAll<Report>();
                cnn.Close();

                return reports.ToList();
            }
        }

        public List<Category> GetCategories()
        {
            using (var cnn = new SQLiteConnection(_cnn))
            {
                cnn.Open();
                var categories = cnn.GetAll<Category>();
                cnn.Close();

                return categories.ToList();
            }
        }

        public List<ExpenseType> GetExpenseTypes()
        {
            using (var cnn = new SQLiteConnection(_cnn))
            {
                cnn.Open();
                var types = cnn.GetAll<ExpenseType>();
                cnn.Close();

                return types.ToList();
            }
        }

        public List<Store> GetStores()
        {
            using (var cnn = new SQLiteConnection(_cnn))
            {
                cnn.Open();
                var stores = cnn.GetAll<Store>();
                cnn.Close();

                return stores.ToList();
            }
        }

        public void RemoveReport(int id)
        {
            using (var cnn = new SQLiteConnection(_cnn))
            {
                cnn.Open();
                var report = cnn.Get<Report>(id);

                if (!(report is null))
                {
                    cnn.Delete(report);
                }

                cnn.Close();
            }
        }

        public void SaveReport(Report report)
        {
            using (var cnn = new SQLiteConnection(_cnn)) 
            {
                cnn.Open();
                cnn.Insert(report);
                cnn.Close();
            }
        }
    }
}
