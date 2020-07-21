using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApi.Entities;

namespace WebApi.Entities
{
    [Table("Region", Schema = "dbo")]
    public partial class Region
    {
        public Region()
        {
            Address = new HashSet<Address>();
            Street = new HashSet<Street>();
        }

        [Key]
        [Column("Area_id")]
        public int AreaId { get; set; }
        [StringLength(50)]
        public string AreaName { get; set; }
        [Column("District_id")]
        public int? DistrictId { get; set; }
        [Column("City_id")]
        public int? CityId { get; set; }
        [Column("Country_id")]
        public int? CountryId { get; set; }

        [ForeignKey(nameof(CityId))]
        [InverseProperty("Region")]
        public virtual City City { get; set; }
        [ForeignKey(nameof(CountryId))]
        [InverseProperty("Region")]
        public virtual Country Country { get; set; }
        [ForeignKey(nameof(DistrictId))]
        [InverseProperty("Region")]
        public virtual District District { get; set; }
        [InverseProperty("Area")]
        public virtual ICollection<Address> Address { get; set; }
        [InverseProperty("AreaNavigation")]
        public virtual ICollection<Street> Street { get; set; }
    }
}
