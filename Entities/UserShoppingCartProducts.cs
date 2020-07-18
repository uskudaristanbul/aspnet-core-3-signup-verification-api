using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Entities
{
    [Table("User_ShoppingCartProducts", Schema = "tekyerco_kozmi")]
    public partial class UserShoppingCartProducts
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("Product_id")]
        public int? ProductId { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal? ListPrice { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal? SalePrice { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal? Discount { get; set; }
        public int? NumberOfPiece { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal? Amount { get; set; }
        [Column(TypeName = "text")]
        public string AmountType { get; set; }
        [Column("Coupon_id")]
        public int? CouponId { get; set; }
        [StringLength(250)]
        public string DiscountDescription { get; set; }
        [Column("User_id")]
        public int? UserId { get; set; }
        [Column("Account_id")]
        public int? AccountId { get; set; }
    }
}
