using System.Collections.Generic;
using UniversitiesExam.Models;

namespace UniversitiesExam.Services.Repository
{
    public interface IRepository
    {
        List<Rebelde> GetListaRebeldes();
    }
}
