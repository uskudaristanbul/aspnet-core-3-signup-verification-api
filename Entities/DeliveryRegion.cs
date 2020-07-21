using WebApi.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Entities
{
    [Table("DeliveryRegion", Schema = "dbo")]
    public partial class DeliveryRegion
    {
        public DeliveryRegion()
        {
            Address = new HashSet<Address>();
            Career = new HashSet<Career>();
            RegionStreet = new HashSet<RegionStreet>();
        }

        [Key]
        [Column("Region_id")]
        public int RegionId { get; set; }
        [StringLength(100)]
        public string RegionName { get; set; }
        public int? RegionType { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdateTime { get; set; }

        [InverseProperty("RegionNavigation")]
        public virtual ICollection<Address> Address { get; set; }
        [InverseProperty("CareerDeliveryRegion")]
        public virtual ICollection<Career> Career { get; set; }
        [InverseProperty("Region")]
        public virtual ICollection<RegionStreet> RegionStreet { get; set; }
    }
}
