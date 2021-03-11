using System;
using NUnit.Framework;
using UniversitiesExam.Services.Exceptions;
using UniversitiesExam.Services.Split;

namespace NUnitTestProject1.TestsSplit
{
    public class TestSplitErroneo
    {

        private string _stringErroneo;
        private ISplitService _splitService;
        

        [Test]
        public void SeparaSplitErroneo()
        {
            bool error = false;

            try
            {
                _splitService = new SplitService();
                _stringErroneo = "lola|potato";
                _splitService.AplicaSplit(_stringErroneo, ',');
                
            }
            catch (SplitException)
            {
                error = true;
            }
            
            Assert.IsTrue(error);
        }
    }
}
