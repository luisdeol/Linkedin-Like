using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobsWebApp.Models;

namespace JobsWebApp.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Post> Posts { get; set; }
        public bool IsAuthenticated { get; set; }
        public PostFormViewModel PostFormViewModel { get; set; }
    }
}
