using System.ComponentModel.DataAnnotations;

namespace SuperCom.Domain
{
    public class Ticket
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string City { get; set; }
        public string Location { get; set; }
    }
}