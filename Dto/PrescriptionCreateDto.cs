using System.ComponentModel.DataAnnotations;

namespace repository_pattern_project.Dto
{
    public class PrescriptionCreateDto
    {


        
        [Required]
        [MaxLength(100)]
        public string? PatientName { get; set; }
        [Required(ErrorMessage = "Amount is required")]


        public decimal Amount { get; set; }
        [Required]
        public int Frequency { get; set; }
    }
}
