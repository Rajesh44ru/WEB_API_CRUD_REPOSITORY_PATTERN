namespace repository_pattern_project.Models.Data
{
    public interface IPrescriptionRepository
    {
        IEnumerable<Prescription> GetAll();
        Prescription Get(int id); 
        void Create(Prescription prescription);
        void Update(Prescription prescription);
        void Delete(int id);
        bool SaveChanges();
    }
}
