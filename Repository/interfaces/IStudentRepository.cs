namespace API;

public interface IStudentRepository
{
    Task NewStudent(Student student);
    Task<List<Student>> GetStudents();
    Task<Student> GetStudent(int id);
    Task<Student> DeleteStudent(int id);
    Task<Student> UpdateStudent(Student studentUpdate);
}
