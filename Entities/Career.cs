using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Entities
{
    [Table("Career", Schema = "dbo")]
    public partial class Career
    {
        public Career()
        {
            CareerOrder = new HashSet<CareerOrder>();
            Location = new HashSet<Location>();
            PurchaseItem = new HashSet<PurchaseItem>();
        }

        [Key]
        [Column("Career_id")]
        public int CareerId { get; set; }
        [StringLength(200)]
        public string CareerName { get; set; }
        [Column("CareerPostCode_id")]
        public int? CareerPostCodeId { get; set; }
        [Column("CareerCity_id")]
        public int? CareerCityId { get; set; }
        [Column("CareerAddress_id")]
        public int? CareerAddressId { get; set; }
        [Column("CareerDeliveryRegion_id")]
        public int? CareerDeliveryRegionId { get; set; }
        [Column("Account_id")]
        public int? AccountId { get; set; }
        public int? CareerType { get; set; }

        [ForeignKey(nameof(CareerAddressId))]
        [InverseProperty(nameof(Address.Career))]
        public virtual Address CareerAddress { get; set; }
        [ForeignKey(nameof(CareerCityId))]
        [InverseProperty(nameof(City.Career))]
        public virtual City CareerCity { get; set; }
        [ForeignKey(nameof(CareerDeliveryRegionId))]
        [InverseProperty(nameof(DeliveryRegion.Career))]
        public virtual DeliveryRegion CareerDeliveryRegion { get; set; }
        [ForeignKey(nameof(CareerPostCodeId))]
        [InverseProperty(nameof(Postcode.Career))]
        public virtual Postcode CareerPostCode { get; set; }
        [InverseProperty("Career")]
        public virtual ICollection<CareerOrder> CareerOrder { get; set; }
        [InverseProperty("Career")]
        public virtual ICollection<Location> Location { get; set; }
        [InverseProperty("Career")]
        public virtual ICollection<PurchaseItem> PurchaseItem { get; set; }
    }
}
