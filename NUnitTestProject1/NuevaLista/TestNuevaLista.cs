using System.Collections.Generic;
using System.Collections.Specialized;
using Moq;
using NUnit.Framework;
using UniversitiesExam.Models;
using UniversitiesExam.Services.Factory;
using UniversitiesExam.Services.Split;

namespace NUnitTestProject1.NuevaLista
{
    public class TestNuevaLista
    {
        
        
        readonly StringCollection _collection=new StringCollection();
        List<Rebelde> rebelde= new List<Rebelde>();
        [Test]
        public void PruebaMock()
        {
            var mock= new Mock<IRebeldeFactory>();
           
            mock.Setup(m => m.ListRebeldes(_collection)).Returns(rebelde);
            Assert.IsNotNull(rebelde);
        }
    }
}
