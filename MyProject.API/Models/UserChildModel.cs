using MyProject.Common.DTOs;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyProject.WebAPI.Models
{
    public class UserChildModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Tz { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int IdParent { get; set; }
    }
}
