﻿using Csrs.Services.FileManager;
using System.ComponentModel.DataAnnotations;

namespace Csrs.Api.Models
{
    public class Message
    {
        public string MessageId { get; set; }
        [Required]
        public string FileId { get; set; }
        public string FileNumber { get; set; }

        [Required]
        public string? Subject { get; set; }
        public string? Content { get; set; }

        public string? RecievingParty { get; set; }
        public DateTimeOffset? Date { get; set; }
        public bool? Attachment { get; set; }
        public IList<FileSystemItem>? Documents { get; set; }
        public int? Status { get; set; }

        public bool? IsRead { get; set; }
    }
}
