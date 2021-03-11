using System;
using System.Collections.Specialized;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using UniversitiesExam.Services.Exceptions;
using UniversitiesExam.Services.Factory;
using UniversitiesExam.Services.Log;
using UniversitiesExam.Services.Repository;
using UniversitiesExam.Services.Split;

namespace UniversitiesExam.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RebeldeController : ControllerBase
    {
        private readonly IRepository _repository;
        private readonly ILogger _logger;
        private readonly ILog _log;
        private readonly ISplitService _splitService;


        public RebeldeController(IRepository repository, ILogger logger, ILog log, ISplitService splitService)
        {
            _repository = repository;
            _logger = logger;
            _log = log;
            _splitService = splitService;

        }

        //GET: api/Rebelde/5
        [HttpGet]
        [Route("GetRebeldes")]
        public IActionResult Get()
        {
            try
            {
                var listaRebeldes = _repository.GetListaRebeldes();
                return Ok(listaRebeldes);
            }
            catch (RepositoryException ex)
            {
                _logger.LogError(ex.Message);
                return StatusCode(500);
            }
        }

        //POST: api/Rebelde
        [HttpPost]
        public IActionResult Post(StringCollection collection)
        {
            ISplitService splitService = new SplitService();

            try
            {
                var listaRebeldes= new RebeldeFactory(splitService).ListRebeldes(collection);
                ILog log=new Log();
                log.CrearLog(listaRebeldes);
                return Ok(listaRebeldes);
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return StatusCode(500);
            }
        }

    }
}