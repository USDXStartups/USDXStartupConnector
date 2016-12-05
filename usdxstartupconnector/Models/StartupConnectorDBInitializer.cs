using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace usdxstartupconnector.Models
{
    public class StartupConnectorDBInitializer: System.Data.Entity.DropCreateDatabaseIfModelChanges<StartupConnectorDBContext>
    {
        protected override void Seed(StartupConnectorDBContext db)
        {
            // Seeding DB 

            var cards = new List<StartupCard>
            {
                new StartupCard {ID = Guid.NewGuid(), Name="optimusprime", ContactEmail="test@test.com", ContactName="Test", Location="Location", Inquiry="Demo", Category="Category", RequestDate=DateTime.Now },
                new StartupCard {ID = Guid.NewGuid(), Name="bumblebee",ContactEmail="test@test.com", ContactName="Test", Location="Location", Inquiry="Demo", Category="Category", RequestDate=DateTime.Now  },
                new StartupCard {ID = Guid.NewGuid(), Name="jazz",ContactEmail="test@test.com", ContactName="Test", Location="Location", Inquiry="Demo", Category="Category", RequestDate=DateTime.Now  },
                new StartupCard {ID = Guid.NewGuid(), Name="sideswipe",ContactEmail="test@test.com", ContactName="Test", Location="Location", Inquiry="Demo", Category="Category", RequestDate=DateTime.Now  },
                new StartupCard {ID = Guid.NewGuid(), Name="jetfire", ContactEmail="test@test.com", ContactName="Test",Location="Location", Inquiry="Demo", Category="Category", RequestDate=DateTime.Now  },
            };

            cards.ForEach(s => db.StartupCards.Add(s));
            db.SaveChanges();

        }
    }
}