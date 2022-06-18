using InvoiceServices.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoiceServices.Context
{
    public class InvoiceDBContext:DbContext
    {
        public InvoiceDBContext(DbContextOptions<InvoiceDBContext> options):base(options)
        {

        } 

        public DbSet<Product> Products { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<InvoiceDetail> InvoiceDetails { get; set; }
    }
}
