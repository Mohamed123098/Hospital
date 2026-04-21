namespace Hospital.Models
{
    public class Specialization
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public List<Doctor> Doctors { get; set; } = [];
        public List<Appointment> Appointments { get; set; } = [];

    }
}
