using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Entities
{
    [Table("Street", Schema = "dbo")]
    public partial class Street
    {
        public Street()
        {
            Address = new HashSet<Address>();
            RegionStreet = new HashSet<RegionStreet>();
        }

        [Key]
        [Column("Street_id")]
        public int StreetId { get; set; }
        [StringLength(100)]
        public string StreetName { get; set; }
        public int? City { get; set; }
        public int? Area { get; set; }
        public int? Country { get; set; }
        [StringLength(100)]
        public string Location { get; set; }

        [ForeignKey(nameof(Area))]
        [InverseProperty(nameof(Region.Street))]
        public virtual Region AreaNavigation { get; set; }
        [ForeignKey(nameof(City))]
        [InverseProperty("Street")]
        public virtual City CityNavigation { get; set; }
        [ForeignKey(nameof(Country))]
        [InverseProperty("Street")]
        public virtual Country CountryNavigation { get; set; }
        [InverseProperty("Street")]
        public virtual ICollection<Address> Address { get; set; }
        [InverseProperty("Street")]
        public virtual ICollection<RegionStreet> RegionStreet { get; set; }
    }
}
