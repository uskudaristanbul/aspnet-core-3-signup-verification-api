using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Entities
{
    [Table("Country", Schema = "dbo")]
    public partial class Country
    {
        public Country()
        {
            City = new HashSet<City>();
            Region = new HashSet<Region>();
            Store = new HashSet<Store>();
            Street = new HashSet<Street>();
        }

        [Key]
        [Column("Country_id")]
        public int CountryId { get; set; }
        [StringLength(50)]
        public string CountryName { get; set; }
        [Column("State_id")]
        public int? StateId { get; set; }

        [InverseProperty("Country")]
        public virtual ICollection<City> City { get; set; }
        [InverseProperty("Country")]
        public virtual ICollection<Region> Region { get; set; }
        [InverseProperty("Country")]
        public virtual ICollection<Store> Store { get; set; }
        [InverseProperty("CountryNavigation")]
        public virtual ICollection<Street> Street { get; set; }
    }
}
