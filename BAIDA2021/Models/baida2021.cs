using BAIDA2021.ClassProject;
using BAIDA2021.ClassProject.warehouses;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BAIDA2021.Models
{
    public class baida2021 : DbContext
    {


        public DbSet<Carton_type> Carton_types { get; set; }

        public DbSet<Measurement> Measurements { get; set; }

        public DbSet<Specification> Specifications { get; set; }
    }
}