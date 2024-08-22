namespace StudentApi.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Uuid { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; }
        public string Email { get; set; }
        public string Matricula { get; set; }
    }
}
