using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Entities
{
    public partial class PostCodeDistrict
    {
        public PostCodeDistrict()
        {
            Postcode = new HashSet<Postcode>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("PostCodeDistrict")]
        [StringLength(10)]
        public string PostCodeDistrict1 { get; set; }
        [Column("PostCodeArea_id")]
        public int? PostCodeAreaId { get; set; }
        [Column("City_id")]
        public int? CityId { get; set; }

        [InverseProperty("PostCodeDistrict")]
        public virtual ICollection<Postcode> Postcode { get; set; }
    }
}
