using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Entities
{
    public partial class ProductAlternateProduct
    {
        [Key]
        [Column("Product_id")]
        public int ProductId { get; set; }
        [Key]
        [Column("RelatedProduct_id")]
        public int RelatedProductId { get; set; }
        public int? RelationType { get; set; }
        public int? RelationPower { get; set; }

        [ForeignKey(nameof(ProductId))]
        [InverseProperty("ProductAlternateProductProduct")]
        public virtual Product Product { get; set; }
        [ForeignKey(nameof(RelatedProductId))]
        [InverseProperty("ProductAlternateProductRelatedProduct")]
        public virtual Product RelatedProduct { get; set; }
    }
}
