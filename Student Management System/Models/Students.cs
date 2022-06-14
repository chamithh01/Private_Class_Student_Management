using System;
using System.ComponentModel.DataAnnotations;

namespace Student_Management_System.Models
{
    public class Students
    {
        [Key]
        public  int  Id { get; set; }

        [Required]
        public string FullName { get; set; }

        [Required]
        public  string  ParentsName { get; set; }

        [Required]
        public DateTime Birthday { get; set; }


        [Required]
        public  string  Address { get; set; }


        [Required]
        public int Contact { get; set; }


        [Required]
        public string Gender { get; set; }


        [Required]
        public int Grade { get; set; }

        [Required]
        public string  Status { get; set; }
    }
}
