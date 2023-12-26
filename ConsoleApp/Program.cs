using Domain.Models;
using Infrastructure.Services;
var studentservice = new StudentServices();

var stu = new Student();
stu.ID = 1;
stu.FirstName = "Mustafo";
stu.LastName = "Barotov";
stu.Address = "Kucha";

var updatedstudent = new Student()
{
    ID = 5,
    FirstName = "mmm",
    LastName = "BBb",
    Address = "gaa",
};
System.Console.WriteLine($"{stu.ID}");
System.Console.WriteLine($"{stu.FirstName}");
System.Console.WriteLine($"{stu.LastName}");
System.Console.WriteLine($"{stu.Address}");

System.Console.WriteLine(StudentServices.UpdateStudent(updatedstudent));

System.Console.WriteLine(studentservice.UpdateStudent);


