using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Domain.Queries
{
  public  class CreateCourseQuery : CourseQuery
    {
        public CreateCourseQuery(int id)
        {
            Id = id;
        }
    }
}
