using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Entities
{
    public partial class Contact
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [StringLength(50)]
        public string ContactOwnerType { get; set; }
        [Column("Store_id")]
        public int? StoreId { get; set; }
        [StringLength(50)]
        public string Phone { get; set; }
        [StringLength(50)]
        public string Email { get; set; }
        [Column("Address_id")]
        public int? AddressId { get; set; }

        [ForeignKey(nameof(AddressId))]
        [InverseProperty("Contact")]
        public virtual Address Address { get; set; }
        [ForeignKey(nameof(StoreId))]
        [InverseProperty("Contact")]
        public virtual Store Store { get; set; }
    }
}
