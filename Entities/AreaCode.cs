using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Entities
{
    [Table("AreaCode", Schema = "tekyerco_kozmi")]
    public partial class AreaCode
    {
        public AreaCode()
        {
            Postcode = new HashSet<Postcode>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [StringLength(10)]
        public string AreaCodeText { get; set; }
        [Column("Country_id")]
        public int? CountryId { get; set; }
        [Column("City_id")]
        public int? CityId { get; set; }
        [Column("District_id")]
        public int? DistrictId { get; set; }

        [InverseProperty("AreaCode")]
        public virtual ICollection<Postcode> Postcode { get; set; }
    }
}
