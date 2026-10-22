
using Microsoft.EntityFrameworkCore;
using HospitalManagement.Models;

namespace HospitalManagement.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // 1. Hospital organization
        public DbSet<Department> Departments { get; set; } = null!;
        public DbSet<SubDepartment> SubDepartments { get; set; } = null!;
        public DbSet<Specialization> Specializations { get; set; } = null!;

        // 2. Patients and doctors
        public DbSet<Patient> Patients { get; set; } = null!;
        public DbSet<Doctor> Doctors { get; set; } = null!;
        public DbSet<DoctorSchedule> DoctorSchedules { get; set; } = null!;

        // 3. Outpatient workflow
        public DbSet<Appointment> Appointments { get; set; } = null!;
        public DbSet<Encounter> Encounters { get; set; } = null!;
        public DbSet<Diagnosis> Diagnoses { get; set; } = null!;
        public DbSet<Prescription> Prescriptions { get; set; } = null!;
        public DbSet<PrescriptionItem> PrescriptionItems { get; set; } = null!;
        public DbSet<FollowUp> FollowUps { get; set; } = null!;

        // 4. Inpatient workflow
        public DbSet<Ward> Wards { get; set; } = null!;
        public DbSet<Bed> Beds { get; set; } = null!;
        public DbSet<Admission> Admissions { get; set; } = null!;
        public DbSet<AdmissionDoctor> AdmissionDoctors { get; set; } = null!;

        // 5. Nursing
        public DbSet<Nurse> Nurses { get; set; } = null!;

        // 6. Pharmacy catalog and inventory
        public DbSet<MedicineCategory> MedicineCategories { get; set; } = null!;
        public DbSet<Manufacturer> Manufacturers { get; set; } = null!;
        public DbSet<Medicine> Medicines { get; set; } = null!;
        public DbSet<MedicineBatch> MedicineBatches { get; set; } = null!;
        public DbSet<StockTransaction> StockTransactions { get; set; } = null!;

        // 7. Medication management
        public DbSet<MedicationOrder> MedicationOrders { get; set; } = null!;
        public DbSet<MedicationSchedule> MedicationSchedules { get; set; } = null!;
        public DbSet<MedicationAdministration> MedicationAdministrations
            { get; set; } = null!;

        // 8. Purchasing
        public DbSet<Supplier> Suppliers { get; set; } = null!;
        public DbSet<Purchase> Purchases { get; set; } = null!;
        public DbSet<PurchaseItem> PurchaseItems { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Department -> SubDepartments
            modelBuilder.Entity<SubDepartment>()
                .HasOne(sd => sd.Department)
                .WithMany(d => d.SubDepartments)
                .HasForeignKey(sd => sd.DepartmentId)
                .OnDelete(DeleteBehavior.Restrict);

            // Unique patient medical record number
            modelBuilder.Entity<Patient>()
                .HasIndex(p => p.MedicalRecordNumber)
                .IsUnique();

            // Unique bed number within each ward
            modelBuilder.Entity<Bed>()
                .HasIndex(b => new { b.WardId, b.BedNumber })
                .IsUnique();

            // AdmissionDoctor composite primary key
            modelBuilder.Entity<AdmissionDoctor>()
                .HasKey(ad => new { ad.AdmissionId, ad.DoctorId });

            // Unique purchase number
            modelBuilder.Entity<Purchase>()
                .HasIndex(p => p.PurchaseNumber)
                .IsUnique();

            // Encounter -> Patient
            modelBuilder.Entity<Encounter>()
                .HasOne(e => e.Patient)
                .WithMany(p => p.Encounters)
                .HasForeignKey(e => e.PatientId)
                .OnDelete(DeleteBehavior.Restrict);

            // Encounter -> Doctor
            modelBuilder.Entity<Encounter>()
                .HasOne(e => e.Doctor)
                .WithMany(d => d.Encounters)
                .HasForeignKey(e => e.DoctorId)
                .OnDelete(DeleteBehavior.Restrict);

            // Diagnosis -> Encounter
            modelBuilder.Entity<Diagnosis>()
                .HasOne(d => d.Encounter)
                .WithMany(e => e.Diagnoses)
                .HasForeignKey(d => d.EncounterId)
                .OnDelete(DeleteBehavior.Restrict);

            // MedicationOrder -> Admission
            modelBuilder.Entity<MedicationOrder>()
                .HasOne(mo => mo.Admission)
                .WithMany(a => a.MedicationOrders)
                .HasForeignKey(mo => mo.AdmissionId)
                .OnDelete(DeleteBehavior.Restrict);

            // MedicineBatch decimal precision
            modelBuilder.Entity<MedicineBatch>()
                .Property(b => b.QuantityReceived)
                .HasPrecision(18, 2);

            modelBuilder.Entity<MedicineBatch>()
                .Property(b => b.QuantityRemaining)
                .HasPrecision(18, 2);

            modelBuilder.Entity<MedicineBatch>()
                .Property(b => b.PurchasePrice)
                .HasPrecision(18, 2);

            // PurchaseItem decimal precision
            modelBuilder.Entity<PurchaseItem>()
                .Property(i => i.QuantityOrdered)
                .HasPrecision(18, 2);

            modelBuilder.Entity<PurchaseItem>()
                .Property(i => i.QuantityReceived)
                .HasPrecision(18, 2);

            modelBuilder.Entity<PurchaseItem>()
                .Property(i => i.UnitPurchasePrice)
                .HasPrecision(18, 2);

            modelBuilder.Entity<PurchaseItem>()
                .Property(i => i.DiscountAmount)
                .HasPrecision(18, 2);

            // StockTransaction decimal precision
            modelBuilder.Entity<StockTransaction>()
                .Property(t => t.QuantityChange)
                .HasPrecision(18, 2);

            modelBuilder.Entity<StockTransaction>()
                .Property(t => t.UnitCost)
                .HasPrecision(18, 2);
        }
    }
}
