using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;
using MyProject.Common.DTOs;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MyProject.WebAPI.Models
{
    public enum eGenderUser { נקבה, זכר };
    public class UserModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Tz { get; set; }
        public DateTime DateOfBirth { get; set; }
        public eGenderUser Gender { get; set;}
        public string HMO { get; set; }
    }
}
