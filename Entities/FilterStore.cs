using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Entities
{
    public partial class FilterStore
    {
        public FilterStore()
        {
            FilterStoreStore = new HashSet<FilterStoreStore>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(1000)]
        public string Descripton { get; set; }
        [StringLength(100)]
        public string Type { get; set; }

        [InverseProperty("StoreFeature")]
        public virtual ICollection<FilterStoreStore> FilterStoreStore { get; set; }
    }
}
