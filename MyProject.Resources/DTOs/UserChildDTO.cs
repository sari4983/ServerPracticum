﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Common.DTOs
{
    
    public class UserChildDTO
    {
        [Key, Required]
        public int ChildId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Tz { get; set; }
       
        [ForeignKey("Parent")]
        public int IdParent { get; set; }
        public UserDTO Parent { get; set; }
    }
}
