using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Entities
{
    [Table("ProductBrand", Schema = "production")]
    public partial class ProductBrand
    {
        public ProductBrand()
        {
            Product = new HashSet<Product>();
        }

        [Key]
        [Column("brand_id")]
        public int BrandId { get; set; }
        [Required]
        [Column("brand_name")]
        [StringLength(255)]
        public string BrandName { get; set; }
        [Column("Image_id")]
        public int? ImageId { get; set; }

        [InverseProperty("Brand")]
        public virtual ICollection<Product> Product { get; set; }
    }
}
