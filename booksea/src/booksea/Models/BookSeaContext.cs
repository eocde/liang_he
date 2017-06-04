using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace booksea.Models
{
    public partial class BookSeaContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
            optionsBuilder.UseSqlServer(@"Data Source=localhost;Initial Catalog=BookSea;Persist Security Info=True;User ID=sa;Password=123456");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BigImg)
                    .HasColumnName("bigImg")
                    .HasMaxLength(100);

                entity.Property(e => e.BookDescription)
                    .HasColumnName("bookDescription")
                    .HasMaxLength(2000);

                entity.Property(e => e.BookFeature)
                    .HasColumnName("bookFeature")
                    .HasMaxLength(200);

                entity.Property(e => e.BookId)
                    .HasColumnName("bookId")
                    .HasMaxLength(20);

                entity.Property(e => e.BookName)
                    .HasColumnName("bookName")
                    .HasMaxLength(20);

                entity.Property(e => e.Bookmeaning)
                    .HasColumnName("bookmeaning")
                    .HasMaxLength(500);

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.SmallImg)
                    .HasColumnName("smallImg")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<BookClass>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.TheBook).HasColumnName("theBook");

                entity.Property(e => e.TheBookType).HasColumnName("theBookType");
            });

            modelBuilder.Entity<BookType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ClassifType)
                    .HasColumnName("classifType")
                    .HasMaxLength(100);

                entity.Property(e => e.TyptName)
                    .HasColumnName("typtName")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(20);

                entity.Property(e => e.Province).HasColumnName("province");
            });

            modelBuilder.Entity<Consigenn>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AreaName).HasColumnName("areaName");

                entity.Property(e => e.DoorNumber)
                    .HasColumnName("doorNumber")
                    .HasMaxLength(20);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50);

                entity.Property(e => e.HomePhone)
                    .HasColumnName("homePhone")
                    .HasMaxLength(20);

                entity.Property(e => e.MobilePhone)
                    .HasColumnName("mobilePhone")
                    .HasMaxLength(20);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(20);

                entity.Property(e => e.OfficePhone)
                    .HasColumnName("officePhone")
                    .HasMaxLength(20);

                entity.Property(e => e.Qqnumber)
                    .HasColumnName("qqnumber")
                    .HasMaxLength(20);

                entity.Property(e => e.RoadName)
                    .HasColumnName("roadName")
                    .HasMaxLength(100);

                entity.Property(e => e.StreetName)
                    .HasColumnName("streetName")
                    .HasMaxLength(100);

                entity.Property(e => e.ZipCode).HasColumnName("zipCode");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CustomerType).HasColumnName("customerType");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(20);

                entity.Property(e => e.HomePhone)
                    .HasColumnName("homePhone")
                    .HasMaxLength(20);

                entity.Property(e => e.MobilePhone)
                    .HasColumnName("mobilePhone")
                    .HasMaxLength(20);

                entity.Property(e => e.OfficePhone)
                    .HasColumnName("officePhone")
                    .HasMaxLength(20);

                entity.Property(e => e.QqNumber)
                    .HasColumnName("qqNumber")
                    .HasMaxLength(20);

                entity.Property(e => e.RegistDate)
                    .HasColumnName("registDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.UserId)
                    .HasColumnName("userId")
                    .HasMaxLength(20);

                entity.Property(e => e.UserName)
                    .HasColumnName("userName")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<CustomerType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.MinSpending).HasColumnName("minSpending");

                entity.Property(e => e.TypeName)
                    .HasColumnName("typeName")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<CustomerWords>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.TheOrder).HasColumnName("theOrder");

                entity.Property(e => e.Words)
                    .HasColumnName("words")
                    .HasMaxLength(1000);
            });

            modelBuilder.Entity<Division>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Area).HasColumnName("area");

                entity.Property(e => e.DoorName)
                    .HasColumnName("doorName")
                    .HasMaxLength(20);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(20);

                entity.Property(e => e.RodaName)
                    .HasColumnName("rodaName")
                    .HasMaxLength(20);

                entity.Property(e => e.StreetName)
                    .HasColumnName("streetName")
                    .HasMaxLength(20);

                entity.Property(e => e.ZipCode).HasColumnName("zipCode");
            });

            modelBuilder.Entity<News>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Content).HasColumnName("content");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Payment>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AccountName)
                    .HasColumnName("accountName")
                    .HasMaxLength(20);

                entity.Property(e => e.AccountNo)
                    .HasColumnName("accountNo")
                    .HasMaxLength(20);

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.PaymentState).HasColumnName("paymentState");

                entity.Property(e => e.ThePaymentType).HasColumnName("thePaymentType");

                entity.Property(e => e.TransNo)
                    .HasColumnName("transNo")
                    .HasMaxLength(20);

                entity.Property(e => e.TransTime)
                    .HasColumnName("transTime")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<PaymentType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BigImg)
                    .HasColumnName("bigImg")
                    .HasMaxLength(100);

                entity.Property(e => e.MethodName)
                    .HasColumnName("methodName")
                    .HasMaxLength(20);

                entity.Property(e => e.SmallImg)
                    .HasColumnName("smallImg")
                    .HasMaxLength(100);

                entity.Property(e => e.TypeName)
                    .HasColumnName("typeName")
                    .HasMaxLength(20);

                entity.Property(e => e.Url)
                    .HasColumnName("url")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<PriceList>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.RealPrice).HasColumnName("realPrice");

                entity.Property(e => e.TheBook).HasColumnName("theBook");

                entity.Property(e => e.TheCustomerType).HasColumnName("theCustomerType");
            });

            modelBuilder.Entity<Province>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Receipt>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ReceiptFile)
                    .HasColumnName("receiptFile")
                    .HasMaxLength(500);

                entity.Property(e => e.TheOrder).HasColumnName("theOrder");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<TheOrder>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Amt).HasColumnName("amt");

                entity.Property(e => e.Customer).HasColumnName("customer");

                entity.Property(e => e.OrderState).HasColumnName("orderState");

                entity.Property(e => e.OrderTime)
                    .HasColumnName("orderTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.TheBook).HasColumnName("theBook");

                entity.Property(e => e.TheConsignee).HasColumnName("theConsignee");

                entity.Property(e => e.TheDeliverer).HasColumnName("theDeliverer");

                entity.Property(e => e.ThePayment).HasColumnName("thePayment");

                entity.Property(e => e.Theclerk).HasColumnName("theclerk");
            });

            modelBuilder.Entity<UserInfo>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50);

                entity.Property(e => e.HomePhone)
                    .HasColumnName("homePhone")
                    .HasMaxLength(20);

                entity.Property(e => e.MobilePhone)
                    .HasColumnName("mobilePhone")
                    .HasMaxLength(20);

                entity.Property(e => e.OfficePhone)
                    .HasColumnName("officePhone")
                    .HasMaxLength(20);

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasMaxLength(20);

                entity.Property(e => e.QqNumber)
                    .HasColumnName("qqNumber")
                    .HasMaxLength(20);

                entity.Property(e => e.TheDivision).HasColumnName("theDivision");

                entity.Property(e => e.TheRole).HasColumnName("theRole");

                entity.Property(e => e.UserId)
                    .HasColumnName("userId")
                    .HasMaxLength(20);

                entity.Property(e => e.UserName)
                    .HasColumnName("userName")
                    .HasMaxLength(20);

                entity.Property(e => e.UserState).HasColumnName("userState");
            });
        }

        public virtual DbSet<Book> Book { get; set; }
        public virtual DbSet<BookClass> BookClass { get; set; }
        public virtual DbSet<BookType> BookType { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Consigenn> Consigenn { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<CustomerType> CustomerType { get; set; }
        public virtual DbSet<CustomerWords> CustomerWords { get; set; }
        public virtual DbSet<Division> Division { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<Payment> Payment { get; set; }
        public virtual DbSet<PaymentType> PaymentType { get; set; }
        public virtual DbSet<PriceList> PriceList { get; set; }
        public virtual DbSet<Province> Province { get; set; }
        public virtual DbSet<Receipt> Receipt { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<TheOrder> TheOrder { get; set; }
        public virtual DbSet<UserInfo> UserInfo { get; set; }
    }
}