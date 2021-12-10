﻿
using System;
using System.Collections.Generic;

namespace CSharpFeatures.Version9.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public DateTime DOB { get; set; }

        public List<string> Reportees { get; set; } = new List<string>();

      
    }
}
