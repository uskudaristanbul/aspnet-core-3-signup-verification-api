using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Entities
{
    public partial class FavoredStore
    {
        [Key]
        [Column("Store_id")]
        public int StoreId { get; set; }
        [Key]
        [Column("Customer_id")]
        public int CustomerId { get; set; }
        public bool? IsFavored { get; set; }
        [Column("Category_id")]
        public int? CategoryId { get; set; }

        [ForeignKey(nameof(CategoryId))]
        [InverseProperty("FavoredStore")]
        public virtual Category Category { get; set; }
        [ForeignKey(nameof(CustomerId))]
        [InverseProperty("FavoredStore")]
        public virtual Customer Customer { get; set; }
        [ForeignKey(nameof(StoreId))]
        [InverseProperty("FavoredStore")]
        public virtual Store Store { get; set; }
    }
}
