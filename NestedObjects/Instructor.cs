using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedObjects
{
    class Instructor
    {
        /// <summary>
        /// Instructor's lefal full name. First and last.
        /// Example: John Doe
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// Company email address.
        /// Example: John.Doe@cptc.edu
        /// </summary>
        public string Email { get; set; }
    }
}