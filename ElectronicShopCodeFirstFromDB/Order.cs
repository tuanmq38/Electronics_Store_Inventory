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
    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            OrderDetails = new List<OrderDetail>();
        }

        [Key]
        public int OrderId { get; set; }

        public int? CustomerId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? OrderDate { get; set; }
        [XmlIgnore]
        public virtual Customer Customer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<OrderDetail> OrderDetails { get; set; }
    }
}
