﻿using Project.Shared.Abstract;
using System.Collections.Generic;

namespace Project.Shared.Concrete
{
    public class Category:IEntity
    {
        public Category()
        {
            Products = new List<Product>();
        }
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }

        public List<Product> Products { get; set; }

    }
}