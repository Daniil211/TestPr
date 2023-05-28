﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB5_1._Database
{
    public class Musician
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string Phone { get; set; }
        public int Age { get; set; }
        public string Qualification { get; set; }
        public Studio? Studio { get; set; }
        public string Password { get; set; }
        public byte[]? Photo { get; set; }
        public List<Project>? Projects { get; set; }
    }
}
