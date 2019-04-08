using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_CF.DbModels
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [MaxLength(60)]
        public string Email { get; set; }
        [Required]
        [MaxLength(20)]
        public string UserName { get; set; }
        [Required]
        public DateTime DateBirthday { get; set; }
        public int? JobTitleId { get; set; }
    }
}
