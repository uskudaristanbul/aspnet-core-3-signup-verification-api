using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Entities
{
    public partial class OrderItem
    {
        public OrderItem()
        {
            InverseAlternativeItem = new HashSet<OrderItem>();
        }

        [Key]
        [Column("item_id")]
        public int ItemId { get; set; }
        [Column("order_id")]
        public int OrderId { get; set; }
        [Column("product_id")]
        public int ProductId { get; set; }
        [Column("quantity")]
        public int Quantity { get; set; }
        [Column("list_price", TypeName = "decimal(10, 2)")]
        public decimal ListPrice { get; set; }
        [Column("discount", TypeName = "decimal(10, 2)")]
        public decimal Discount { get; set; }
        public int? IsDelivered { get; set; }
        [Column("AlternativeItem_id")]
        public int? AlternativeItemId { get; set; }
        [Column("Location_id")]
        public int? LocationId { get; set; }
        public int? ProcessPhase { get; set; }

        [ForeignKey(nameof(AlternativeItemId))]
        [InverseProperty(nameof(OrderItem.InverseAlternativeItem))]
        public virtual OrderItem AlternativeItem { get; set; }
        [ForeignKey(nameof(LocationId))]
        [InverseProperty("OrderItem")]
        public virtual Location Location { get; set; }
        [ForeignKey(nameof(OrderId))]
        [InverseProperty("OrderItem")]
        public virtual Order Order { get; set; }
        [ForeignKey(nameof(ProductId))]
        [InverseProperty("OrderItem")]
        public virtual Product Product { get; set; }
        [InverseProperty(nameof(OrderItem.AlternativeItem))]
        public virtual ICollection<OrderItem> InverseAlternativeItem { get; set; }
    }
}
