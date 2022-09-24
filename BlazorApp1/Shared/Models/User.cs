using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp1.Shared.Models
{
    public class User
    {
        [Required]
        public int Userid { get; set; }
        [Required]
        public string Username { get; set; } = null!;
        [Required]
        public string Address { get; set; } = null!;
        [Required]
        public string Cellnumber { get; set; } = null!;
        [Required]
        [EmailAddress]
        public string Emailid { get; set; } = null!;
    }
}
