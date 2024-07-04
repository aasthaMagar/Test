using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace fORM.Models
{

    public class form
    {
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "UserName")]
        public string UserName { get; set; }

        [Display(Name = "Number")]
        public int Number {  get; set; }

        [Display(Name = "Occupation")]
        public string Occupation { get; set; }

        [Display(Name = "Gender")]
        public Gender Gen { get; set; }

        [Display(Name = "Date Of Birth")]
        public  DateOnly DateOfBirth { get; set; }

        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class Gender
    {
        [Display(Name="Male")]
        public bool IsMale { get; set; }

        [Display(Name = "Female")]

        public bool IsFemale { get; set; }

        [Display(Name = "Other")]

        public bool IsOther { get; set; }

        public bool IsValid => IsFemale | IsMale | IsOther;
    }
}