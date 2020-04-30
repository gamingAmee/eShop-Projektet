using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Datalayer;
using ServiceLayer.ProduktService;
using ServiceLayer.ProduktService.Concrete;
using Datalayer.Entities;

namespace UnitTest
{
    [TestClass]
    public class ProduktServiceTest
    {
        [TestMethod]
        public void AddProdukt()
        {
            var options = new DbContextOptionsBuilder<EshopContext>()
                .UseInMemoryDatabase(databaseName: "Add_writes_to_database")
                .Options;

            // Insert seed data into the database using one instance of the context
            using (var context = new EshopContext(options))
            {
                context.Produkter.Add(new Produkt { Navn = "Test", Pris = 1243 });
                context.Produkter.Add(new Produkt { Navn = "Test 2", Pris = 1243 });
                context.Produkter.Add(new Produkt { Navn = "Test 3", Pris = 1243 });
                context.SaveChanges();
            }

            // Use a clean instance of the context to run the test
            using (var context = new EshopContext(options))
            {
                var service = new ListProduktService (context);
                var result = service.AddProdukt();
                Assert.AreEqual(3, result.Count());
            }
        }
    }
}
