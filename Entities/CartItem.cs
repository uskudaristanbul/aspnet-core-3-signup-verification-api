using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Entities
{
    public partial class CartItem
    {
        [Key]
        [Column("CartItem_id")]
        public int CartItemId { get; set; }
        [Column("Cart_id")]
        public int? CartId { get; set; }
        [Column("Product_id")]
        public int? ProductId { get; set; }
        public int? Quantity { get; set; }
        [Column("Store_id")]
        public int? StoreId { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal? ListPrice { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal? DiscountedPrice { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal? SoldPrice { get; set; }
        [Column("Voucher_id")]
        public int? VoucherId { get; set; }
        public bool? IsInSaveLater { get; set; }

        [ForeignKey(nameof(CartItemId))]
        [InverseProperty(nameof(Cart.CartItem))]
        public virtual Cart CartItemNavigation { get; set; }
        [ForeignKey(nameof(ProductId))]
        [InverseProperty("CartItem")]
        public virtual Product Product { get; set; }
        [ForeignKey(nameof(StoreId))]
        [InverseProperty("CartItem")]
        public virtual Store Store { get; set; }
        [ForeignKey(nameof(VoucherId))]
        [InverseProperty("CartItem")]
        public virtual Voucher Voucher { get; set; }
    }
}
