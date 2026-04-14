namespace Hospital.Models
{
    public class Doctor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; } = "Dr";
        public int Age { get; set; }
        public string Image { get; set; } = "team-1.jpg";
        public string Bio { get; set; } = "Dr.Muhammad is a qualified and experienced physician at NeoClinic, specializing in Cardiology. They are dedicated to providing high-quality patient care, accurate diagnosis, and effective treatment. Known for their professionalism and compassionate approach, Dr.Muhammad Ragab focuses on improving patient health and well-being.";
        public Specialization Specialization { get; set; }
        public int SpecializationId { get; set; }
        public List<Appointment> Appointments { get; set; } = [];
        public List<AppointmentsDoctor> AppointmentsDoctors { get; set; } = [];
    }
}
