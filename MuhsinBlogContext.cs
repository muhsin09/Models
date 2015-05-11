using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity;

namespace MuhsinBlog.Models
{
    public class MuhsinBlogContext
    {
        //Daha sonra veritabanımızda, tablo olarak temsil edilecek tüm sınıflarımızı DbSet<..> içerisinde tek tek
        //çağırıyoruz. Sonuna s takısı koyduğumuza dikkat edin. Böylelikle bunun tablo olduğunu anlıyor olacağız.
        //Önceki yazımızda bahsettiğimiz gibi, sonunda zaten s olan bir sınıf ismimiz varsa, bu sefer de s takısını
        //kaldırabiliriz.
        public DbSet<Tag> Etikets { get; set; }
        public DbSet<Article> Makales { get; set; }
        public DbSet<Users> Uyes { get; set; }
        public DbSet<Comment> Yorums { get; set; }

        protected  void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}