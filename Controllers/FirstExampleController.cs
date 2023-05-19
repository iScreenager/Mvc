using Microsoft.AspNetCore.Mvc;
using RecapMvc.Models;

namespace RecapMvc.Controllers
{
    public class FirstExampleController : Controller
    {
        public string TestMe()
        {
            return "Hello from MVC";
        }

        public Student DisplayStudent() 
        {
            return new Student
            {
                StudentId = 123, Address ="Chandigarh", Name ="Aakash"                
            };
        }

        public ViewResult DisplayView()
        {
            var student = new Student
            {
                StudentId = 123,
                Address = "Chandigarh",
                Name = "Aakash"
            };
            return View(student);
        }

        public ViewResult AllStudents()
        {
            var data = new List<Student>
            {
                new Student{ StudentId = 111, Name = "Vaishnavi", Address ="Varanasi" },
                new Student{ StudentId = 112, Name = "Aaakash", Address ="Chandigarh" },
                new Student{ StudentId = 113, Name = "Anishika", Address ="Mathura" },
                new Student{ StudentId = 114, Name="Shivani", Address ="Ludhiana"}
            };
            return View(data);
        }
    }
}
