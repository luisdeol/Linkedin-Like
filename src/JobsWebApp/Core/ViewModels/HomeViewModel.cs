using System.Collections.Generic;
using JobsWebApp.Core.Models;

namespace JobsWebApp.Core.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Post> Posts { get; set; }
        public bool IsAuthenticated { get; set; }
        public PostFormViewModel PostFormViewModel { get; set; }
    }
}
