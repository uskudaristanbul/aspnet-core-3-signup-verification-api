using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Entities
{
    [Table("SlotPattern", Schema = "tekyerco_kozmi")]
    public partial class SlotPattern
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [StringLength(50)]
        public string Day { get; set; }
        [StringLength(50)]
        public string StartTime { get; set; }
        [StringLength(50)]
        public string EndTime { get; set; }
        public bool? IsActive { get; set; }
        public TimeSpan? OpenTime { get; set; }
        public TimeSpan? CloseTime { get; set; }
        [Column("Store_id")]
        public int? StoreId { get; set; }
        public bool? IsDefault { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal? DeliveryPrice1km { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal? DeliveryPrice2km { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal? DeliveryPrice5km { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal? DeliveryPrice10km { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal? DeliveryPricePerkm { get; set; }
        [Column(TypeName = "date")]
        public DateTime? Date { get; set; }
        public bool? GeneralDefaultSlot { get; set; }
        [StringLength(500)]
        public string DescriptionNotAvailable { get; set; }
        public bool? IsAvailable { get; set; }
        [StringLength(500)]
        public string DescriptionLimitedAvailable { get; set; }
        [StringLength(500)]
        public string GeneralDescription { get; set; }
        public bool? ExpressDeliveryIsAvailable { get; set; }
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
        public int? ServiceLevel { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal? ServiceLevelDeliveryFee { get; set; }
        [Column(TypeName = "decimal(12, 2)")]
        public decimal? ServiceFeeForUnder { get; set; }
        [Column(TypeName = "decimal(12, 2)")]
        public decimal? ExpressDeliveryFee { get; set; }
        public int? DayOfDate { get; set; }
        public int? MonthOfDate { get; set; }
        public int? YearOfDate { get; set; }
    }
}
