﻿using System.ComponentModel.DataAnnotations;

namespace TodoApp_MVC.ViewModels.Account
{
    public class RegisterViewModel
    {

        [Display(Name ="Email Address")]
        [Required(ErrorMessage = "Email Address is Required")]
        public string EmailAddress { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Display(Name = "Confirm Password")]
        [Required(ErrorMessage = "Confirm Password is required")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Password do not match")]
        public string ConfirmPassword { get; set; }
    }
}
