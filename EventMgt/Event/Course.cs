using System;

namespace Event
{
    public class Course
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CourseDate { get; set; }

        public override bool Equals(object obj)
        {
            Course course = obj as Course;
            if(ID == course.ID && Name == course.Name && Description == course.Description &&
                CourseDate == course.CourseDate)
                return true;

            return false;
        }
    }
}
