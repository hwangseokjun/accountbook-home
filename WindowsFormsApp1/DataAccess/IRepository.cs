using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.DataAccess
{
    public interface IRepository
    {
        List<Report> GetAllReports();
        void SaveReport(Report report);
        void RemoveReport(int id);
        List<Category> GetCategories();
        List<Store> GetStores();
        List<ExpenseType> GetExpenseTypes();
    }
}
