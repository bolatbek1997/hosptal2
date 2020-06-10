namespace Hospital.Data.Repository
{
    using DatabaseModels;
    using System.Data.Entity;

    public interface IUnitOfWork
    {
        DbContext Context { get; }

        IRepository<Image> Images { get; }

        IRepository<ClinicalResult> ClinicalResults { get; }

        IRepository<ClinicalTrial> ClinicalTrials { get; }

        IRepository<UserInfo> Doctors { get; }

        IRepository<User> Users { get; }

        IRepository<Speciality> Specialities { get; }
        IRepository<Send> Send { get; }

        void Dispose();

        int SaveChanges();
    }
}
