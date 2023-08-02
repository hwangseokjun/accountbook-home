using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    [Table("Report")]
    public class Report
    {
        [Browsable(false)]
        public int Id { get; set; }
        [DisplayName("날짜")]
        public string Date { get; set; }
        [DisplayName("분류")]
        public int? CategoryId { get; set; }
        [DisplayName("상세")]
        public string Description { get; set; }
        [DisplayName("수입금")]
        public int? IncomeAmount { get; set; }
        [DisplayName("지출금")]
        public int? ExpenseAmount { get; set; }
        [DisplayName("구매처")]
        public int? StoreId { get; set; }
        [DisplayName("지출분류")]
        public int? ExpenseTypeId { get; set; }
    }
}
