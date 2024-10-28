﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY_3_ASSIGNMENT.ASSIGNMENT_2
{
    internal class Customer
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DateOfBirth { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}\t Email: {Email}\t Phone Number: {PhoneNumber}\t DateOfBirth: {DateOfBirth}";
        }
    }
}