using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Entities
{
    [Table("Customer-Address", Schema = "dbo")]
    public partial class CustomerAddress
    {
        [Key]
        public int CustomerId { get; set; }
        [Key]
        public int AddressId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateEntered { get; set; }

        [ForeignKey(nameof(AddressId))]
        [InverseProperty("CustomerAddress")]
        public virtual Address Address { get; set; }
        [ForeignKey(nameof(CustomerId))]
        [InverseProperty("CustomerAddress")]
        public virtual Customer Customer { get; set; }
    }
}
