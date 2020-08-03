using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Entities
{
    public partial class Supplier
    {
        [Key]
        [Column("Purchase_id")]
        public int PurchaseId { get; set; }
        [Column("RelatedOrder_id")]
        public int? RelatedOrderId { get; set; }
        [Column("Store_id")]
        public int? StoreId { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Amount { get; set; }

        [ForeignKey(nameof(RelatedOrderId))]
        [InverseProperty(nameof(Order.Supplier))]
        public virtual Order RelatedOrder { get; set; }
        [ForeignKey(nameof(StoreId))]
        [InverseProperty("Supplier")]
        public virtual Store Store { get; set; }
    }
}
