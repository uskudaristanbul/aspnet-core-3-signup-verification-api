using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Entities
{
    public partial class Cart
    {
        [Key]
        [Column("Cart_id")]
        public int CartId { get; set; }
        [Column("Customer_id")]
        public int CustomerId { get; set; }
        [Column("Voucher_id")]
        public int? VoucherId { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal? TotalAmount { get; set; }

        [ForeignKey(nameof(CustomerId))]
        [InverseProperty("Cart")]
        public virtual Customer Customer { get; set; }
        [InverseProperty("CartItemNavigation")]
        public virtual CartItem CartItem { get; set; }
    }
}
