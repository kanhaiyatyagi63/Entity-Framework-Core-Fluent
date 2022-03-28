using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.DataLayer.Entities
{
    public class Address
    {
        public int Id { get; set; }
        public string Landmark { get; set; }
        public string City { get; set; }

        public int EmployeeId { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
