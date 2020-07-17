using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Entities
{
    [Table("PurchaseItem", Schema = "dbo")]
    public partial class PurchaseItem
    {
        [Key]
        [Column("Item_id")]
        public int ItemId { get; set; }
        [Column("Purchase_id")]
        public int PurchaseId { get; set; }
        [Column("Product_id")]
        public int ProductId { get; set; }
        public int? PurchaseStatus { get; set; }
        [Column("Store_id")]
        public int? StoreId { get; set; }
        [Column("Career_id")]
        public int? CareerId { get; set; }
        [StringLength(50)]
        public string ItemBarcode { get; set; }
        public int? ProcessPhase { get; set; }
        [Column("Location_id")]
        public int? LocationId { get; set; }

        [ForeignKey(nameof(CareerId))]
        [InverseProperty("PurchaseItem")]
        public virtual Career Career { get; set; }
        [ForeignKey(nameof(LocationId))]
        [InverseProperty("PurchaseItem")]
        public virtual Location Location { get; set; }
        [ForeignKey(nameof(ProductId))]
        [InverseProperty("PurchaseItem")]
        public virtual Product Product { get; set; }
        [ForeignKey(nameof(PurchaseId))]
        [InverseProperty("PurchaseItem")]
        public virtual Purchase Purchase { get; set; }
        [ForeignKey(nameof(StoreId))]
        [InverseProperty("PurchaseItem")]
        public virtual Store Store { get; set; }
    }
}
