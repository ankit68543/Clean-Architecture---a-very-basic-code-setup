using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using CleanArch.Domain.Commands;
using CleanArch.Domain.Core.Bus;
using CleanArch.Domain.Interfaces;
using CleanArch.Domain.Models;
using CleanArch.Domain.Queries;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.Services
{
    public class CourseService : ICourseService
    {
        
        private readonly IMediatorHandler _bus;

        public CourseService(IMediatorHandler bus)
        {   
            _bus = bus;
        }

        public void Create(CourseViewModel courseViewModel)
        {
            var createCourseCommand = new CreateCourseCommand(
                  courseViewModel.Name,
                  courseViewModel.Description,
                  courseViewModel.ImageUrl
                );

            _bus.SendCommand<CreateCourseCommand, bool>(createCourseCommand);

        }

        public async Task<CourseViewModel> GetCourse(int Id)
        {
            var query = new CreateCourseQuery(
               Id
              );

             var response= await _bus.SendCommand<CreateCourseQuery, Course>(query);

            return new CourseViewModel
            {
                Name= response.Name,
                Description= response.Description,
                ImageUrl=response.ImageUrl
            };
        }
    }
}
