using System.Collections.Generic;
using UniversitiesExam.Models;
using UniversitiesExam.Services.Exceptions;
using UniversitiesExam.Services.Factory;
using UniversitiesExam.Services.Split;

namespace UniversitiesExam.Services.Repository
{

    public class WebApiRepository:IRepository
    {

        public List<Rebelde> GetListaRebeldes()
        {
            ISplitService splitService = new SplitService();
            try
            {

                var lsitaRebeldes = new RebeldeFactory(splitService);
                if (lsitaRebeldes.ToString().Equals(" "))
                {
                    throw new RepositoryException("lista vacia");
                }
                return new List<Rebelde>();

            }
            catch (RepositoryException ex)
            {
                throw new ServiceException("Error en GetListaRebeldes()", ex);
            }
        }
    }
}
