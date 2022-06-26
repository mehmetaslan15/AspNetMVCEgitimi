using System;
using System.Collections.Generic;
using System.Data.Entity;  //EF kütüphanesini dahil ediyoruz. 
using System.Linq;
using System.Web;

namespace AspNetMVCEgitimi.NETFramework.Models
{
    public class DatabaseContext : DbContext // DatabaseContext bizim db setlerimizi tutacak classımız. DbContext ise Entity frameworkün vertabanı işlemleri için bize sunduğu class
    {
        public DbSet<Product>  Products { get; set; }  //Veritabanı tablolarımızı temsil edecek classlarımızı dbset olarak tanımlıyoruz. 
        public DbSet<Category> Categories { get; set; }
    }
}