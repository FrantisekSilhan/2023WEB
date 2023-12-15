namespace SessionServiceToDo.Models
{
    public class ToDo
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime EndDate { get; set; }
        public bool Success { get; set; }

    }
}
