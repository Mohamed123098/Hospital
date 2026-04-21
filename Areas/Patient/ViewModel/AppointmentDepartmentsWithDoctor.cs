namespace Hospital.Areas.Patient.ViewModel
{
    public class AppointmentDepartmentsWithDoctor
    {
        public List<Hospital.Models.Doctor> Doctors { get; set; } = [];
        public List<Specialization> Departments { get; set; } = [];

    }
}
