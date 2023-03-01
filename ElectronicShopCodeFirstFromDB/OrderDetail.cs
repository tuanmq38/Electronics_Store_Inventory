namespace ElectronicShopCodeFirstFromDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Xml.Serialization;

    [Serializable]
    [XmlRoot]
    public partial class OrderDetail
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int InventoryId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderId { get; set; }

        public int? OrderQuantity { get; set; }

        public double? TotalAmount { get; set; }
        [XmlIgnore]
        public virtual Inventory Inventory { get; set; }
        [XmlIgnore]
        public virtual Order Order { get; set; }
    }
}
