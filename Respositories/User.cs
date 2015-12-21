//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Respositories
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;    
    public partial class User
    {
        public int Id { get; set; }

        [Display(Name = "Anv�ndarnamn")]
        [Required(ErrorMessage = "Ange ett anv�ndarnamn")]
        public string Username { get; set; }

        [Display(Name = "L�senord")]
        [Required(ErrorMessage = "Skriv in ett nytt l�senord")]
        [MinLength(6, ErrorMessage = "Minst 6 tecken")]
        public string Password { get; set; }

        [Display(Name = "�lder")]
        [Required(ErrorMessage = "Skriv in en �lder")]
        [MinLength(2, ErrorMessage = "Max 2 tecken")]
        public int Age { get; set; }

        [Display(Name = "Om dej sj�lv")]
        [Required(ErrorMessage = "Skriv n�got om dej sj�lv")]
        [MinLength(500, ErrorMessage = "Max 500 tecken")]
        public string About { get; set; }

        [Display(Name = "Stad")]
        [Required(ErrorMessage = "Skriv in en stad")]
        public string City { get; set; }
    }
}
