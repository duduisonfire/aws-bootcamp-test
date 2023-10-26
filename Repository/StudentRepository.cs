using API.Context;
using Microsoft.EntityFrameworkCore;

namespace API.Repository;

public class StudentRepository : IStudentRepository
{
    private readonly AppDbContext _dbContext;

    public StudentRepository(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<List<Student>> GetStudents()
    {
        try
        {
            var students = await _dbContext.Students!
            .OrderBy(students => students.Id)
            .ToListAsync();

            return students;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw new Exception(e.Message);
        }
    }

    public async Task<Student> GetStudent(int id)
    {
        try
        {
            var student = await _dbContext.Students!.FirstOrDefaultAsync(student => student.Id == id);

            return student!;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw new Exception(e.Message);
        }
    }

    public async Task NewStudent(Student student)
    {
        try
        {
            await _dbContext.Students!.AddAsync(student);
            await _dbContext.SaveChangesAsync();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.InnerException!.Message);
            throw new Exception(e.InnerException!.Message);
        }
    }

    public async Task<Student> DeleteStudent(int id)
    {
        try
        {
            var student = await _dbContext.Students!.FirstOrDefaultAsync(student => student.Id == id);
            _dbContext.Students!.Remove(student!);
            await _dbContext.SaveChangesAsync();

            return student!;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.InnerException!.Message);
            throw new Exception(e.InnerException!.Message);
        }
    }

    public async Task<Student> UpdateStudent(Student studentUpdate)
    {
        try
        {
            _dbContext.Students!.Update(studentUpdate);
            await _dbContext.SaveChangesAsync();

            return studentUpdate;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.InnerException!.Message);
            throw new Exception(e.InnerException!.Message);
        }
    }
}
