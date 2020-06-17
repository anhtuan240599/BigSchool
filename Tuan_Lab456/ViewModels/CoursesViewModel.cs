using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tuan_Lab456.Models;

namespace Tuan_Lab456.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> UpcommingCourses { get; set; }
        public bool ShowAction { get; set; }
       
    }
}