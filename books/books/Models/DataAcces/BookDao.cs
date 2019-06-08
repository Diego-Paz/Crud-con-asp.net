using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using books.Models.DataModel;

namespace books.Models.DataAcces
{
    public class BookDao
    {
        //to create a record
        public void Create(BookModel u)
        {
            using (var data = new BooksEntities())
            {
                book bok = new book();
                bok.Name = u.Name;
                bok.author = u.author;
                bok.editorial = u.editorial;
                bok.edition = u.edition;
                bok.publication = u.publication;
                bok.id_city = u.id_city;
                bok.Country = u.Country;

                data.book.Add(bok);
                data.SaveChanges();
            }
        }

        public void Delete(decimal id)
        {
            using (var data = new BooksEntities())
            {
                var my = (from e in data.book select e).Where(z => z.Id.Equals(id)).FirstOrDefault();
                data.book.Remove(my);
                data.SaveChanges();
            }
        }

        public BookModel Consultbo(decimal Id)
        {
            BookModel re = new BookModel();
            using (var data = new BooksEntities())
            {
                var my = (from c in data.book select c).Where(z => z.Id.Equals(Id)).FirstOrDefault();
                re.id = my.Id;
                re.Name = my.Name;
                re.author = my.author;
                re.editorial = my.editorial;
                re.edition = my.edition;
                re.publication = my.publication;
                re.id_city = my.id_city;
                re.Country = my.Country;
            }
            return re;
        }

        public void update(BookModel a)
        {
            using (var data = new BooksEntities())
            {
                var my = (from d in data.book where d.Id == a.id select d).FirstOrDefault();
                my.Name = a.Name;
                my.author = a.author;
                my.editorial = a.editorial;
                my.edition = a.edition;
                my.publication = a.publication;
                my.id_city = a.id_city;
                my.Country = a.Country;

                data.SaveChanges();
            }
        }
        public List<BookModel> Consult()
        {
            List<BookModel> result = new List<BookModel>();

            using (var data = new BooksEntities())
            {
                var resultconsult = (from d in data.book select d).ToList();
                foreach (var item in resultconsult)
                {
                    BookModel x = new BookModel();
                    x.id = item.Id;
                    x.Name = item.Name;
                    x.author = item.author;
                    x.editorial = item.editorial;
                    x.edition = item.edition;
                    x.publication = item.publication;
                    x.id_city = item.id_city;
                    x.Country = item.Country;

                    result.Add(x);
                }
            }
            return result;
        }


    }
}