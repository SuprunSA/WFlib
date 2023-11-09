using System.ComponentModel.DataAnnotations.Schema;

namespace Students.BL
{
    public class Student
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string FullName { get; set; }
        public string? Description { get; set; }
        public Course Course { get; set; }
        public bool? Stipend { get; set; }
    }
}
