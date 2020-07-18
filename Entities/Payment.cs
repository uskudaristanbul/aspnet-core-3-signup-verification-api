using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Entities
{
    [Table("Payment", Schema = "dbo")]
    public partial class Payment
    {
        [Key]
        [Column("Payment_id")]
        public int PaymentId { get; set; }
        [StringLength(200)]
        public string PaymentDescription { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TermStart { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TermEnd { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime PaidTime { get; set; }
        [Column("Career_id")]
        public int? CareerId { get; set; }
        [Column("Store_id")]
        public int? StoreId { get; set; }
        [Column("Supply_id")]
        public int? SupplyId { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal Amount { get; set; }
    }
}
