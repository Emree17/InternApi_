using System.Collections.Generic;
using InternAPI.Models;

namespace InternAPI.Repository.IRepository
{
    public interface IManagerRepository
    {
        List<Sirket> GetAllﬁirkets();

        Sirket GetSirketById(int id);

        Sirket CreateSirket(Sirket sirket);

        Sirket UpdateSirket(Sirket sirket);

        void DeleteSirket(int id);

    }
}