using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Entities
{
    [Table("City", Schema = "dbo")]
    public partial class City
    {
        public City()
        {
            Career = new HashSet<Career>();
            Region = new HashSet<Region>();
            Store = new HashSet<Store>();
            Street = new HashSet<Street>();
        }

        [Key]
        [Column("City_id")]
        public int CityId { get; set; }
        [StringLength(100)]
        public string CityName { get; set; }
        [Column("Country_id")]
        public int? CountryId { get; set; }
        [Column("State_id")]
        public int? StateId { get; set; }

        [ForeignKey(nameof(CountryId))]
        [InverseProperty("City")]
        public virtual Country Country { get; set; }
        [InverseProperty("CareerCity")]
        public virtual ICollection<Career> Career { get; set; }
        [InverseProperty("City")]
        public virtual ICollection<Region> Region { get; set; }
        [InverseProperty("City")]
        public virtual ICollection<Store> Store { get; set; }
        [InverseProperty("CityNavigation")]
        public virtual ICollection<Street> Street { get; set; }
    }
}
