using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Entities
{
    [Table("Stock", Schema = "production")]
    public partial class Stock
    {
        [Key]
        [Column("store_id")]
        public int StoreId { get; set; }
        [Key]
        [Column("product_id")]
        public int ProductId { get; set; }
        [Column("quantity")]
        public int? Quantity { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal? StoreWholePrice { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal? StoreSalePrice { get; set; }

        [ForeignKey(nameof(ProductId))]
        [InverseProperty("Stock")]
        public virtual Product Product { get; set; }
        [ForeignKey(nameof(StoreId))]
        [InverseProperty("Stock")]
        public virtual Store Store { get; set; }
    }
}
