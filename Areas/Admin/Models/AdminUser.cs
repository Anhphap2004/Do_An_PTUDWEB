﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Pantus.Models;
namespace Pantus.Areas.Admin.Models
{
    [Table("tb_Account")]
    public class AdminUser
    {
        [Key]
        public int AccountId { get; set; }

        public string? FullName { get; set; }
        public string? Phone { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? Email { get; set; }
        public bool IsActive { get; set; }
        public int? RoleId { get; set; }

        public DateTime? LastLogin { get; set; }

    }
}
