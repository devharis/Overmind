using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Overmind.Domain.Customer
{
    public class Customer
    {
        public string Id { get; set; }

        [Required, StringLength(50, ErrorMessage = "...")]
        public string Name { get; set; }

        public ICollection<Abstract.File> Entities { get; set; }
        public CustomerType CustomerType { get; set; }
    }
}
