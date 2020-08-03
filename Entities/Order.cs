using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Entities
{
    [Table("Order", Schema = "sales")]
    public partial class Order
    {
        public Order()
        {
            CareerOrder = new HashSet<CareerOrder>();
            Comment = new HashSet<Comment>();
            OrderItem = new HashSet<OrderItem>();
            OrderSlots = new HashSet<OrderSlots>();
            Supplier = new HashSet<Supplier>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("user_id")]
        public int UserId { get; set; }
        [Column("address_id")]
        public int? AddressId { get; set; }
        [Column("postcode")]
        [StringLength(20)]
        public string Postcode { get; set; }
        [Column("order_status")]
        public int? OrderStatus { get; set; }
        [Column("order_date", TypeName = "date")]
        public DateTime? OrderDate { get; set; }
        [Column("required_date", TypeName = "date")]
        public DateTime? RequiredDate { get; set; }
        [Column("shipped_date", TypeName = "date")]
        public DateTime? ShippedDate { get; set; }
        [Column("store_id")]
        public int? StoreId { get; set; }
        [Column("staff_id")]
        public int? StaffId { get; set; }
        public string SignImageLink { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal? DeliveryTotalCost { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal? DeliveryFeeTaken { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FirstTimeVisited { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? SecondTimeVisited { get; set; }
        public int? FirstVisitResult { get; set; }
        public int? SecondVisitResult { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal? DeliveryCareerCost { get; set; }
        public int? OrderType { get; set; }
        [StringLength(250)]
        public string VisitResultDescription { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal? AmountAfterTax { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal? Discount { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal? AmountAfterDiscount { get; set; }
        [StringLength(20)]
        public string Phone { get; set; }

        [ForeignKey(nameof(StaffId))]
        [InverseProperty("Order")]
        public virtual Staff Staff { get; set; }
        [ForeignKey(nameof(StoreId))]
        [InverseProperty("Order")]
        public virtual Store Store { get; set; }
        [ForeignKey(nameof(UserId))]
        [InverseProperty(nameof(Customer.Order))]
        public virtual Customer User { get; set; }
        [InverseProperty("Order")]
        public virtual ICollection<CareerOrder> CareerOrder { get; set; }
        [InverseProperty("Order")]
        public virtual ICollection<Comment> Comment { get; set; }
        [InverseProperty("Order")]
        public virtual ICollection<OrderItem> OrderItem { get; set; }
        [InverseProperty("Order")]
        public virtual ICollection<OrderSlots> OrderSlots { get; set; }
        [InverseProperty("RelatedOrder")]
        public virtual ICollection<Supplier> Supplier { get; set; }
    }
}
