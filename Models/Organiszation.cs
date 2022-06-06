using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Horus.Data.Models
{
    public class Organiszation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Required, MaxLength(200)]
        public string OrganiszationName { get; set; }

        [Required, MaxLength(255)]
        public string Description { get; set; }

        [Required]        
        public string Image { get; set; }
            
        [Required,MaxLength(200)]
        public string FriendlyName { get; set; }

        [Required]
        public int NoOfUsers { get; set; }

        [Required]
        public int LocalId { get; set; }

        public bool IsEnabled { get; set; }

        public bool IsDeleted { get; set; } 

        [Required, MaxLength(200)]
        public string Department { get; set; }
    }
}
