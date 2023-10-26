namespace API.Services;

public class StudentServices : IStudentServices
{
    private readonly IStudentRepository _studentRepository;

    public StudentServices(IStudentRepository studentRepository)
    {
        _studentRepository = studentRepository;
    }

    public async Task Create(Student student)
    {
        try
        {
            await _studentRepository.NewStudent(student);
        }
        catch (Exception e)
        {

            throw new Exception(e.InnerException!.Message);
        }
    }

    public async Task<List<Student>> GetStudents()
    {
        try
        {
           var student = await _studentRepository.GetStudents();
           return student;
        } catch (Exception e)
        {
            throw new Exception(e.InnerException!.Message);
        }
    }

    public async Task<Student> GetStudent(int id)
    {
        try
        {
           var student = await _studentRepository.GetStudent(id);
           return student;
        } catch (Exception e)
        {
            throw new Exception(e.InnerException!.Message);
        }
    }

    public async Task<Student> DeleteStudent(int id)
    {
        try
        {
           var student = await _studentRepository.DeleteStudent(id);
           return student;
        } catch (Exception e)
        {
            throw new Exception(e.InnerException!.Message);
        }
    }

    public async Task<Student> UpdateStudent(int id, Student studentUpdate)
    {
        try
        {
            studentUpdate.Id = id;
            var student = await _studentRepository.UpdateStudent(studentUpdate);
            return student;
        } catch (Exception e)
        {
            throw new Exception(e.InnerException!.Message);
        }
    }
}
