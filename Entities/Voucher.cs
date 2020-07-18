using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Entities
{
    [Table("Voucher", Schema = "dbo")]
    public partial class Voucher
    {
        public Voucher()
        {
            CartItem = new HashSet<CartItem>();
        }

        [Key]
        [Column("Voucher_id")]
        public int VoucherId { get; set; }
        [StringLength(200)]
        public string VoucherDescription { get; set; }
        [StringLength(50)]
        public string VoucherCode { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? DiscountRate { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? DiscountAmount { get; set; }

        [InverseProperty("Voucher")]
        public virtual ICollection<CartItem> CartItem { get; set; }
    }
}
