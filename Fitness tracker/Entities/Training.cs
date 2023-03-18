namespace Fitness_tracker.Entities
{
    public class Training
    {
        public int Id { get; set; }
        public DateTime Start_datetime { get; set; }
        public TimeOnly Duration { get; set;}
        public string Type { get; set;}
        public Users User { get; set; }
        public int UserId { get; set; }
    }
}
