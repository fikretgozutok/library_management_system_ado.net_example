using Core.Business;
using Entitites.Concrete;
using DataAccess.Concrete;

namespace Business.Abstract
{
    public abstract class AuthorService : BaseEntityService<Author, AuthorDal>
    {
        public AuthorService(AuthorDal repository) : base(repository) { }
    }
}
