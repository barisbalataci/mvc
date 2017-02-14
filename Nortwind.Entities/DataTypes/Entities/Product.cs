
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;


namespace Project.Shared.DataTypes.Entities
{
    [DataContract]
    public class Product:IEntity
    {
        
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string ProductName { get; set; }
        [DataMember]
        public int? CategoryId { get; set; }
        [DataMember]
        public string QuantityPerUnit { get; set; }
        [DataMember]
        public decimal? UnitPrice { get; set; }
        [DataMember]
        public short? UnitsInStock { get; set; }
      
        public Category Category { get; set; }
    }
}
