using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    [Table("Store")]
    public class Store
    {
        [Browsable(false)]
        public int Id { get; set; }
        [DisplayName("구매처")]
        public string Name { get; set; }
    }
}
