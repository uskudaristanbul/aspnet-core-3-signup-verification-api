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
        [Column("SlotDateDay_D1")]
        public int? SlotDateDayD1 { get; set; }
        [Column("SlotDateMonth_D1")]
        public int? SlotDateMonthD1 { get; set; }
        [Column("SlotDateYear_D1")]
        public int? SlotDateYearD1 { get; set; }
        [Column("Btw_8_11Available_D1")]
        public bool? Btw811availableD1 { get; set; }
        [Column("Btw_11_14Available_D1")]
        public bool? Btw1114availableD1 { get; set; }
        [Column("Btw_14_17Available_D1")]
        public bool? Btw1417availableD1 { get; set; }
        [Column("Btw_17_20Available_D1")]
        public bool? Btw1720availableD1 { get; set; }
        [Column("Btw_20_23Available_D1")]
        public bool? Btw2023availableD1 { get; set; }
        public bool? ExpressDelivery { get; set; }
        [Column("Order_id")]
        public int? OrderId { get; set; }
        [Column("SlotDateDay_D2")]
        public int? SlotDateDayD2 { get; set; }
        [Column("SlotDateMonth_D2")]
        public int? SlotDateMonthD2 { get; set; }
        [Column("SlotDateYear_D2")]
        public int? SlotDateYearD2 { get; set; }
        [Column("Btw_8_11Available_D2")]
        public bool? Btw811availableD2 { get; set; }
        [Column("Btw_11_14Available_D2")]
        public bool? Btw1114availableD2 { get; set; }
        [Column("Btw_14_17Available_D2")]
        public bool? Btw1417availableD2 { get; set; }
        [Column("Btw_17_20Available_D2")]
        public bool? Btw1720availableD2 { get; set; }
        [Column("Btw_20_23Available_D2")]
        public bool? Btw2023availableD2 { get; set; }

        [InverseProperty("Slot")]
        public virtual ICollection<OrderSlots> OrderSlots { get; set; }
    }
}
