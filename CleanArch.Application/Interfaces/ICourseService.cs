using CleanArch.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.Interfaces
{
    public interface ICourseService
    {
        Task<CourseViewModel> GetCourse(int Id);
        void Create(CourseViewModel courseViewModel);
    }
}
