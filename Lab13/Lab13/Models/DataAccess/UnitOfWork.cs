using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab13.Models

    public class UnitOfWork : IUnitOfWork
{
    private Repository<Employee> employees;

    private Repository<Sales> sales;

    public UnitOfWork(SalesContext ctx) => this.context = ctx;

    public Repository<Employee> Employees

    {
        get
        {
            if (this.employees == null)
            {
                this.employees = new Repository<Employee>(this.context);
            }
            return employees;
        }
    }

    public Repository<Sales> Sales

    {
        get
        {
            if (this.sales == null)
            {
                this.sales = new Repository<Sales>(this.context);
            }
            return sales;
        }
    }

    private SalesContext context { get; set; }

    public void Save() => context.SaveChanges();
}
}