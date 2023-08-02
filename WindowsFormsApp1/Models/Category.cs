using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    [Table("Category")]
    public class Category
    {
        [Browsable(false)]
        public int Id { get; set; }
        [DisplayName("카테고리")]
        public string Name { get; set; }
    }
}
