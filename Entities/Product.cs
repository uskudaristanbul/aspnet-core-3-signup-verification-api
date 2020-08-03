using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApi.Entities;

namespace WebApi.Entities
{
    public partial class Product
    {
        public Product()
        {
            CartItem = new HashSet<CartItem>();
            Comment = new HashSet<Comment>();
            FavoredProduct = new HashSet<FavoredProduct>();
            OrderItem = new HashSet<OrderItem>();
            ProductAlternateProductProduct = new HashSet<ProductAlternateProduct>();
            ProductAlternateProductRelatedProduct = new HashSet<ProductAlternateProduct>();
            ProductsStores = new HashSet<ProductsStores>();
            PurchaseItem = new HashSet<PurchaseItem>();
            Stock = new HashSet<Stock>();
            WishlistItem = new HashSet<WishlistItem>();
        }

        [Key]
        [Column("Product_id")]
        public int ProductId { get; set; }
        [Required]
        [Column("Product_name")]
        [StringLength(255)]
        public string ProductName { get; set; }
        [StringLength(200)]
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        [Column("SKU")]
        [StringLength(50)]
        public string Sku { get; set; }
        public string Barcode { get; set; }
        [Column("Brand_id")]
        public int? BrandId { get; set; }
        public string MainImage { get; set; }
        public string Image2 { get; set; }
        public string Image3 { get; set; }
        public string Image4 { get; set; }
        public string Image5 { get; set; }
        [Column("MotherProduct_id")]
        public int? MotherProductId { get; set; }
        [Column("Category_id")]
        public int? CategoryId { get; set; }
        public int? NumberOfSold { get; set; }
        public int? OrderNumber { get; set; }
        public int? UnitType { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal? Amount { get; set; }

        [ForeignKey(nameof(BrandId))]
        [InverseProperty(nameof(ProductBrand.Product))]
        public virtual ProductBrand Brand { get; set; }
        [ForeignKey(nameof(CategoryId))]
        [InverseProperty("Product")]
        public virtual Category Category { get; set; }
        [InverseProperty("Product")]
        public virtual ICollection<CartItem> CartItem { get; set; }
        [InverseProperty("Product")]
        public virtual ICollection<Comment> Comment { get; set; }
        [InverseProperty("Product")]
        public virtual ICollection<FavoredProduct> FavoredProduct { get; set; }
        [InverseProperty("Product")]
        public virtual ICollection<OrderItem> OrderItem { get; set; }
        [InverseProperty(nameof(ProductAlternateProduct.Product))]
        public virtual ICollection<ProductAlternateProduct> ProductAlternateProductProduct { get; set; }
        [InverseProperty(nameof(ProductAlternateProduct.RelatedProduct))]
        public virtual ICollection<ProductAlternateProduct> ProductAlternateProductRelatedProduct { get; set; }
        [InverseProperty("Product")]
        public virtual ICollection<ProductsStores> ProductsStores { get; set; }
        [InverseProperty("Product")]
        public virtual ICollection<PurchaseItem> PurchaseItem { get; set; }
        [InverseProperty("Product")]
        public virtual ICollection<Stock> Stock { get; set; }
        [InverseProperty("Product")]
        public virtual ICollection<WishlistItem> WishlistItem { get; set; }
    }
}
