using System.ComponentModel.DataAnnotations;
using Overmind.Domain.Abstract;

namespace Overmind.Domain.Entities
{
    public class Link : Entity
    {
        public Link(string entityId) 
            : base(entityId)
        {
            // Blank
        }

        [Required, StringLength(100, ErrorMessage = "")]
        public string Reference { get; set; }

        public override void Type(string type)
        {
            // Decide type
        }
    }
}
