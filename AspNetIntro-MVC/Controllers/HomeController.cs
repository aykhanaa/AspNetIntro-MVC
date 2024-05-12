using AspNetIntro_MVC.Models;
using AspNetIntro_MVC.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AspNetIntro_MVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            string text = "Welcome";

            int ageOfAykhan = 24;

            List<string> students = new List<string> { "Emiraslan", "Fexriyye", "Elmir", "Ilqar", "Nurlan" };

            HomeVM model = new()
            {
                Text = text,
                Students = students,
                AgeOfAykhan = ageOfAykhan,
                Users = GetAllUsers(),
                Studentes = GetAllDatas(),
                Products = GetProduct()
            };

            return View(model);
        }
        private List<User> GetAllUsers()
        {
            return new List<User>
            {
                new User
                {
                    Id = 1,
                    Age = 100,
                },
                new User
                {
                    Id=2,
                    Age=50,
                }
            };
        }
        private List<Student> GetAllDatas()
        {
            return new List<Student>
            {
                new Student
                {
                    Name ="Ayxan",
                    Surname = "Aghayev",
                    Email = "aykhan@gmail.com",
                    Age = 24,
                    PhoneNumber =45678912
                },
                new Student
                {
                    Name ="Nazim",
                    Surname = "Hesenov",
                    Email = "nazim@gmail.com",
                    Age = 22,
                    PhoneNumber =45678912
                },
                new Student
                {
                    Name ="Ilkin",
                    Surname = "Quliyev",
                    Email = "ilkin@gmail.com",
                    Age = 28,
                    PhoneNumber =45678912
                }
            };

        }
        private List<Product> GetProduct()
        {
            return new List<Product>
            {
                new Product
                {
                    Name ="Kia",
                    Price = 25000,
                    Color = "black"
                },
                 new Product
                {
                    Name ="Mazda",
                    Price = 27000,
                    Color = "grey"
                },
                  new Product
                {
                    Name ="BMW",
                    Price = 35000,
                    Color = "white"
                }

            };
        }
}   }  