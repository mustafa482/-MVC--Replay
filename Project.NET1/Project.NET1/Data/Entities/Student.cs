namespace Project.NET1.Data.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public float? Salary { get; set; }
        public int? Gender { get; set; }
    }
}
