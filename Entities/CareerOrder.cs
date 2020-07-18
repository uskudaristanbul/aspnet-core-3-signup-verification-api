using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Entities
{
    [Table("Career-Order", Schema = "dbo")]
    public partial class CareerOrder
    {
        [Key]
        [Column("Career_id")]
        public int CareerId { get; set; }
        [Key]
        [Column("Order_id")]
        public int OrderId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? AssignedTime { get; set; }

        [ForeignKey(nameof(CareerId))]
        [InverseProperty("CareerOrder")]
        public virtual Career Career { get; set; }
        [ForeignKey(nameof(OrderId))]
        [InverseProperty("CareerOrder")]
        public virtual Order Order { get; set; }
    }
}
