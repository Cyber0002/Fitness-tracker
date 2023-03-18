namespace Fitness_tracker.Entities
{
    public class Sets
    {
        public int Id { get; set; }
        public int Set_number { get; set; }
        public int Reps { get; set; }
        public Exercises Exercise { get; set; }
        public int ExerciseId { get; set; }
}
    }
