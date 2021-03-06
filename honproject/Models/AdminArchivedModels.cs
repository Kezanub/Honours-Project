﻿using System.ComponentModel.DataAnnotations;

namespace honproject.Models
{
    public class AdminArchivedModels
    {
        public string Id { get; set; }

        public string FullName { get; set; }


        [Required]
        [Display(Name = "Archived")]
        public bool Archived { get; set; }
    }
}