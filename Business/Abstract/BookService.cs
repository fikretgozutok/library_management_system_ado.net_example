using Core.Business;
using Entitites.Concrete;
using DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public abstract class BookService : BaseEntityService<Book, BookDal>
    {
        public BookService(BookDal repository) : base(repository) { }
    }
}
