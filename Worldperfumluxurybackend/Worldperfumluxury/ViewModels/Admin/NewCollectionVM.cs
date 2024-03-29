﻿using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace Worldperfumluxury.ViewModels.Admin
{
    public class NewCollectionVM
    {
        public int Id { get; set; }
        [Required]
        public IFormFile Photo { get; set; }
    }
}
