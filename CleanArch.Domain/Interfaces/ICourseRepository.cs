using CleanArch.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Domain.Interfaces
{
    public interface ICourseRepository
    {
        Course GetCourse(int Id);
        void Add(Course course);
    }
}
