using WebApi.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Entities
{
    public partial class Comment
    {
        [Key]
        [Column("Comment_id")]
        public int CommentId { get; set; }
        [Column("Comment")]
        public string Comment1 { get; set; }
        [Column("Product_id")]
        public int? ProductId { get; set; }
        [Column("Store_id")]
        public int? StoreId { get; set; }
        [Column("Order_id")]
        public int? OrderId { get; set; }
        [Column(TypeName = "decimal(18, 1)")]
        public decimal? CommentPoint { get; set; }

        [ForeignKey(nameof(OrderId))]
        [InverseProperty("Comment")]
        public virtual Order Order { get; set; }
        [ForeignKey(nameof(ProductId))]
        [InverseProperty("Comment")]
        public virtual Product Product { get; set; }
        [ForeignKey(nameof(StoreId))]
        [InverseProperty("Comment")]
        public virtual Store Store { get; set; }
    }
}
