using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Entities
{
    [Table("SellerBrand", Schema = "tekyerco_kozmi")]
    public partial class SellerBrand
    {
        public SellerBrand()
        {
            Store = new HashSet<Store>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [StringLength(200)]
        public string BrandName { get; set; }
        public string Description { get; set; }

        [InverseProperty("Brand")]
        public virtual ICollection<Store> Store { get; set; }
    }
}
