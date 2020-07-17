using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Entities
{
    [Table("Category", Schema = "production")]
    public partial class Category
    {
        public Category()
        {
            FavoredStore = new HashSet<FavoredStore>();
            InverseUpCategory = new HashSet<Category>();
            Product = new HashSet<Product>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        [Column("UpCategory_id")]
        public int? UpCategoryId { get; set; }
        public string Image { get; set; }
        [Column("StoreCategory_id")]
        public int? StoreCategoryId { get; set; }
        public int? OrderNumber { get; set; }
        public bool? IsTopProductCategory { get; set; }

        [ForeignKey(nameof(StoreCategoryId))]
        [InverseProperty("Category")]
        public virtual StoreCategory StoreCategory { get; set; }
        [ForeignKey(nameof(UpCategoryId))]
        [InverseProperty(nameof(Category.InverseUpCategory))]
        public virtual Category UpCategory { get; set; }
        [InverseProperty("Category")]
        public virtual ICollection<FavoredStore> FavoredStore { get; set; }
        [InverseProperty(nameof(Category.UpCategory))]
        public virtual ICollection<Category> InverseUpCategory { get; set; }
        [InverseProperty("Category")]
        public virtual ICollection<Product> Product { get; set; }
    }
}
