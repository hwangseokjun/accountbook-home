using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    [Table("ExpenseType")]
    public class ExpenseType
    {
        [Browsable(false)]
        public int Id { get; set; }
        [DisplayName("지출분류")]
        public string Name { get; set; }
    }
}
