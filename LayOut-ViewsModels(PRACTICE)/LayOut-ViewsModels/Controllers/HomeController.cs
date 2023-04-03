using LayOut_ViewsModels.Models;
using LayOut_ViewsModels.ViewModels.Home;
using LayOut_ViewsModels.ViewModels.Product;
using Microsoft.AspNetCore.Mvc;

namespace LayOut_ViewsModels.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //ViewData["names"] = new string[] { "Cahandar", "Ismayil", "Elcin" };

            //ViewBag.numbers = new int[] { 1, 2, 3, 4, 6, 5 };
            //ViewBag.names = new string[] { "Cahandar", "Babek", "Ali" }; 

            //ViewBag.name = "Elcan";

            //TempData["surname"] = "Qurbanov";

            //return RedirectToAction(nameof(Detail));



            Student stu1 = new Student
            {
                Id = 1,
                Name = "Cahandar",
                Age = 26

            };

            Student stu2 = new Student
            {
                Id = 2,
                Name = "Azer",
                Age = 26

            };

            Student stu3 = new Student
            {
                Id = 3,
                Name = "Ali",
                Age = 26

            };

            List<Student> students = new List<Student> { stu1, stu2, stu3 };

            Product product = new()
            {
                Id = 1,
                Name = "Samsung 11",
                Count = 50,
                Price= 200,
                Description="abc"

            };

            ProductVM productVM = new ProductVM()
            {
                Name = product.Name,
                Price = product.Price
            };



            HomeVM model = new HomeVM()
            {
                Students = students,
                Product = productVM
            };






            return View(model);

            //ViewBag.address = "Baku";


        }

        //public IActionResult Detail()
        //{
        //    return View(); 
        //}
    }
}
