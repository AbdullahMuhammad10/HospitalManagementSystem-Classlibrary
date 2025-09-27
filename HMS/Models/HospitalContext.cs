using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Models
{
    public class HospitalContext : DbContext
    {
        public HospitalContext(DbContextOptions options) : base(options) { }

        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<MedicalRecord> MedicalRecords { get; set; }
        public DbSet<Nurse> Nurses { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Treatment> Treatments { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // -------------------------
            // Departments
            // -------------------------
            modelBuilder.Entity<Department>().HasData(
                new Department { Id = 1, Name = "Cardiology", Location = "Building A - Floor 1" },
                new Department { Id = 2, Name = "Neurology", Location = "Building B - Floor 2" }
            );

            // -------------------------
            // Doctors
            // -------------------------
            modelBuilder.Entity<Doctor>().HasData(
                new Doctor { Id = 1, FullName = "Dr. John Smith", Specialty = "Cardiologist", Phone = "111-111-1111", DepartmentId = 1 },
                new Doctor { Id = 2, FullName = "Dr. Sarah Johnson", Specialty = "Neurologist", Phone = "222-222-2222", DepartmentId = 2 }
            );

            // -------------------------
            // Nurses
            // -------------------------
            modelBuilder.Entity<Nurse>().HasData(
                new Nurse { Id = 1, FullName = "Nurse Anna", Phone = "333-333-3333", DepartmentId = 1 },
                new Nurse { Id = 2, FullName = "Nurse Tom", Phone = "444-444-4444", DepartmentId = 2 }
            );

            // -------------------------
            // Patients
            // -------------------------
            modelBuilder.Entity<Patient>().HasData(
                new Patient { Id = 1, FullName = "Michael Brown", DateOfBirth = new DateTime(1980, 5, 12), Gender = "Male", Phone = "555-555-5555", Address = "123 Main St" },
                new Patient { Id = 2, FullName = "Emily Davis", DateOfBirth = new DateTime(1995, 8, 20), Gender = "Female", Phone = "666-666-6666", Address = "456 Oak Ave" }
            );

            // -------------------------
            // Rooms
            // -------------------------
            modelBuilder.Entity<Room>().HasData(
                new Room { Id = 1, RoomNumber = "101", Type = "ICU", IsAvailable = true, DepartmentId = 1 },
                new Room { Id = 2, RoomNumber = "202", Type = "General", IsAvailable = false, DepartmentId = 2 }
            );

            // -------------------------
            // Appointments
            // -------------------------
            modelBuilder.Entity<Appointment>().HasData(
                new Appointment
                {
                    Id = 1,
                    Date = DateTime.Now.AddDays(1),
                    Status = "Scheduled",
                    PatientId = 1,
                    DoctorId = 1,
                    RoomId = 1
                },
                new Appointment
                {
                    Id = 2,
                    Date = DateTime.Now.AddDays(2),
                    Status = "Scheduled",
                    PatientId = 2,
                    DoctorId = 2,
                    RoomId = 2
                }
            );

            // -------------------------
            // Bills
            // -------------------------
            modelBuilder.Entity<Bill>().HasData(
                new Bill { Id = 1, BillDate = DateTime.Now, Amount = 2000.00m, IsPaid = false, PatientId = 1 },
                new Bill { Id = 2, BillDate = DateTime.Now, Amount = 3500.00m, IsPaid = true, PatientId = 2 }
            );

            // -------------------------
            // Medical Records
            // -------------------------
            modelBuilder.Entity<MedicalRecord>().HasData(
                new MedicalRecord { Id = 1, Diagnosis = "Hypertension", Notes = "Patient advised lifestyle changes.", RecordDate = DateTime.Now.AddDays(-10), PatientId = 1 },
                new MedicalRecord { Id = 2, Diagnosis = "Migraine", Notes = "Prescribed medication.", RecordDate = DateTime.Now.AddDays(-5), PatientId = 2 }
            );

            // -------------------------
            // Treatments
            // -------------------------
            modelBuilder.Entity<Treatment>().HasData(
                new Treatment { Id = 1, TreatmentName = "Heart Surgery", Description = "Bypass surgery", Date = DateTime.Now.AddDays(-2), PatientId = 1, DoctorId = 1, NurseId = 1 },
                new Treatment { Id = 2, TreatmentName = "Brain MRI", Description = "Detailed brain scan", Date = DateTime.Now.AddDays(-1), PatientId = 2, DoctorId = 2, NurseId = 2 }
            );

            // -------------------------
            // Staff
            // -------------------------
            modelBuilder.Entity<Staff>().HasData(
                new Staff { Id = 1, FullName = "Linda Green", Role = "Receptionist", Phone = "777-777-7777" },
                new Staff { Id = 2, FullName = "Mark White", Role = "Lab Technician", Phone = "888-888-8888" }
            );
        }



    }
}
