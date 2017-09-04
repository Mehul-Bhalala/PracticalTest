using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
namespace PracticalTest.Models
{
    public class Service
    {
        public long ServiceId { get; set; }

        [Display(Name = "Service Name")]
        [Required(ErrorMessage = "Service Name is Required")]
        [DataType(DataType.Text)]
        [StringLength(100)]
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }

        public ICollection<UserService> UserServices { get; set; }
    }
}
