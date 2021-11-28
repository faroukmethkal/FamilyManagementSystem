﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Entitiy

{
    public class Interest
    {
        [Key]
        public string Type { get; set; }
        public string Description { get; set; }

        [JsonIgnore]
        public List<Child> Children { get; set; }
    }
}