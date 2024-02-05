using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MVCneelam.Models
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string AuthorName { get; set; }
        public string AuthorPublisher { get; set; }
        
    }
}
