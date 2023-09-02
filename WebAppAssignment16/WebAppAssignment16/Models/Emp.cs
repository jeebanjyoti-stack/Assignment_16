using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppAssignment16.Models
{
    [Table("Emp")]
    public class Emp
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        [StringLength(250)]
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
    }
}
