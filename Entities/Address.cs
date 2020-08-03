using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApi.Entities;

namespace WebApi.Entities
{
    public partial class Address
    {
        public Address()
        {
            Career = new HashSet<Career>();
            Contact = new HashSet<Contact>();
            CustomerAddress = new HashSet<CustomerAddress>();
            LocationNavigation = new HashSet<Location>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("postcode")]
        [StringLength(50)]
        public string Postcode { get; set; }
        [StringLength(50)]
        public string AddressName { get; set; }
        public int? AddressType { get; set; }
        public bool? IsBilling { get; set; }
        public bool? IsCompany { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(50)]
        public string Surname { get; set; }
        [StringLength(50)]
        public string CompanyName { get; set; }
        public int? CompanyNumber { get; set; }
        [StringLength(50)]
        public string FlatNo { get; set; }
        [StringLength(50)]
        public string BuildingName { get; set; }
        [Column("Street_id")]
        public int? StreetId { get; set; }
        [Column("Area_id")]
        public int? AreaId { get; set; }
        public int? Region { get; set; }
        [StringLength(50)]
        public string Phone { get; set; }
        [StringLength(50)]
        public string Email { get; set; }
        [StringLength(50)]
        public string MobilePhone { get; set; }
        [StringLength(200)]
        public string DescriptionToFind { get; set; }
        [StringLength(50)]
        public string GatePassword { get; set; }
        [StringLength(50)]
        public string ResponsibleName { get; set; }
        [StringLength(50)]
        public string ResponsibleSurname { get; set; }
        [StringLength(50)]
        public string ResponsiblePhone { get; set; }
        public bool? IsPrimary { get; set; }
        public bool? IsActive { get; set; }
        [StringLength(100)]
        public string Location { get; set; }
        [Column("User_id")]
        public int? UserId { get; set; }
        [Column("Account_id")]
        public int? AccountId { get; set; }

        [ForeignKey(nameof(AreaId))]
        [InverseProperty("Address")]
        public virtual Region Area { get; set; }
        [ForeignKey(nameof(Region))]
        [InverseProperty(nameof(DeliveryRegion.Address))]
        public virtual DeliveryRegion RegionNavigation { get; set; }
        [ForeignKey(nameof(StreetId))]
        [InverseProperty("Address")]
        public virtual Street Street { get; set; }
        [ForeignKey(nameof(UserId))]
        [InverseProperty("Address")]
        public virtual User User { get; set; }
        [InverseProperty("CareerAddress")]
        public virtual ICollection<Career> Career { get; set; }
        [InverseProperty("Address")]
        public virtual ICollection<Contact> Contact { get; set; }
        [InverseProperty("Address")]
        public virtual ICollection<CustomerAddress> CustomerAddress { get; set; }
        [InverseProperty("Address")]
        public virtual ICollection<Location> LocationNavigation { get; set; }
    }
}
