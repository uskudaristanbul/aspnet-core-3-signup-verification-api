using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Entities
{
    public partial class WishlistItem
    {
        [Key]
        [Column("item_id")]
        public int ItemId { get; set; }
        [Column("Product_id")]
        public int? ProductId { get; set; }
        [Column("WishList_id")]
        public int? WishListId { get; set; }

        [ForeignKey(nameof(ProductId))]
        [InverseProperty("WishlistItem")]
        public virtual Product Product { get; set; }
        [ForeignKey(nameof(WishListId))]
        [InverseProperty("WishlistItem")]
        public virtual WishList WishList { get; set; }
    }
}
