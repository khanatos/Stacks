﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvc4App.Model
{

    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Supplier
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Product
    {

        public int Id { get; set; }
        public string CategoryId { get; set; }
        public string SupplierId { get; set; }

        public string Name { get; set; }
        public string Code { get; set; }
        public decimal ListPrice { get; set; }
        public decimal StandardCost { get; set; }
        public int UnitsOnStock { get; set; }
        public int UnitsOnOrder { get; set; }
        public bool Discontinued { get; set; }

        public string PhotoFile { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}