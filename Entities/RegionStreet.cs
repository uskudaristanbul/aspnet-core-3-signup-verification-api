using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApi.Entities;

namespace WebApi.Entities
{
    public partial class RegionStreet
    {
        [Key]
        [Column("Region_id")]
        public int RegionId { get; set; }
        [Key]
        [Column("Street_id")]
        public int StreetId { get; set; }
        [Column(TypeName = "date")]
        public DateTime? UpdateTime { get; set; }

        [ForeignKey(nameof(RegionId))]
        [InverseProperty(nameof(DeliveryRegion.RegionStreet))]
        public virtual DeliveryRegion Region { get; set; }
        [ForeignKey(nameof(StreetId))]
        [InverseProperty("RegionStreet")]
        public virtual Street Street { get; set; }
    }
}
