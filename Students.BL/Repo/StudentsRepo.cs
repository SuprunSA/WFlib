using Microsoft.EntityFrameworkCore;

namespace Students.BL.Repo
{
    public class StudentsRepo
    {
        private StudentDBContext context;
        public StudentsRepo(StudentDBContext context) 
        {
            this.context = context;
        }

        public async Task SaveAsync()
        {
            await context.SaveChangesAsync();
        }

        public IQueryable<Student> GetStudents()
        {
            return context.Students;
        }

        public async Task<Student> GetStudent(int id)
        {
            return await context.Students.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task Create(Student student)
        {
            await context.Students.AddAsync(student);
        }

        public async Task CreateRange(IEnumerable<Student> students)
        {
            await context.Students.AddRangeAsync(students);
        }

        public void Update(Student student) 
        {
            var st = context.Students.Find(student.Id);
            st.Description = student.Description;
            st.Course = student.Course;
            st.Stipend = student.Stipend;
            st.FullName = student.FullName;
            context.Students.Update(st);
        }

        public void UpdateRange(List<Student> students) 
        {
            foreach (var student in students)
            {
                Update(student);
            }
        }

        public void Delete(Student student) 
        {
            context.Remove(student);
        }

        public async Task<bool> StudentExists(int id)
        {
            return await context.Students.AnyAsync(x => x.Id == id);
        }
    }
}
