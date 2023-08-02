using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DataAccess;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Views
{
    public interface IView
    {
        event Action<int> OnDeleteReport;
        event Action<Report> OnAddReport;
        event Action OnReadAll;
        List<ReportView> ReportViews { get; set; }
        List<Category> Categories { get; set; }
        List<Store> Stores { get; set; }
        List<ExpenseType> ExpenseTypes { get; set; }
        int TotalIncome { set; }
        int TotalExpense { set; }
        int TotalRemains { set; }
    }
}
