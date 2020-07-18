using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Entities
{
    [Table("ShopGroup-Product", Schema = "tekyerco_kozmi")]
    public partial class ShopGroupProduct
    {
        [Column("ShopGroup_id")]
        public int? ShopGroupId { get; set; }
        [Column("Product_id")]
        public int? ProductId { get; set; }
        [Key]
        [Column("Item_id")]
        public int ItemId { get; set; }
    }
}
