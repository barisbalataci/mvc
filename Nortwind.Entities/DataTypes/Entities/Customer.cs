﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Shared.DataTypes.Entities
{
    public class Customer:IEntity
    {
        public Customer()
        {
            this.Orders = new List<Order>();

        }

        public string CustomerID { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }

        public  List<Order> Orders { get; set; }
        //public virtual ICollection<CustomerDemographic> CustomerDemographics { get; set; }
    }
}
