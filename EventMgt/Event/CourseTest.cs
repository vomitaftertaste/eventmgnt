using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Event
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

            Assert.AreEqual(course, rep.GetCourseDetail(1));
        }

        [Test]
        public void GetWrongCourseDetail()
        {
            CourseRep rep = new CourseRep();
            Assert.AreEqual(null, rep.GetCourseDetail(0));
        }
    }
}
