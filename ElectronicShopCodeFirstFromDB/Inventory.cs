namespace ElectronicShopCodeFirstFromDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Xml.Serialization;

    [XmlInclude(typeof(OrderDetail))]
    [Serializable]
    [XmlRoot]
    [Table("Inventory")]
    public partial class Inventory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Inventory()
        {
            OrderDetails = new List<OrderDetail>();
        }

        [Key]
        public int InventoryId { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public int? UnitInStock { get; set; }

        public double? UnitPrice { get; set; }

        public int? CategoryId { get; set; }

        [StringLength(50)]
        public string Type { get; set; }

        [StringLength(10)]
        public string Current { get; set; }

        [StringLength(10)]
        public string Voltage { get; set; }

        [StringLength(2)]
        public string Version { get; set; }

        [XmlIgnore]
        public virtual Category Category { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<OrderDetail> OrderDetails { get; set; }
    }
}
