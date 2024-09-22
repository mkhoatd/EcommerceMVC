using EcommerceMVC.Models;

namespace EcommerceMVC.Data;

    public static class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            // Look for any products.
            if (context.Products.Any())
            {
                return;   // DB has been seeded
            }

            var products = new Product[]
            {
                new Product{Id = 1, Name="Laptop", Description="High-performance laptop", Price=999.99m},
                new Product{Id = 2, Name="Smartphone", Description="Latest model smartphone", Price=699.99m},
                new Product{Id = 3, Name="Headphones", Description="Noise-cancelling headphones", Price=249.99m},
                new Product{Id = 4, Name="Tablet", Description="10-inch tablet", Price=399.99m},
                new Product{Id = 5, Name="Smartwatch", Description="Fitness tracking smartwatch", Price=199.99m},
                new Product{Id = 6, Name="Camera", Description="Digital SLR camera", Price=799.99m},
                new Product{Id = 7, Name="Gaming Console", Description="Next-gen gaming console", Price=499.99m}
            };

            context.Products.AddRange(products);
            context.SaveChanges();

            var orders = new Order[]
            {
                new Order{Id = 1, OrderDate=DateTime.Now.AddDays(-10), TotalAmount=1699.98m},
                new Order{Id = 2, OrderDate=DateTime.Now.AddDays(-5), TotalAmount=449.98m},
                new Order{Id = 3, OrderDate=DateTime.Now.AddDays(-2), TotalAmount=799.99m}
            };

            context.Orders.AddRange(orders);
            context.SaveChanges();

            var orderItems = new OrderItem[]
            {
                new OrderItem{OrderId=1, ProductId=1, Quantity=1, Price=999.99m},
                new OrderItem{OrderId=1, ProductId=3, Quantity=1, Price=699.99m},
                new OrderItem{OrderId=2, ProductId=2, Quantity=1, Price=249.99m},
                new OrderItem{OrderId=2, ProductId=5, Quantity=1, Price=199.99m},
                new OrderItem{OrderId=3, ProductId=6, Quantity=1, Price=799.99m}
            };

            context.OrderItems.AddRange(orderItems);
            context.SaveChanges();
        }
    }