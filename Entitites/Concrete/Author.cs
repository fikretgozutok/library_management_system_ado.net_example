using Core.Entities;

namespace Entitites.Concrete
{
    public class Author : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string Surname { get; set; } = string.Empty;
    }
}
