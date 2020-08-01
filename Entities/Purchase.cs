using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Entities
{
    public partial class Purchase
    {
        public Purchase()
        {
            PurchaseItem = new HashSet<PurchaseItem>();
        }

        [Key]
        [Column("Purchase_id")]
        public int PurchaseId { get; set; }
        [Column("Order_id")]
        public int? OrderId { get; set; }
        [Column("Store_id")]
        public int? StoreId { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Amount { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? AmountPaid { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? AmountRemained { get; set; }

        [InverseProperty("Purchase")]
        public virtual ICollection<PurchaseItem> PurchaseItem { get; set; }
    }
}
