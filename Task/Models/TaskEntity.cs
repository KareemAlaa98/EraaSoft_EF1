﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.Models
{
    internal class TaskEntity
    {
        public int ID { get; set; }

        [Required]
        public string Title { get; set; }

        public string? Description { get; set; }

        public DateTime Date { get; set; }
    }
}
