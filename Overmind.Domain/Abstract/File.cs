using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Overmind.Domain.Abstract
{
    public abstract class File
    {
        protected File(string fileId)
        {
            FileId = fileId;
        }

        [Key]
        public string FileId { get; set; }

        [ForeignKey("Customer")]
        public string CustomerId { get; set; }

        [Required, StringLength(25, ErrorMessage = "")]
        public string Title { get; set; }
        
        public Customer.Customer Customer { get; set; }

        public abstract void Type(string type);

    }

}
