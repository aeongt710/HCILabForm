using System.ComponentModel.DataAnnotations;

namespace HCILabForm.Models
{
    public class UniForm
    {
        public int Id { get; set; } = 0;
        [Required]
        //[RegularExpression("([a-zA-Z]*)", ErrorMessage = "Invalid Format")]
        public string Name { get; set; }
        [Required]
        //[RegularExpression("([a-zA-Z]*)", ErrorMessage = "Invalid Format")]
        public string FatherName { get; set; }
        [Required]
        public string? City { get; set; }
        [Required]
        public string Gender { get; set; }
        public bool isForeign { get; set; } = false;
        [Required]
        public string Campus { get; set; }
        [Required]
        public string Program { get; set; }
        public string? PreviousField { get; set; }
        [Required]
        public string PreviousGrade { get; set; }
        [Required]
        //[RegularExpression("([0-9]{13})",ErrorMessage ="Invalid Format")]
        public string CNIC { get; set; }
        [Required]
        public string? Domicile { get; set; }
        [Required]
        public string? Country { get; set; }
    }
}
