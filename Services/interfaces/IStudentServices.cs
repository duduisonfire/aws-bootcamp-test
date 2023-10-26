using API.Repository;

namespace API;

public interface IStudentServices
{
    Task Create(Student student);
    Task<List<Student>> GetStudents();
    Task<Student> GetStudent(int id);
    Task<Student> DeleteStudent(int id);
    Task<Student> UpdateStudent(int id, Student studentUpdate);
}
