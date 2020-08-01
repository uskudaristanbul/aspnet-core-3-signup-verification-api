using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Entities
{
    public partial class StoreCategory
    {
        public StoreCategory()
        {
            Category = new HashSet<Category>();
            InverseUpNavigation = new HashSet<StoreCategory>();
            Store = new HashSet<Store>();
        }

        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        public string Image { get; set; }
        public int? Up { get; set; }

        [ForeignKey(nameof(Up))]
        [InverseProperty(nameof(StoreCategory.InverseUpNavigation))]
        public virtual StoreCategory UpNavigation { get; set; }
        [InverseProperty("StoreCategory")]
        public virtual ICollection<Category> Category { get; set; }
        [InverseProperty(nameof(StoreCategory.UpNavigation))]
        public virtual ICollection<StoreCategory> InverseUpNavigation { get; set; }
        [InverseProperty("StoreCategory")]
        public virtual ICollection<Store> Store { get; set; }
    }
}
