using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Entities
{
    public partial class Location
    {
        public Location()
        {
            OrderItem = new HashSet<OrderItem>();
            PostcodeNavigation = new HashSet<Postcode>();
            PurchaseItem = new HashSet<PurchaseItem>();
        }

        [Key]
        public int Id { get; set; }
        [StringLength(100)]
        public string LocationName { get; set; }
        [Column("Store_id")]
        public int? StoreId { get; set; }
        [Column("Career_id")]
        public int? CareerId { get; set; }
        [Column("Car_id")]
        public int? CarId { get; set; }
        [Column("Address_id")]
        public int? AddressId { get; set; }
        [Column("Postcode_id")]
        public int? PostcodeId { get; set; }
        [Column("TypeOfLocation_id")]
        public int? TypeOfLocationId { get; set; }
        [Column("Street_id")]
        public int? StreetId { get; set; }
        [Column("Country_id")]
        public int? CountryId { get; set; }
        [Column("City_id")]
        public int? CityId { get; set; }
        [Column("Borough_id")]
        public int? BoroughId { get; set; }
        [Column("District_id")]
        public int? DistrictId { get; set; }
        [Column("Avenue_id")]
        public int? AvenueId { get; set; }
        [StringLength(50)]
        public string Latitude { get; set; }
        [StringLength(50)]
        public string Longitude { get; set; }
        [StringLength(50)]
        public string Easting { get; set; }
        [StringLength(50)]
        public string Northing { get; set; }
        [StringLength(6)]
        public string AreaCode { get; set; }
        [StringLength(6)]
        public string DistrictCode { get; set; }
        public int? LondonZone { get; set; }

        [ForeignKey(nameof(AddressId))]
        [InverseProperty("LocationNavigation")]
        public virtual Address Address { get; set; }
        [ForeignKey(nameof(CareerId))]
        [InverseProperty("Location")]
        public virtual Career Career { get; set; }
        [ForeignKey(nameof(PostcodeId))]
        [InverseProperty("Location")]
        public virtual Postcode Postcode { get; set; }
        [ForeignKey(nameof(StoreId))]
        [InverseProperty("Location")]
        public virtual Store Store { get; set; }
        [InverseProperty("Location")]
        public virtual ICollection<OrderItem> OrderItem { get; set; }
        [InverseProperty("LocationNavigation")]
        public virtual ICollection<Postcode> PostcodeNavigation { get; set; }
        [InverseProperty("Location")]
        public virtual ICollection<PurchaseItem> PurchaseItem { get; set; }
    }
}
