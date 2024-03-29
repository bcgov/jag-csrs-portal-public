﻿using System.ComponentModel.DataAnnotations;

namespace Csrs.Api.Models
{
    public class Feedback
    {
        [Required]
        public string? BCeIDGuid { get; set; }
        [Required]
        public string? Subject { get; set; }
        [Required]
        public string? MessageBody { get; set; }
    }
}
