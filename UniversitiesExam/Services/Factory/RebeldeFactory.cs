using System.Collections.Generic;
using System.Collections.Specialized;
using UniversitiesExam.Models;
using UniversitiesExam.Services.Specification;
using UniversitiesExam.Services.Split;

namespace UniversitiesExam.Services.Factory
{
    public class RebeldeFactory : IRebeldeFactory
    {
        private readonly ISplitService _splitService;
        private readonly ISpecification _specificationNombre = new NombreSpecification();
        private readonly ISpecification _specificationPlaneta = new PlanetaSpecification();
       



        public RebeldeFactory(ISplitService splitService)
        {
            _splitService = splitService;
        }

        

        public List<Rebelde> ListRebeldes(StringCollection collection)
        {
            List<Rebelde> listaRebeldes = new List<Rebelde>();
            for (int i = 0; i < collection.Count; i++)
            {
                
               
                if (_specificationNombre.IsSatisfiedBy(collection[i], collection[i + 1])
                    && _specificationPlaneta.IsSatisfiedBy(collection[i], collection[i + 1]))
                {
                    listaRebeldes.Add(new Rebelde(collection[i], collection[i + 1]));

                }
                i = i + 1;
            }

            return listaRebeldes;
        }
    }
}
