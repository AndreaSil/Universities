using System.Collections.Generic;
using System.Collections.Specialized;
using System.Net.NetworkInformation;
using UniversitiesExam.Models;

namespace UniversitiesExam.Services.Repository
{
    public class FakeRepository:IRepository
    {
        public List<Rebelde> GetListaRebeldes()
        {
            var listaRebeldes = new List<Rebelde>
            {
                new Rebelde("pepe", "marte")
            };
            return listaRebeldes;
        }


        public static StringCollection CrearCollection()
        {
            {
                StringCollection colection = new StringCollection
                {
                    "pepe","marte",
                    "pepa","tierra",
                    "Silla","Galaxia"
                };
                return colection;
            }
        }
    }
}
