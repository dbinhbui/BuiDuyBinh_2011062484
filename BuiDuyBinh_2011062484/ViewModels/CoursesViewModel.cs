using BuiDuyBinh_2011062484.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BuiDuyBinh_2011062484.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> UpcomingCourses { get; set; }
        public bool ShowAction { get; set; }
    }
}