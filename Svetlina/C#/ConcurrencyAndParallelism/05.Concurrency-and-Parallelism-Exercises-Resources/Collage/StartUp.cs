using Collage.Data.Models;
using System.Collections.Generic;

namespace Collage
{
    class StartUp
    {
        static void Main()
        {
            CollageDBContext context = new CollageDBContext();
        }

        static void CoursesInfo(CollageDBContext context)
        {
            // TODO: prints to the console for each course its name, credits, department name and department budget
        }

        static void DepartmentAndCredits(CollageDBContext context)
        {
            // TODO: takes all grades below 3.50 in courses with id 2021, 2030, 2042 
            // prints the grade, course name, and course credits 
        }
        static void DepartmentInfo(List<Course> courses, List<Department> departments)
        {
            // TODO: the method should print the information for each course in the following format: 
            // "Department id: {department id}, Name: {department name}, Course: {course name}, Credits: {course credits}"
            // sort the information by department id in ascending order
        }
        static void DepartmentSumCredits(List<Course> courses)
        {
            // TODO: the method should sum the course credits in each department and print the information for each department in the following format: 
            // Department id: { department id}, Sum Credits: { sum credit}
            // sort the information by department id in ascending order
        }

    }
}
