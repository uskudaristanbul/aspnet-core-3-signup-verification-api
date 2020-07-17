using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Entities
{
    [Table("Order_Slots", Schema = "tekyerco_kozmi")]
    public partial class OrderSlots
    {
        [Key]
        [Column("Order_id")]
        public int OrderId { get; set; }
        [Key]
        [Column("Slot_id")]
        public int SlotId { get; set; }
        public bool? IsAvailable { get; set; }

        [ForeignKey(nameof(OrderId))]
        [InverseProperty("OrderSlots")]
        public virtual Order Order { get; set; }
        [ForeignKey(nameof(SlotId))]
        [InverseProperty("OrderSlots")]
        public virtual Slot Slot { get; set; }
    }
}
