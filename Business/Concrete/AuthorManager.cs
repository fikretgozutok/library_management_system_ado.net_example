using Business.Abstract;
using DataAccess.Concrete;

namespace Business.Concrete
{
    public class AuthorManager : AuthorService
    {
        public AuthorManager(AuthorDal repository) : base(repository) { }
    }
}
