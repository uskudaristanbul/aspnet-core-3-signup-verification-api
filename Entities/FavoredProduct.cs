using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Entities
{
    [Table("FavoredProduct", Schema = "tekyerco_kozmi")]
    public partial class FavoredProduct
    {
        [Key]
        [Column("Product_id")]
        public int ProductId { get; set; }
        [Key]
        [Column("Cumstomer_id")]
        public int CumstomerId { get; set; }
        [Column("Store_id")]
        public int? StoreId { get; set; }
        public bool? IsLiked { get; set; }
        public int? PurchasedNumber { get; set; }
        public int? CanceledNumber { get; set; }
        public int? ReturnedNumber { get; set; }
        [Column("AlternativePurchasedProduct_id")]
        public int? AlternativePurchasedProductId { get; set; }
        [Column("SecondAlternativePurchasedProduct_id")]
        public int? SecondAlternativePurchasedProductId { get; set; }
        [Column("ThirdAlternativePurchasedProduct_id")]
        public int? ThirdAlternativePurchasedProductId { get; set; }

        [ForeignKey(nameof(CumstomerId))]
        [InverseProperty(nameof(Customer.FavoredProduct))]
        public virtual Customer Cumstomer { get; set; }
        [ForeignKey(nameof(ProductId))]
        [InverseProperty("FavoredProduct")]
        public virtual Product Product { get; set; }
        [ForeignKey(nameof(StoreId))]
        [InverseProperty("FavoredProduct")]
        public virtual Store Store { get; set; }
    }
}
