using Form_Handling.Models;
using FormHandling.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FormHandling.ViewModel
{
    public class AccountViewModel
    {
        public Account Account { get; set; }
        public List<Language> Languages { get; set; }
        public SelectList Roles { get; set; }
    }
}