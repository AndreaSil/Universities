using System.Collections.Generic;
using System.Collections.Specialized;
using UniversitiesExam.Models;

namespace UniversitiesExam.Services.Factory
{
    public interface IRebeldeFactory
    {
        List<Rebelde> ListRebeldes(StringCollection collection);
    }
}
