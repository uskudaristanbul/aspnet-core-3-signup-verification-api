using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using WebApi.Entities;

namespace WebApi.Helpers
{
    public class DataContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<AreaCode> AreaCode { get; set; }
        public virtual DbSet<Attribute> Attribute { get; set; }
        public virtual DbSet<Career> Career { get; set; }
        public virtual DbSet<CareerOrder> CareerOrder { get; set; }
        public virtual DbSet<Cart> Cart { get; set; }
        public virtual DbSet<CartItem> CartItem { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Comment> Comment { get; set; }
        public virtual DbSet<Contact> Contact { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<CustomerAddress> CustomerAddress { get; set; }
        public virtual DbSet<DeliveryRegion> DeliveryRegion { get; set; }
        public virtual DbSet<District> District { get; set; }
        public virtual DbSet<FavoredProduct> FavoredProduct { get; set; }
        public virtual DbSet<FavoredStore> FavoredStore { get; set; }
        public virtual DbSet<FilterStore> FilterStore { get; set; }
        public virtual DbSet<FilterStoreStore> FilterStoreStore { get; set; }
        public virtual DbSet<Image> Image { get; set; }
        public virtual DbSet<Layout> Layout { get; set; }
        public virtual DbSet<LayoutItem> LayoutItem { get; set; }
        public virtual DbSet<LayoutLayoutItem> LayoutLayoutItem { get; set; }
        public virtual DbSet<Location> Location { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<OrderItem> OrderItem { get; set; }
        public virtual DbSet<OrderSlots> OrderSlots { get; set; }
        public virtual DbSet<Payment> Payment { get; set; }
        public virtual DbSet<PostCodeDistance> PostCodeDistance { get; set; }
        public virtual DbSet<PostCodeDistrict> PostCodeDistrict { get; set; }
        public virtual DbSet<PostCodeSector> PostCodeSector { get; set; }
        public virtual DbSet<Postcode> Postcode { get; set; }
        public virtual DbSet<PostcodeDeliveryDate> PostcodeDeliveryDate { get; set; }
        public virtual DbSet<PostcodeStores> PostcodeStores { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ProductAlternateProduct> ProductAlternateProduct { get; set; }
        public virtual DbSet<ProductBrand> ProductBrand { get; set; }
        public virtual DbSet<ProductsStores> ProductsStores { get; set; }
        public virtual DbSet<Purchase> Purchase { get; set; }
        public virtual DbSet<PurchaseItem> PurchaseItem { get; set; }
        public virtual DbSet<Region> Region { get; set; }
        public virtual DbSet<RegionStreet> RegionStreet { get; set; }
        public virtual DbSet<SellerBrand> SellerBrand { get; set; }
        public virtual DbSet<ShopGroup> ShopGroup { get; set; }
        public virtual DbSet<ShopGroupProduct> ShopGroupProduct { get; set; }
        public virtual DbSet<Slot> Slot { get; set; }
        public virtual DbSet<SlotPattern> SlotPattern { get; set; }
        public virtual DbSet<Staff> Staff { get; set; }
        public virtual DbSet<Stock> Stock { get; set; }
        public virtual DbSet<Store> Store { get; set; }
        public virtual DbSet<StoreCategory> StoreCategory { get; set; }
        public virtual DbSet<Street> Street { get; set; }
        public virtual DbSet<Supplier> Supplier { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserShoppingCartProducts> UserShoppingCartProducts { get; set; }
        public virtual DbSet<Voucher> Voucher { get; set; }
        public virtual DbSet<WishList> WishList { get; set; }
        public virtual DbSet<WishlistItem> WishlistItem { get; set; }

        private readonly IConfiguration Configuration;

        public DataContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to sqlite database
            options.UseSqlite(Configuration.GetConnectionString("WebApiDatabase"));
        }
    }
}