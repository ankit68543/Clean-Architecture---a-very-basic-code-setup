using CleanArch.Domain.Core.Commands;
using CleanArch.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Domain.Queries
{
    public abstract class CourseQuery : Command<Course>
    {
        public int Id { get; protected set; }
    }
}
