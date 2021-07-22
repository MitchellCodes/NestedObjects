﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedObjects
{
    /// <summary>
    /// Represents an individual student
    /// </summary>
    class Student
    {
        /// <summary>
        /// Student's legal first name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Student's legal last name
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// List of courses student is enrolled in
        /// </summary>
        public List<Course> Schedule { get; set; }
    }
}