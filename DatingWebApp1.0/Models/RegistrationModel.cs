﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DatingWebApp1._0.Models
{
        public class RegistrationModel
    {
    
        public int Id { get; set; }

        [Display(Name = "Användarnamn")]
        [Required(ErrorMessage = "Ange ett användarnamn")]
        public string Username { get; set; }

        [Display(Name = "Lösenord")]
        [Required(ErrorMessage = "Skriv in ett nytt lösenord")]
        [MinLength(6, ErrorMessage = "Minst 6 tecken")]
        public string Password { get; set; }

        [Display(Name = "Ålder")]
        [Required(ErrorMessage = "Skriv in en ålder")]
        [MinLength(2, ErrorMessage = "Max 2 tecken")]
        public int Age { get; set; }

        [Display(Name = "Om dej själv")]
        [Required(ErrorMessage = "Skriv något om dej själv")]
        [MinLength(500, ErrorMessage = "Max 500 tecken")]
        public string About { get; set; }

        [Display(Name = "Stad")]
        [Required(ErrorMessage = "Skriv in en stad")]
        public string City { get; set; }
    }
}
