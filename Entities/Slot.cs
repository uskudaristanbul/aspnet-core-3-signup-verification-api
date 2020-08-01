using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Entities
{
    public partial class Slot
    {
        public Slot()
        {
            OrderSlots = new HashSet<OrderSlots>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column(TypeName = "date")]
        public DateTime? SlotDate { get; set; }
        [Column("Btw_8_11Available")]
        public bool? Btw811available { get; set; }
        [Column("Btw_11_14Available")]
        public bool? Btw1114available { get; set; }
        [Column("Btw_14_17Available")]
        public bool? Btw1417available { get; set; }
        [Column("Btw_17_20Available")]
        public bool? Btw1720available { get; set; }
        [Column("Btw_20_23Available")]
        public bool? Btw2023available { get; set; }
        public bool? ExpressDelivery { get; set; }
        [Column("Order_id")]
        public int? OrderId { get; set; }

        [InverseProperty("Slot")]
        public virtual ICollection<OrderSlots> OrderSlots { get; set; }
    }
}
