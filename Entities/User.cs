using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Entities
{
    [Table("User", Schema = "tekyerco_kozmi")]
    public partial class User
    {
        public User()
        {
            Address = new HashSet<Address>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("name")]
        [StringLength(100)]
        public string Name { get; set; }
        [Column("sirname")]
        [StringLength(100)]
        public string Sirname { get; set; }
        [Column("email")]
        [StringLength(100)]
        public string Email { get; set; }
        [Column("phone")]
        [StringLength(50)]
        public string Phone { get; set; }

        [InverseProperty("User")]
        public virtual ICollection<Address> Address { get; set; }
    }
}
