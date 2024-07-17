using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
namespace BE
{
    public class course
    {
        public int id { get; set; }
        public string title { get; set; }
        public string totaltime { get; set; }
        public string descript { get; set; }
        public string picture { get; set; }
        public string videointro { get; set; }
        public string price { get; set; }
        public List<course_datailfile> files = new List<course_datailfile>();
        public List<teacher_course> teacher_Courses { get; set; }
        public List<Order_course> Order_Courses { get; set; }


    }
    public class course_datailfile
    {
        public int id { get; set; }
        public string adress { get; set; }
        public string descipt { get; set; }
    }
    public class teacher_course
    {
        public int id { get; set; }
        public int teacherID { get; set; }
        
        public int courseID { get; set; }
       [ForeignKey("teacherID")]
        public teacher teacher { get; set; }
        [ForeignKey("courseID")]
        public course course { get; set; }

    }
    public class teacher
    {
        public int id { get; set; }
        public string name { get; set; }
        public string family { get; set; }
        public string email { get; set; }
        public string picture{ get; set; }
        public List<teacher_course> teacher_Courses { get; set; }
    }

    public class UserApp: IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    public class Order
    {
        public int Id { get; set; }
        public string userId { get; set; }
        public UserApp User { get; set; }
        public float TotalPrice { get; set;}
        public List<Order_course> Order_Courses { get; set; }
    }
    public class Order_course
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public course Course { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }

    }
}
