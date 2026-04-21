namespace Hospital.Areas.Doctor.ViewModels
{
    public class DoctorWithSpecializationAndRelatedData
    {
        public Dictionary<Hospital.Models.Doctor, string> DoctorWithSpecialization { get; set; } = [];
        public int TotalPages { get; set; }
        public int CurrentPage { get; set; }
    }
}
