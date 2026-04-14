namespace Hospital.Models
{
    public class AppointmentsDoctor
    {
        public int AppointmentId { get; set; }
        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }
        public Appointment Appointment { get; set; }
    }
}
