namespace repository_pattern_project.Models.Data
{
    public class InMemoryRepository : IPrescriptionRepository
    {
        private static List<Prescription> prescriptions = new List<Prescription>()
        {
            new Prescription(){Id =1,PatientName="Suraj singh",Amount=400,Frequency=100},
            new Prescription(){Id =2,PatientName="Ritik singh",Amount =500,Frequency=150},
            new Prescription(){Id =3,PatientName="srijana singh",Amount=600,Frequency=200}

        };


        public void Create(Prescription prescription)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Prescription Get(int id)
        {
         return prescriptions[id];
        }

        public IEnumerable<Prescription> GetAll()
        {
           return prescriptions;
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void Update(Prescription prescription)
        {
            throw new NotImplementedException();
        }
    }
}
