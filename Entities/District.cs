using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Entities
{
    [Table("District", Schema = "dbo")]
    public partial class District
    {
        public District()
        {
            Region = new HashSet<Region>();
        }

        [Key]
        [Column("District_id")]
        public int DistrictId { get; set; }
        [StringLength(100)]
        public string DistrictName { get; set; }
        [StringLength(10)]
        public string PostcodePart { get; set; }

        [InverseProperty("District")]
        public virtual ICollection<Region> Region { get; set; }
    }
}
