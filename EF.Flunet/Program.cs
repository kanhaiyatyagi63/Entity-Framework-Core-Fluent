using EF.DataLayer.Context;
using EF.DataLayer.Entities;
using EF.Flunet.Modules;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Flunet
{
    public class Program
    {

        public static void PerformLanguageOperation(EmployeeContext context)
        {
            using (var languageModule = new LanguageModule(context))
            {
                var lang = languageModule.GetById(1);
            }
        }

        public static void Main(String[] args)
        {
            Console.WriteLine("Hello World!");

            using (var context = new EmployeeContext())
            {
                PerformLanguageOperation(context);

            }
        }
    }
}
