using engin_demirog_dotnet.entities;

// string[] krediler = { "kredi 1", "kredi 2", "kredi 3" };

// for (int i = 0; i < krediler.Length; i++)
// {
//     System.Console.WriteLine(krediler[i]);
// }

Course course1 = new Course();
course1.Id = 1;
course1.Name = "Dotnet C#";
course1.Description = ".Net 8 Kursu";
course1.Price = 0;

Course course2 = new Course();
course2.Id = 2;
course2.Name = "Java 17";
course2.Description = "Spring Boot kursu";
course2.Price = 0;

Course course3 = new Course();
course3.Id = 3;
course3.Name = "Python 3.12";
course3.Description = "Django / FLask / FastAPI Kursu";
course3.Price = 0;

Course[] courses = { course1, course2, course3 };

for (int i = 0; i < courses.Length; i++)
{
    System.Console.WriteLine($"Kurs Id :{courses[i].Id}\nKurs Adı :{courses[i].Name}\nKurs Açıklaması :{courses[i].Description}\nKursun fiyatı :{courses[i].Price}\n***********");
}