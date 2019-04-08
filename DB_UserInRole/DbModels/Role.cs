using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_CF.DbModels
{
    public class Role
    {
        [Key]
        public int RoleId { get; set; }
        [Required]
        [MaxLength(40)]
        public string RoleName { get; set; }
        [MaxLength(128)]
        public string Description { get; set; }
    }
}
