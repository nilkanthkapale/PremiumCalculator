
using System.ComponentModel.DataAnnotations;

namespace PC.Data.Models
{
    public class Person
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Age is required")]
        [Range(1, 70, ErrorMessage = "Age should not less than 1 year and not more than 70 years")]
        public int? Age { get; set; }

        [Required(ErrorMessage = "Date of birth is required")]
        public DateTime? DateOfBirth { get; set; }


        [Required(ErrorMessage = "Occupation is required")]
        public int OccupationId { get; set; }

        [Required(ErrorMessage = "Insured sum is required")]
        public double? SumInsured { get; set; }
    }
}
