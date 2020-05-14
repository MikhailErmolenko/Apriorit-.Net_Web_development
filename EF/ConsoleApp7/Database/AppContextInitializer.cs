using ConsoleApp7.Models;
using System;
using System.Data.Entity;
using System.Linq;

namespace ConsoleApp7.NEDatabase
{
    public class AppContextInitializer : DropCreateDatabaseAlways<ApplicationContext>
    {
        protected override void Seed(ApplicationContext db)
        {
            db.Authors.Add(new Authour
            {
                FirstName = "Виктор\t",
                LastName = "Пелевин",
            });

            db.Authors.Add(new Authour
            {
                FirstName = "Карл\t",
                LastName = "Маркс",
            });

            db.Authors.Add(new Authour
            {
                FirstName = "Дэниел\t",
                LastName = "Киз",
            });

            db.SaveChanges();

            db.Books.Add(new Book
            {
                Authour = db.Authors.Where(a => a.Id == 1).FirstOrDefault(),
                Name = "Священная книга оборотня\t",
                PublishDate = new DateTime(1999, 1, 1),
            });



            db.Books.Add(new Book
            {
                Authour = db.Authors.Where(a => a.Id == 2).FirstOrDefault(),
                Name = "Empire V\t\t\t",
                PublishDate = new DateTime(1999, 1, 1),
            });

            db.Books.Add(new Book
            {
                Authour = db.Authors.Where(a => a.Id == 2).FirstOrDefault(),
                Name = "Капитал\t\t\t\t",
                PublishDate = new DateTime(1999, 1, 1),
            });

            db.Books.Add(new Book
            {
                Authour = db.Authors.Where(a => a.Id == 3).FirstOrDefault(),
                Name = "Цветы для Элджернона\t\t",
                PublishDate = new DateTime(1999, 1, 1),
            });

            db.Books.Add(new Book
            {
                Authour = db.Authors.Where(a => a.Id == 3).FirstOrDefault(),
                Name = "... про Билли Милигана\t\t",
                PublishDate = new DateTime(1999, 1, 1),
            });

            db.SaveChanges();
        }

    }
}
