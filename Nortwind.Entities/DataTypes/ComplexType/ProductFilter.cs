﻿namespace Project.Shared.DataTypes.ComplexType
{
    public class ProductFilter
    {
        public int? CategoryId { get; set; }
        public int? Page { get; set; }
        public int? PageSize { get; set; }
        public string ProductName { get; set; }
    }
}