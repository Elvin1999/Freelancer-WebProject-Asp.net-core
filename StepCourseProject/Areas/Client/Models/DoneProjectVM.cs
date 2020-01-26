using StepCourseProject.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StepCourseProject.Areas.Client.Models
{
    public class DoneProjectVM
    {
        public List<Post> DoneProjects { get; set; }
        public List<Post> NotDoneProjects { get; set; }
    }
}
