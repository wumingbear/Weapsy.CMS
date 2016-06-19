﻿using System.ComponentModel.DataAnnotations;

namespace Weapsy.Models.AccountViewModels
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
