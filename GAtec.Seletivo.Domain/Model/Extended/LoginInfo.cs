﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace GAtec.Seletivo.Domain.Model.Extended
{
    public class LoginInfo
    {
        [Display(Name = "User Name")]
        [Required(ErrorMessage = "The user name is required.")]
        [StringLength(20, ErrorMessage = "The length should be lower than 20.")]
        public string Username { get; set; }

        [Display(Name = "Password")]
        [StringLength(20, ErrorMessage = "The length should be lower than 20.")]
        public string Password { get; set; }

    }
}