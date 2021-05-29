using CleanArch.Domain.Interfaces;
using CleanArch.Domain.Models;
using CleanArch.Domain.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArch.Domain.QueriesHandlers
{
    public class CourseQueryHandler : IRequestHandler<CreateCourseQuery, Course>
    {
        private readonly ICourseRepository _courseRepository;

        public CourseQueryHandler(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        public Task<Course> Handle(CreateCourseQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_courseRepository.GetCourse(request.Id));
        }
    }
}
