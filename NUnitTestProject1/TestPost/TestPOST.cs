using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Microsoft.Extensions.Logging;
using NUnit.Framework;
using UniversitiesExam.Models;
using UniversitiesExam.Services.Factory;
using UniversitiesExam.Services.Log;
using UniversitiesExam.Services.Split;

namespace NUnitTestProject1.TestPost
{
    public class TestPost
    {
        private readonly ILogger _logger;
        [Test]
        public void TestPosts()
        {

            bool error = false;
            try
            {
                ISplitService convierte = new SplitService();
                StringCollection collection = new StringCollection()
                {
                    "andrea",
                    "marte",
                    "guspy",
                    "jesucristoplanet"
                };

                List<Rebelde> listaRebeldes = new RebeldeFactory(convierte).ListRebeldes(collection);
                ILog log = new Log();
                log.CrearLog(listaRebeldes);

            }
            catch (Exception e)
            {
                error = true;
                _logger.LogError(e.Message);

            }


            Assert.IsFalse(error);
        }

    }

}
