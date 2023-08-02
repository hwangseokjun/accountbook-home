using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class ReportView
    {
        [Browsable(false)]
        public int Id { get; set; }
        [DisplayName("날짜")]
        public string Date { get; set; }
        [DisplayName("분류")]
        public string Category { get; set; }
        [DisplayName("상세")]
        public string Description { get; set; }
        [DisplayName("수입금")]
        public int? IncomeAmount { get; set; }
        [DisplayName("지출금")]
        public int? ExpenseAmount { get; set; }
        [DisplayName("구매처")]
        public string Store { get; set; }
        [DisplayName("지출분류")]
        public string ExpenseType { get; set; }

        public ReportView(Report report, List<Category> categories, List<Store> stores, List<ExpenseType> expenseTypes)
        {
            Id = report.Id;
            Date = report.Date;
            Category = categories.First(x => x.Id == report.CategoryId).Name;
            Description = report.Description;
            IncomeAmount = report.IncomeAmount;
            ExpenseAmount = report.ExpenseAmount;
            Store = stores.First(x => x.Id == report.StoreId).Name;
            ExpenseType = expenseTypes.First(x => x.Id == report.ExpenseTypeId).Name;
        }
    }
}
