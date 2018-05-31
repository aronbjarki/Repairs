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
            InProgress c1 = new InProgress()
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

            InProgress c2 = new InProgress()
            {
                Name = "Karl Pétur",
                Kennitala = "231187-2459",
                Phone = "581-2345",
                Email = "Kallicool@gmail.com",

                Tegund = "Toshiba",
                Aukahlutir = "Taska",
                Password = "Testtest",
                Bilunarlýsing = "Tölva sprakk"
            };
            context.InProgress.AddOrUpdate(
                c => c.Name,
                c1,
                c2
            );
            context.SaveChanges();
            #endregion

            #region Delivered
            Delivered d1 = new Delivered()
            {
                Name = "Smári Pétur",
                Kennitala = "141295-2349",
                Phone = "876-4973",
                Email = "Pesi@gmail.com",

                Tegund = "Dell",
                Aukahlutir = "Hleðslutæki",
                Password = "pesitest",
                Bilunarlýsing = "Tölva er samkyneigð"
            };
            context.Delivered.AddOrUpdate(
                d => d.Name,
                d1
            );
            context.SaveChanges();
            #endregion

            #region NotDelivered
            NotDelivered n1 = new NotDelivered()
            {
                Name = "Guðmundur Þórir",
                Kennitala = "181094-2389",
                Phone = "846-1279",
                Email = "Gummith@outlook.com",

                Tegund = "HP",
                Aukahlutir = "Hleðslutæki",
                Password = "Gummi",
                Bilunarlýsing = "Tölva er ekki samkyneigð"
            };
            context.NotDelivered.AddOrUpdate(
                n => n.Name,
                n1
            );
            context.SaveChanges();
            #endregion
        }
    }
}
