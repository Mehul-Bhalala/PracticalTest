using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PracticalTest.Models
{
    public class User
    {
        public long UserId { get; set; }

        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Name is Required")]
        [DataType(DataType.Text)]
        [StringLength(100)]
        public string FullName { get; set; }

        public bool IsActive { get; set; }


        public DateTime CreateDate { get; set; }

        public ICollection<UserService> UserServices { get; set; }
    }
}
