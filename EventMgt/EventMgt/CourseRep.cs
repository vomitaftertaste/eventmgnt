using System;

namespace EventMgt
{
    public class CourseRep
    {
        public Course GetCourseDetail(int id)
        {
            Course course = new Course();
            course.ID = 1;
            course.Name = "Professional Scrum Developer";
            course.Description = "Scrum Programming";
            course.CourseDate = new DateTime(2017, 10, 25);
            return course;
        }
    }
}
