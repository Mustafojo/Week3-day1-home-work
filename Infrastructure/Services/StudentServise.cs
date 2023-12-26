using Domain.Models;

namespace Infrastructure.Services;

public class StudentServices{
    List<Student> students = new List<Student>();
public List<Student> GetStudents()
{
    return students;
}
public void AddStudents(Student student)
{
    students.Add(student);
}
public void UpdateStudent(int id ,string firstname,string lastname,string address)
{
    foreach (var st in students)
    {
        if(st.ID == id)
        {
            st.FirstName = firstname;
            st.LastName = lastname;
            st.Address = address;
            System.Console.WriteLine("Student successfully updated");
        }
        else
        {
            System.Console.WriteLine("Student not found");
        }
    }
}


}
