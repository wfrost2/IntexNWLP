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

        public DbSet<Assay_Order> Assay_Order { get; set; }
        public DbSet<Assay_Result> Assay_Result { get; set; }
        public DbSet<Assay_Test> Assay_Test { get; set; }
        public DbSet<Assay_Type> Assay_Type { get; set; }
        public DbSet<Assay> Assay { get; set; }
        public DbSet<Catalog_Subscription> Catalog_Subscription { get; set; }
        public DbSet<Catalog_Type> Catalog_Type { get; set; }
        public DbSet<Compound_Sample> Compund_Sample { get; set; }
        public DbSet<Compound> Compound { get; set; }
        public DbSet<Customer_Users> Customer_User { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Employee_Users> Employee_User { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Material> Material { get; set; }
        public DbSet<Material_Test> Material_Test { get; set; }
        public DbSet<Office> Office { get; set; }
        public DbSet<Order_Invoice> Order_Invoice { get; set; }
        public DbSet<Order_Status> Order_Status { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<Sale> Sale { get; set; }
        public DbSet<Test_Result> Test_Result { get; set; }
        public DbSet<Test> Test { get; set; }
        public DbSet<TestTube> TestTube { get; set; }

    }
}