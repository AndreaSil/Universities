using System;

namespace UniversitiesExam.Services.Specification
{
    public class PlanetaSpecification:ISpecification
    {
        
        public PlanetaSpecification()
        {

        }
        public bool IsSatisfiedBy(string nombre, string planeta)
        {
            if (planeta != null && planeta is string && !String.IsNullOrEmpty(planeta))
            {
                return true;
            }

            return false;

        }
        }
    }

