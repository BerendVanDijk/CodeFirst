using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFirst
{
    class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<Course> Courses { get; set; }

    }
}
