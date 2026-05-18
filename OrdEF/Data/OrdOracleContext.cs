using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Ord.EF.Models;

namespace Ord.EF.Data;

public partial class OrdOracleContext : DbContext
{
    public OrdOracleContext()
    {
    }

    public OrdOracleContext(DbContextOptions<OrdOracleContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Address> Addresses { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<CustomerAddress> CustomerAddresses { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderItem> OrderItems { get; set; }

    public virtual DbSet<OrderStatus> OrderStatuses { get; set; }

    public virtual DbSet<Payment> Payments { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<ProductCategory> ProductCategories { get; set; }

    public virtual DbSet<ProductPrice> ProductPrices { get; set; }

    public virtual DbSet<Shipment> Shipments { get; set; }

    public virtual DbSet<VwProductMaxPriceIncrease> VwProductMaxPriceIncreases { get; set; }

    public virtual DbSet<VwProductPrice> VwProductPrices { get; set; }

    public virtual DbSet<Zip> Zips { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseOracle("User Id=***REMOVED***;Password=***REMOVED***;Data Source=54.198.204.133:1521/FREEPDB1");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .HasDefaultSchema("***REMOVED***")
            .UseCollation("USING_NLS_COMP");

        modelBuilder.Entity<Address>(entity =>
        {
            entity.ToTable("ADDRESS");

            entity.Property(e => e.AddressId).HasColumnName("ADDRESS_ID");
            entity.Property(e => e.AddressCity)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ADDRESS_CITY");
            entity.Property(e => e.AddressCrtdDt)
                .ValueGeneratedOnAdd()
                .HasColumnType("DATE")
                .HasColumnName("ADDRESS_CRTD_DT");
            entity.Property(e => e.AddressCrtdId)
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd()
                .HasColumnName("ADDRESS_CRTD_ID");
            entity.Property(e => e.AddressLine1)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ADDRESS_LINE1");
            entity.Property(e => e.AddressLine2)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ADDRESS_LINE2");
            entity.Property(e => e.AddressState)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("ADDRESS_STATE");
            entity.Property(e => e.AddressUpdtDt)
                .ValueGeneratedOnAdd()
                .HasColumnType("DATE")
                .HasColumnName("ADDRESS_UPDT_DT");
            entity.Property(e => e.AddressUpdtId)
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd()
                .HasColumnName("ADDRESS_UPDT_ID");
            entity.Property(e => e.AddressZipcode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ADDRESS_ZIPCODE");

            entity.HasOne(d => d.AddressZipcodeNavigation).WithMany(p => p.Addresses)
                .HasForeignKey(d => d.AddressZipcode)
                .HasConstraintName("FK_ADDRESS_ZIP");
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.ToTable("CUSTOMER");

            entity.Property(e => e.CustomerId).HasColumnName("CUSTOMER_ID");
            entity.Property(e => e.CustomerCrtdDt)
                .ValueGeneratedOnAdd()
                .HasColumnType("DATE")
                .HasColumnName("CUSTOMER_CRTD_DT");
            entity.Property(e => e.CustomerCrtdId)
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd()
                .HasColumnName("CUSTOMER_CRTD_ID");
            entity.Property(e => e.CustomerEmail)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("CUSTOMER_EMAIL");
            entity.Property(e => e.CustomerFirstName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CUSTOMER_FIRST_NAME");
            entity.Property(e => e.CustomerLastName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CUSTOMER_LAST_NAME");
            entity.Property(e => e.CustomerUpdtDt)
                .ValueGeneratedOnAdd()
                .HasColumnType("DATE")
                .HasColumnName("CUSTOMER_UPDT_DT");
            entity.Property(e => e.CustomerUpdtId)
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd()
                .HasColumnName("CUSTOMER_UPDT_ID");
        });

        modelBuilder.Entity<CustomerAddress>(entity =>
        {
            entity.ToTable("CUSTOMER_ADDRESS");

            entity.Property(e => e.CustomerAddressId).HasColumnName("CUSTOMER_ADDRESS_ID");
            entity.Property(e => e.CustomerAddressActvInd)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("CUSTOMER_ADDRESS_ACTV_IND");
            entity.Property(e => e.CustomerAddressAddressId).HasColumnName("CUSTOMER_ADDRESS_ADDRESS_ID");
            entity.Property(e => e.CustomerAddressCrtdDt)
                .ValueGeneratedOnAdd()
                .HasColumnType("DATE")
                .HasColumnName("CUSTOMER_ADDRESS_CRTD_DT");
            entity.Property(e => e.CustomerAddressCrtdId)
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd()
                .HasColumnName("CUSTOMER_ADDRESS_CRTD_ID");
            entity.Property(e => e.CustomerAddressCustomerId).HasColumnName("CUSTOMER_ADDRESS_CUSTOMER_ID");
            entity.Property(e => e.CustomerAddressDflt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("CUSTOMER_ADDRESS_DFLT");
            entity.Property(e => e.CustomerAddressUpdtDt)
                .ValueGeneratedOnAdd()
                .HasColumnType("DATE")
                .HasColumnName("CUSTOMER_ADDRESS_UPDT_DT");
            entity.Property(e => e.CustomerAddressUpdtId)
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd()
                .HasColumnName("CUSTOMER_ADDRESS_UPDT_ID");

            entity.HasOne(d => d.CustomerAddressAddress).WithMany(p => p.CustomerAddresses)
                .HasForeignKey(d => d.CustomerAddressAddressId)
                .HasConstraintName("FK_CA_ADDRESS");

            entity.HasOne(d => d.CustomerAddressCustomer).WithMany(p => p.CustomerAddresses)
                .HasForeignKey(d => d.CustomerAddressCustomerId)
                .HasConstraintName("FK_CA_CUSTOMER");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.ToTable("ORDERS");

            entity.Property(e => e.OrderId).HasColumnName("ORDER_ID");
            entity.Property(e => e.CustomerId).HasColumnName("CUSTOMER_ID");
            entity.Property(e => e.OrderDate)
                .HasColumnType("DATE")
                .HasColumnName("ORDER_DATE");
            entity.Property(e => e.OrderStatusId).HasColumnName("ORDER_STATUS_ID");
            entity.Property(e => e.OrdersCrtdDt)
                .ValueGeneratedOnAdd()
                .HasColumnType("DATE")
                .HasColumnName("ORDERS_CRTD_DT");
            entity.Property(e => e.OrdersCrtdId)
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd()
                .HasColumnName("ORDERS_CRTD_ID");
            entity.Property(e => e.OrdersUpdtDt)
                .ValueGeneratedOnAdd()
                .HasColumnType("DATE")
                .HasColumnName("ORDERS_UPDT_DT");
            entity.Property(e => e.OrdersUpdtId)
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd()
                .HasColumnName("ORDERS_UPDT_ID");

            entity.HasOne(d => d.Customer).WithMany(p => p.Orders)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK_ORDERS_CUSTOMER");

            entity.HasOne(d => d.OrderStatus).WithMany(p => p.Orders)
                .HasForeignKey(d => d.OrderStatusId)
                .HasConstraintName("FK_ORDERS_STATUS");
        });

        modelBuilder.Entity<OrderItem>(entity =>
        {
            entity.ToTable("ORDER_ITEM");

            entity.Property(e => e.OrderItemId).HasColumnName("ORDER_ITEM_ID");
            entity.Property(e => e.OrderId).HasColumnName("ORDER_ID");
            entity.Property(e => e.OrderItemCrtdDt)
                .ValueGeneratedOnAdd()
                .HasColumnType("DATE")
                .HasColumnName("ORDER_ITEM_CRTD_DT");
            entity.Property(e => e.OrderItemCrtdId)
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd()
                .HasColumnName("ORDER_ITEM_CRTD_ID");
            entity.Property(e => e.OrderItemUpdtDt)
                .ValueGeneratedOnAdd()
                .HasColumnType("DATE")
                .HasColumnName("ORDER_ITEM_UPDT_DT");
            entity.Property(e => e.OrderItemUpdtId)
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd()
                .HasColumnName("ORDER_ITEM_UPDT_ID");
            entity.Property(e => e.ProductPriceId).HasColumnName("PRODUCT_PRICE_ID");
            entity.Property(e => e.Quantity)
                .HasColumnType("NUMBER")
                .HasColumnName("QUANTITY");

            entity.HasOne(d => d.Order).WithMany(p => p.OrderItems)
                .HasForeignKey(d => d.OrderId)
                .HasConstraintName("FK_OI_ORDER");

            entity.HasOne(d => d.ProductPrice).WithMany(p => p.OrderItems)
                .HasForeignKey(d => d.ProductPriceId)
                .HasConstraintName("FK_OI_PP");
        });

        modelBuilder.Entity<OrderStatus>(entity =>
        {
            entity.ToTable("ORDER_STATUS");

            entity.Property(e => e.OrderStatusId).HasColumnName("ORDER_STATUS_ID");
            entity.Property(e => e.OrderStatusCrtdDt)
                .ValueGeneratedOnAdd()
                .HasColumnType("DATE")
                .HasColumnName("ORDER_STATUS_CRTD_DT");
            entity.Property(e => e.OrderStatusCrtdId)
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd()
                .HasColumnName("ORDER_STATUS_CRTD_ID");
            entity.Property(e => e.OrderStatusUpdtDt)
                .ValueGeneratedOnAdd()
                .HasColumnType("DATE")
                .HasColumnName("ORDER_STATUS_UPDT_DT");
            entity.Property(e => e.OrderStatusUpdtId)
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd()
                .HasColumnName("ORDER_STATUS_UPDT_ID");
            entity.Property(e => e.StatusName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STATUS_NAME");
        });

        modelBuilder.Entity<Payment>(entity =>
        {
            entity.ToTable("PAYMENT");

            entity.Property(e => e.PaymentId).HasColumnName("PAYMENT_ID");
            entity.Property(e => e.PaymentAmount)
                .HasColumnType("NUMBER(10,2)")
                .HasColumnName("PAYMENT_AMOUNT");
            entity.Property(e => e.PaymentCrtdDt)
                .ValueGeneratedOnAdd()
                .HasColumnType("DATE")
                .HasColumnName("PAYMENT_CRTD_DT");
            entity.Property(e => e.PaymentCrtdId)
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd()
                .HasColumnName("PAYMENT_CRTD_ID");
            entity.Property(e => e.PaymentDate)
                .HasColumnType("DATE")
                .HasColumnName("PAYMENT_DATE");
            entity.Property(e => e.PaymentMethod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PAYMENT_METHOD");
            entity.Property(e => e.PaymentOrdersId).HasColumnName("PAYMENT_ORDERS_ID");
            entity.Property(e => e.PaymentUpdtDt)
                .ValueGeneratedOnAdd()
                .HasColumnType("DATE")
                .HasColumnName("PAYMENT_UPDT_DT");
            entity.Property(e => e.PaymentUpdtId)
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd()
                .HasColumnName("PAYMENT_UPDT_ID");

            entity.HasOne(d => d.PaymentOrders).WithMany(p => p.Payments)
                .HasForeignKey(d => d.PaymentOrdersId)
                .HasConstraintName("FK_PAY_ORDERS");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.ToTable("PRODUCT");

            entity.Property(e => e.ProductId).HasColumnName("PRODUCT_ID");
            entity.Property(e => e.ProductCrtdDt)
                .ValueGeneratedOnAdd()
                .HasColumnType("DATE")
                .HasColumnName("PRODUCT_CRTD_DT");
            entity.Property(e => e.ProductCrtdId)
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd()
                .HasColumnName("PRODUCT_CRTD_ID");
            entity.Property(e => e.ProductName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("PRODUCT_NAME");
            entity.Property(e => e.ProductUpdtDt)
                .ValueGeneratedOnAdd()
                .HasColumnType("DATE")
                .HasColumnName("PRODUCT_UPDT_DT");
            entity.Property(e => e.ProductUpdtId)
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd()
                .HasColumnName("PRODUCT_UPDT_ID");
        });

        modelBuilder.Entity<ProductCategory>(entity =>
        {
            entity.ToTable("PRODUCT_CATEGORY");

            entity.Property(e => e.ProductCategoryId).HasColumnName("PRODUCT_CATEGORY_ID");
            entity.Property(e => e.ProductCategoryCrtdDt)
                .ValueGeneratedOnAdd()
                .HasColumnType("DATE")
                .HasColumnName("PRODUCT_CATEGORY_CRTD_DT");
            entity.Property(e => e.ProductCategoryCrtdId)
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd()
                .HasColumnName("PRODUCT_CATEGORY_CRTD_ID");
            entity.Property(e => e.ProductCategoryName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PRODUCT_CATEGORY_NAME");
            entity.Property(e => e.ProductCategoryUpdtDt)
                .ValueGeneratedOnAdd()
                .HasColumnType("DATE")
                .HasColumnName("PRODUCT_CATEGORY_UPDT_DT");
            entity.Property(e => e.ProductCategoryUpdtId)
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd()
                .HasColumnName("PRODUCT_CATEGORY_UPDT_ID");
        });

        modelBuilder.Entity<ProductPrice>(entity =>
        {
            entity.ToTable("PRODUCT_PRICE");

            entity.Property(e => e.ProductPriceId).HasColumnName("PRODUCT_PRICE_ID");
            entity.Property(e => e.ProductPriceCrtdDt)
                .ValueGeneratedOnAdd()
                .HasColumnType("DATE")
                .HasColumnName("PRODUCT_PRICE_CRTD_DT");
            entity.Property(e => e.ProductPriceCrtdId)
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd()
                .HasColumnName("PRODUCT_PRICE_CRTD_ID");
            entity.Property(e => e.ProductPriceEffDate)
                .HasColumnType("DATE")
                .HasColumnName("PRODUCT_PRICE_EFF_DATE");
            entity.Property(e => e.ProductPricePrice)
                .HasColumnType("NUMBER(10,2)")
                .HasColumnName("PRODUCT_PRICE_PRICE");
            entity.Property(e => e.ProductPriceProductId).HasColumnName("PRODUCT_PRICE_PRODUCT_ID");
            entity.Property(e => e.ProductPriceUpdtDt)
                .ValueGeneratedOnAdd()
                .HasColumnType("DATE")
                .HasColumnName("PRODUCT_PRICE_UPDT_DT");
            entity.Property(e => e.ProductPriceUpdtId)
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd()
                .HasColumnName("PRODUCT_PRICE_UPDT_ID");

            entity.HasOne(d => d.ProductPriceProduct).WithMany(p => p.ProductPrices)
                .HasForeignKey(d => d.ProductPriceProductId)
                .HasConstraintName("FK_PP_PRODUCT");
        });

        modelBuilder.Entity<Shipment>(entity =>
        {
            entity.ToTable("SHIPMENT");

            entity.Property(e => e.ShipmentId).HasColumnName("SHIPMENT_ID");
            entity.Property(e => e.ShipmentAddressId).HasColumnName("SHIPMENT_ADDRESS_ID");
            entity.Property(e => e.ShipmentCrtdDt)
                .ValueGeneratedOnAdd()
                .HasColumnType("DATE")
                .HasColumnName("SHIPMENT_CRTD_DT");
            entity.Property(e => e.ShipmentCrtdId)
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd()
                .HasColumnName("SHIPMENT_CRTD_ID");
            entity.Property(e => e.ShipmentDate)
                .HasColumnType("DATE")
                .HasColumnName("SHIPMENT_DATE");
            entity.Property(e => e.ShipmentOrdersId).HasColumnName("SHIPMENT_ORDERS_ID");
            entity.Property(e => e.ShipmentUpdtDt)
                .ValueGeneratedOnAdd()
                .HasColumnType("DATE")
                .HasColumnName("SHIPMENT_UPDT_DT");
            entity.Property(e => e.ShipmentUpdtId)
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd()
                .HasColumnName("SHIPMENT_UPDT_ID");

            entity.HasOne(d => d.ShipmentAddress).WithMany(p => p.Shipments)
                .HasForeignKey(d => d.ShipmentAddressId)
                .HasConstraintName("FK_SHIP_ADDRESS");

            entity.HasOne(d => d.ShipmentOrders).WithMany(p => p.Shipments)
                .HasForeignKey(d => d.ShipmentOrdersId)
                .HasConstraintName("FK_SHIP_ORDERS");
        });

        modelBuilder.Entity<VwProductMaxPriceIncrease>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_PRODUCT_MAX_PRICE_INCREASE");

            entity.Property(e => e.PctIncrease)
                .HasColumnType("NUMBER")
                .HasColumnName("PCT_INCREASE");
            entity.Property(e => e.ProductId).HasColumnName("PRODUCT_ID");
            entity.Property(e => e.ProductName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("PRODUCT_NAME");
            entity.Property(e => e.ProductPriceId).HasColumnName("PRODUCT_PRICE_ID");
        });

        modelBuilder.Entity<VwProductPrice>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_PRODUCT_PRICE");

            entity.Property(e => e.EndDate)
                .HasColumnType("DATE")
                .HasColumnName("END_DATE");
            entity.Property(e => e.ProductId).HasColumnName("PRODUCT_ID");
            entity.Property(e => e.ProductName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("PRODUCT_NAME");
            entity.Property(e => e.ProductPriceId).HasColumnName("PRODUCT_PRICE_ID");
            entity.Property(e => e.ProductPricePrice)
                .HasColumnType("NUMBER(10,2)")
                .HasColumnName("PRODUCT_PRICE_PRICE");
            entity.Property(e => e.StartDate)
                .HasColumnType("DATE")
                .HasColumnName("START_DATE");
        });

        modelBuilder.Entity<Zip>(entity =>
        {
            entity.HasKey(e => e.Zipcode);

            entity.ToTable("ZIP");

            entity.Property(e => e.Zipcode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ZIPCODE");
            entity.Property(e => e.City)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CITY");
            entity.Property(e => e.State)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("STATE");
            entity.Property(e => e.ZipCrtdDt)
                .ValueGeneratedOnAdd()
                .HasColumnType("DATE")
                .HasColumnName("ZIP_CRTD_DT");
            entity.Property(e => e.ZipCrtdId)
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd()
                .HasColumnName("ZIP_CRTD_ID");
            entity.Property(e => e.ZipUpdtDt)
                .ValueGeneratedOnAdd()
                .HasColumnType("DATE")
                .HasColumnName("ZIP_UPDT_DT");
            entity.Property(e => e.ZipUpdtId)
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd()
                .HasColumnName("ZIP_UPDT_ID");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
