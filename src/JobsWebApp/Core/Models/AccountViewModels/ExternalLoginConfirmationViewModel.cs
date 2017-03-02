﻿using System.ComponentModel.DataAnnotations;

namespace JobsWebApp.Core.Models.AccountViewModels
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
