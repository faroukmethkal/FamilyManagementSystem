﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Entitiy
{
    [Serializable]

    public class Person
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string HairColor { get; set; }
        public string EyeColor { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public float Weight { get; set; }
        public int Height { get; set; }
        [Required]

        public string Sex { get; set; }
    }
}