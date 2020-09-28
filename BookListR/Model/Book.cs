﻿using Microsoft.AspNetCore.Mvc.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookListR.Model
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Name { get; set; }
        public int Author { get; set; }
    }
}
