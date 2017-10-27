using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace EventMgt
{
    [TestFixture]
    class CourseTest
    {
        [Test]
        public void GetCourseDetail()
        {
            Course course = new Course();
            course.ID = 1;
            course.Name = "Professional Scrum Developer";
            course.Description = "Scrum Programming";
            course.CourseDate = new DateTime(2017, 10, 25);

            CourseRep rep = new CourseRep();

            Assert.Equals(course, rep.GetCourseDetail(1));
        }
    }
}
