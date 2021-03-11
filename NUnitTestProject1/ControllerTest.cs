using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;
using NUnit.Framework;
using UniversitiesExam.Services.Factory;
using UniversitiesExam.Services.Split;

namespace NUnitTestProject1
{
    public class ControllerTest
    {
        ISplitService splitService = new SplitService();
        [Test]
        public void ControladorTest(StringCollection collection)
        {
            bool objeto = false;
            try
            {
                var listaRebeldes = new RebeldeFactory(splitService).ListRebeldes(collection);
            }
            catch (Exception e)
            {
                
                objeto = true;
            }
            
            Assert.IsFalse(objeto);
        }
    }
}
