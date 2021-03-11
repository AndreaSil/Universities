using System;
using System.Collections.Generic;
using System.Text;
using Moq;
using NUnit.Framework;
using UniversitiesExam.Models;
using UniversitiesExam.Services.Repository;

namespace NUnitTestProject1.NuevaLista
{
    public class SimularCapaRepositoryTest
    {
        [Test]
        public void CrearCapaRepositorio()

        {
            //var rebelde= new Mock<List<Rebelde>>();
            
            var mockFakeRepository = new Mock<IRepository>();

            mockFakeRepository.Setup(m => m.GetListaRebeldes()).Returns(new List<Rebelde>());
            
            var pruebaRebelde = new List<Rebelde>(mockFakeRepository.Object.GetListaRebeldes());
        }
    }
}
