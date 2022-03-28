using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.DataLayer.Entities
{
    public class Employee
    {
        public int EmpId { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public DateTime DateOfBirth { get; set; }

        public int DepartmentId { get; set; }

        public virtual Department Department { get; set; }

        public virtual Address Address { get; set; }
        public virtual ICollection<EmployeeLanguage> EmployeeLanguages { get; set; }
    }
}
