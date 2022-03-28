using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.DataLayer.Entities
{
    public class EmployeeLanguage
    {
        public int Id { get; set; }
        public int LanguageId { get; set; }
        public int EmployeeId { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual Language Language { get; set; }
    }
}
