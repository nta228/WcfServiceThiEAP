using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ManagerEmployees.Models
{
    public class Data
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            DBContext context = app.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<DBContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Employees.Any())
            {
                context.Employees.AddRange(
                    new Employees()
                    {
                        Name = "Nguyen Tuan Anh",
                        Salary = "$1000",
                        Phone = "09159967891",
                        Department = "A",
                    },
                    new Employees()
                    {
                        Name = "Nguyen Tuan Em",
                        Salary = "2000",
                        Phone = "09159967892",
                        Department = "B",
                    },
                    new Employees()
                    {
                        Name = "Nguyen Tuan",
                        Salary = "$3000",
                        Phone = "09159967893",
                        Department = "A",
                    },
                    new Employees()
                    {
                        Name = "Nguyen Anh",
                        Salary = "$1000",
                        Phone = "09159967894",
                        Department = "B",
                    },
                    new Employees()
                    {
                        Name = "Nguyen Em",
                        Salary = "$2000",
                        Phone = "09159967895",
                        Department = "B",
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}