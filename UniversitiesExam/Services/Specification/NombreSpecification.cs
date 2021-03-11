using System;

namespace UniversitiesExam.Services.Specification
{
    public class NombreSpecification:ISpecification
    {
        public NombreSpecification()
        {
            
        }
        public bool IsSatisfiedBy(string nombre, string planeta)
        {
            if (nombre!= null&& nombre is string && !String.IsNullOrEmpty(nombre))
            {
                return true;
            }

            return false;
        }
    }
}
