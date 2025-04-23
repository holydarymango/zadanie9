using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proect_9.Model
{
    public class ProductDbContext : DbContext
    {
        #region Коструктор 
        public ProductDbContext(DbContextOptions<ProductDbContext> options)
            :base(options)
        {
            Database.EnsureCreated();
        }
        #endregion

        #region Public свойства
        public DbSet<Product> Products { get; set; }
        #endregion

        #region Методы
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(GetProducts());
            base.OnModelCreating(modelBuilder);
        }

        private Product[] GetProducts() => new Product[]
        {
            new Product{ProductID = 1,
                        ProductName = "Томат Чери Краса-Длинная коса",
                        ProductDescription = "это один из самых популярных и востребованных сортов томатов. Он относится к категории индетерминантных, так как растение продолжает расти и плодоносить на протяжении всего периода вегетации. Это делает его особенно ценным для дачников и любителей свежих овощей.",
                        ProductPrice = 100,
                        ProductUnit = 4500},
            new Product{ProductID = 2,
                        ProductName ="Томат Банан желтый",
                        ProductDescription = "Отличным представителем желтоплодных сортов является индетерминантный томат Банан желтый. Универсальный сорт получил название благодаря окраске и вытянутой форме плодов. Предназначен, чтобы его можно было выращивать в теплицах и в огороде, используется для употребления в свежем виде, при цельноплодном консервировании, для приготовления оригинальных кетчупов и соусов.",
                        ProductPrice = 56,
                        ProductUnit = 50000},
            new Product{ProductID = 3,
                        ProductName ="Томат Богатырь Илюша",
                        ProductDescription = "Селекционная новинка выведена ООО «Агрофирма Аэлита» в 2018 году. Относится к растениям индетерминантного типа. Кусты высокорослые, высота составляет 170-190 см, их обязательно нужно подвязывать. Листики длинные, темно-зеленого цвета. На одной кисти образуется 6-8 плодов.",
                        ProductPrice = 400,
                        ProductUnit = 100},
            new Product{ProductID = 4,
                        ProductName ="Томат Грейпфрут",
                        ProductDescription = "Томат Грейпфрут считается растением индетерминантным. Это нештамбовый куст, достигающий в высоту от 2 до 2,5 метров. Соответственно, и пасынкование, и подвязка ему необходимы. Первая кисть обычно сформирована над 8 или 9 листом. Листья похожи на картофельную ботву. Сорт отличает довольно высокая устойчивость к болезням.",
                        ProductPrice = 150,
                        ProductUnit = 4600 }
        };
        #endregion

    }
}
