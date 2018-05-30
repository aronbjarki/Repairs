using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

namespace WpfApp5.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<WpfApp5.ProgramContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(WpfApp5.ProgramContext context)
        {
            #region InProgress
            InProgress i1 = new InProgress()
            {
                Name = "Aron Bjarki",
                Kennitala = "271196-2889",
                Phone = "615-1577",
                Email = "Aronbjarki@outlook.com",

                Tegund = "Acer",
                Aukahlutir = "Hleðslutæki",
                Password = "Test",
                Bilunarlýsing = "Tölva kveikir ekki á sér"

            };
            context.SaveChanges();
        }
    }
}
#endregion