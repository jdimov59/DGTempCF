using DGTempCF.DataModels;
using System;
using System.Collections.Generic;

namespace DGTempCF.Data
{
    public class DGTempCFInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<DGTempCFContext>
    {
        protected override void Seed(DGTempCFContext context)
        {
            var employees = new List<Employee>
            {
            new Employee{FirstName="Bai",LastName="Ivan",Position="Director"},
            new Employee{FirstName="Bai",LastName="Kiro",Position="Teacher"}
            };

            employees.ForEach(s => context.Employees.Add(s));
            context.SaveChanges();
        }
    }
}
