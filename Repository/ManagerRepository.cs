using System.Collections.Generic;
using System.Linq;
using InternAPI.Data;
using InternAPI.Models;
using InternAPI.Repository.IRepository;

namespace InternAPI.Repository
{
    public class ManagerRepository : IManagerRepository
    {
        public Sirket CreateSirket(Sirket sirket)
        {
            using (var SirketDbContext = new ApplicationDbContext())
            {
                SirketDbContext.managers.Add(sirket);
                SirketDbContext.SaveChanges();
                return sirket;
            }

        }

        public void DeleteSirket(int id)
        {
            using (var SirketDbContext = new ApplicationDbContext())
            {
                var deletedSirket = GetSirketById(id);
                SirketDbContext.managers.Remove(deletedSirket);
                SirketDbContext.SaveChanges();
            }

        }

        public List<Sirket> GetAllﬁirkets()
        {
            using (var SirketDbContext= new ApplicationDbContext())
            {
                return SirketDbContext.managers.ToList();
            }
                
        }

        public Sirket GetSirketById(int id)
        {
            using (var SirketDbContext = new ApplicationDbContext())
            {
                return SirketDbContext.managers.Find(id);
            }

        }

        public Sirket UpdateSirket(Sirket sirket)
        {
            using (var SirketDbContext = new ApplicationDbContext())
            {
                SirketDbContext.managers.Update(sirket);
                SirketDbContext.SaveChanges();
                return sirket;
            }

        }
    }
}