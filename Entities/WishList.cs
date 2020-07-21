using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Entities
{
    [Table("WishList", Schema = "tekyerco_kozmi")]
    public partial class WishList
    {
        public WishList()
        {
            WishlistItem = new HashSet<WishlistItem>();
        }

        [Key]
        [Column("WishList_id")]
        public int WishListId { get; set; }
        [Column("Customer_id")]
        public int? CustomerId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? AddTime { get; set; }

        [ForeignKey(nameof(CustomerId))]
        [InverseProperty("WishList")]
        public virtual Customer Customer { get; set; }
        [InverseProperty("WishList")]
        public virtual ICollection<WishlistItem> WishlistItem { get; set; }
    }
}
