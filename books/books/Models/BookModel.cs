using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using books.Models.DataAcces;

namespace books.Models
{
    public class BookModel
    {
        public decimal id { set; get; }
        public string Name { set; get; }
        public string author { set; get; }
        public string editorial { set; get; }
        public string edition { set; get; }
        public string publication  { set; get; }
        public decimal id_city { set; get; }
        public string Country { set; get; }

        public List<BookModel> lista { get; set; }

        public void create()
        {
            BookDao xyz = new BookDao();
            xyz.Create(this);
        }

        public void delete (decimal usu)
        {
            BookDao e = new BookDao();
            e.Delete(usu);

        }

        public BookModel consultbo(decimal id)
        {
            BookDao con = new BookDao();
            return con.Consultbo(id);
        }

        public void update()
        {
            BookDao a = new BookDao();
            a.update(this);

        }

        public List<BookModel> consult()
        {
            BookDao dao = new BookDao();
            return dao.Consult();
        }
    }

}