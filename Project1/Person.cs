namespace Project1
{
    public class Person
    {
        public int Id { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public DateTime LastSeenTime { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime UpdatedTime { get; set; }
    }

    public enum Gender
    {
        Male,
        FeMale
    }
}
