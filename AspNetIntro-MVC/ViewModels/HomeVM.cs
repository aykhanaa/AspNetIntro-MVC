using AspNetIntro_MVC.Models;

namespace AspNetIntro_MVC.ViewModels
{
    public class HomeVM
    {
        public string Text { get; set; }
        public List<string> Students { get; set; }
        public int AgeOfAykhan { get; set; }
        public List<User> Users { get; set; }
        public List<User> Studentes { get; set; }
        public List<User> Products { get; set; }

    }
}
