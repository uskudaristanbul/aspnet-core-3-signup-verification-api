using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Entities
{
    public partial class ProductsStores
    {
        [Key]
        [Column("Store_id")]
        public int StoreId { get; set; }
        [Key]
        [Column("Product_id")]
        public int ProductId { get; set; }
        [Column("SKU")]
        [StringLength(50)]
        public string Sku { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal? StockAmount { get; set; }
        [StringLength(10)]
        public string StockAmountType { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal? StorePrice { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal? StoreDiscountedPrice { get; set; }

        [ForeignKey(nameof(ProductId))]
        [InverseProperty("ProductsStores")]
        public virtual Product Product { get; set; }
        [ForeignKey(nameof(StoreId))]
        [InverseProperty("ProductsStores")]
        public virtual Store Store { get; set; }
    }
}
