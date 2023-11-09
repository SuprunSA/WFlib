using Microsoft.EntityFrameworkCore;
using Students.BL.Repo;

namespace Students.BL.Services
{
    public class StudentService
    {
        private readonly StudentsRepo studentsRepository;

        public StudentService(StudentsRepo studentsRepository)
        {
            this.studentsRepository = studentsRepository;
        }

        public async Task<List<Student>> GetStudents() 
        {
            return await studentsRepository.GetStudents().ToListAsync();
        }

        public async Task CreateStudent(Student student)
        {
            await studentsRepository.Create(student);
            await studentsRepository.SaveAsync();
        }

        public async Task CreateRange(List<Student> students)
        {
            await studentsRepository.CreateRange(students);
            await studentsRepository.SaveAsync();
        }

        public async Task DeleteStudent(int id)
        {
            var st = await studentsRepository.GetStudent(id);
            studentsRepository.Delete(st);
            await studentsRepository.SaveAsync();
        }

        public async Task DeleteStudents(IEnumerable<int> ids)
        {
            foreach (var id in ids)
            {
                await DeleteStudent(id);
            }
            await studentsRepository.SaveAsync();
        }

        public async Task UpdateAsync(Student student)
        {
            studentsRepository.Update(student);
            await studentsRepository.SaveAsync();
        }

        public async Task UpdateRangeAsync(List<Student> students)
        {
            studentsRepository.UpdateRange(students);
            await studentsRepository.SaveAsync();
        }
    }
}
