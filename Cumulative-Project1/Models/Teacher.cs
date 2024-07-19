using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cumulative_Project1.Models
{
    public class Teacher
    {
        // Creating a unique identifier for the teacher
        public int TeacherId { get; set; }
        
        // First name of the teacher
        public string TeacherFName { get; set; }

        // Last name of the teacher
        public string TeacherLName { get; set;}

        // Employee number of the teacher
        public string EmployeeNumber { get; set; }

        // Date when the teacher was hired
        public DateTime HireDate { get; set; }

        // Salary of the teacher
        public decimal Salary { get; set; }

    }
}