using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Entities
{
    public partial class Customer
    {
        public Customer()
        {
            Cart = new HashSet<Cart>();
            CustomerAddress = new HashSet<CustomerAddress>();
            FavoredProduct = new HashSet<FavoredProduct>();
            FavoredStore = new HashSet<FavoredStore>();
            Order = new HashSet<Order>();
            WishList = new HashSet<WishList>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("first_name")]
        [StringLength(255)]
        public string FirstName { get; set; }
        [Column("last_name")]
        [StringLength(255)]
        public string LastName { get; set; }
        [Column("phone")]
        [StringLength(25)]
        public string Phone { get; set; }
        [Required]
        [Column("email")]
        [StringLength(255)]
        public string Email { get; set; }
        public int? PostCode { get; set; }
        [StringLength(500)]
        public string RefreshToken { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? RefreshTokenEndDate { get; set; }

        [InverseProperty("Customer")]
        public virtual ICollection<Cart> Cart { get; set; }
        [InverseProperty("Customer")]
        public virtual ICollection<CustomerAddress> CustomerAddress { get; set; }
        [InverseProperty("Cumstomer")]
        public virtual ICollection<FavoredProduct> FavoredProduct { get; set; }
        [InverseProperty("Customer")]
        public virtual ICollection<FavoredStore> FavoredStore { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<Order> Order { get; set; }
        [InverseProperty("Customer")]
        public virtual ICollection<WishList> WishList { get; set; }
    }
}
