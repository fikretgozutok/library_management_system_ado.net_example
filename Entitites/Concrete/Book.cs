using Core.Entities;

namespace Entitites.Concrete
{
    public class Book : BaseEntity
    {
        public int AuthorID { get; set; }
        public string Title { get; set; } = string.Empty;
        public DateTime PublishedDate { get; set; }
    }
}
