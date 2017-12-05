using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using IntexNWLP.Models;

namespace IntexNWLP.DAL
{
    public class NWLPContext : DbContext
    {
        public NWLPContext() : base("NWLPContext")
        {

        }

        public DbSet<Assay_Orders> Assay_Orders { get; set; }
        public DbSet<Assay_Results> Assay_Results { get; set; }
        public DbSet<Assay_Tests> Assay_Tests { get; set; }
        public DbSet<Assays> Assays { get; set; }
        public DbSet<Catalog_Subscriptions> Catalog_Subscriptions { get; set; }
        public DbSet<Catalog_Type> Catalog_Type { get; set; }
        public DbSet<Compound_Samples> Compund_Samples { get; set; }
        public DbSet<Compounds> Compounds { get; set; }
        public DbSet<Customer_Users> Customer_Users { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Employee_Users> Employee_Users { get; set; }
        public DbSet<Employees> Employees { get; set; }
        public DbSet<Materials> Materials { get; set; }
        public DbSet<Materials_Tests> Materials_Tests { get; set; }
        public DbSet<Offices> Offices { get; set; }
        public DbSet<Order_Invoice> Order_Invoice { get; set; }
        public DbSet<Order_Status> Order_Status { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<Sales> Sales { get; set; }
        public DbSet<Test_Results> Test_Results { get; set; }
        public DbSet<Tests> Tests { get; set; }
        public DbSet<TestTube> TestTube { get; set; }

    }
}