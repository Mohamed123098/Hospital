using Hospital.Areas.Doctor.ViewModels;
using Hospital.DataAccessLayer.Data;
using Hospital.DTOs.Doctor;
using Microsoft.AspNetCore.Mvc;

namespace Hospital.Areas.Doctor
{
    [Area(Utilities.StaticData.DOCTOR_AREA)]
    public class DoctorController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        public DoctorController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index(int pageSize=5,int page=1)
        {
            Dictionary<Hospital.Models.Doctor, string> DoctorsWithSpecializations = [];
            
            foreach (var item in _dbContext.Doctors.ToList().Skip(pageSize * (page - 1)).Take(pageSize))
            {
                DoctorsWithSpecializations.Add(item,_dbContext.Specializations.FirstOrDefault(s => s.Id == item.SpecializationId)!.Name);
            }
            int totalPages = (int)Math.Ceiling(_dbContext.Doctors.Count() / (decimal)pageSize);
            return View(new DoctorWithSpecializationAndRelatedData { DoctorWithSpecialization= DoctorsWithSpecializations, TotalPages= totalPages, CurrentPage=page });
        }

        //Open the view and pass the models of specializations to it
        public IActionResult Create()
        {
            return View("CreateDoctor", _dbContext.Specializations.ToList());
        }

        //Save the data in DB and Deal with the file
        public IActionResult Save(DoctorDTO doctor, IFormFile formFile)
        {
            if (formFile.Length > 0 && formFile is not null)
            {
                var fileName = $"{Guid.NewGuid()}_{DateTime.UtcNow.ToString("dd_MM_yyyy")}_{Path.GetExtension(formFile.FileName)}";
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot\images",fileName);

                using (var stream = System.IO.File.Create(filePath))
                {
                    formFile.CopyTo(stream);
                }
                doctor.Image = fileName;
            }
            Hospital.Models.Doctor dbDoctor = new() { Name = doctor.Name, Age = doctor.Age, Image = doctor.Image, Bio = doctor.Bio, SpecializationId = doctor.SpecializationId };

            _dbContext.Doctors.Add(dbDoctor);
            _dbContext.SaveChanges();
            return View("Index", _dbContext.Doctors.ToList());
        }
    }
}
