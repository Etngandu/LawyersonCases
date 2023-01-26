using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LawyerOffice.Entities;
using LawyerOffice.Infrastructure;
using ENB.WebApi.Lawyer.Models;
using LawyerOffice.Entities.Repositories;
using AutoMapper;
using Microsoft.Extensions.Logging;

namespace ENB.WebApi.Lawyer.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CasesController : Controller
    {
        // GET: CaseController

        private readonly IAsyncCaseRepository _asyncCaseRepository;
        private readonly ICaseRepository _caseRepository;
        private readonly IAsyncUnitOfWorkFactory _asyncUnitOfWorkFactory;
        private readonly IUnitOfWorkFactory _unitOfWorkFactory;
        private readonly IMapper _imapper;
        private readonly ILogger<CasesController> _logger;       

        /// <summary>
        /// Initializes a new instance of the CaseController class.
        /// </summary>
        public CasesController(IAsyncCaseRepository asyncCaseRepository, IAsyncUnitOfWorkFactory asyncUnitOfWorkFactory,
           ILogger<CasesController> logger, IMapper imapper, ICaseRepository caseRepository, IUnitOfWorkFactory unitOfWorkFactory)
        {
            _asyncCaseRepository = asyncCaseRepository;
            _asyncUnitOfWorkFactory = asyncUnitOfWorkFactory;
            _logger = logger;
            _imapper = imapper;
            _caseRepository = caseRepository;
            _unitOfWorkFactory = unitOfWorkFactory;
        }

        [HttpGet]
        public IActionResult GetCasesData()
        {
            IQueryable<Case> allcases = _caseRepository.FindAll();

            var cases = _imapper.Map<List<DisplayCase>>(allcases).ToList();
            return Ok( cases );
        }

        // GET: CaseController/Details/5
        [HttpGet]
        [Route("detailscase/{id}")]
        public async Task< IActionResult> Details(int id)
        {
            ViewBag.Id = id;

            _logger.LogError($"Id :{id} of Case not found");

            Case dbCase = await _asyncCaseRepository.FindById(id);

            if (dbCase == null)
            {
                return NotFound();
            }

            ViewBag.Message = dbCase.CaseTitle;

            _logger.LogInformation($"Details of Case: {ViewBag.Message}");

            

            var data = _imapper.Map<DisplayCase>(dbCase);

            return Ok(data);
        }

        

        // POST: CaseController/Create
        [HttpPost]
        [Route("createcase")]
        public IActionResult Create(CreateAndEditCase createAndEditCase)
        {
            var errors = ModelState.Values.SelectMany(v => v.Errors);
            if (ModelState.IsValid)
            {
                try
                {
                    using (_unitOfWorkFactory.Create())
                    {
                        Case dbCase = new Case();

               var addcase=  _imapper.Map(createAndEditCase, dbCase);

                     _caseRepository.Add(dbCase);                        

                        return Ok(addcase);
                    }
                }
                catch (ModelValidationException mvex)
                {
                    foreach (var error in mvex.ValidationErrors)
                    {
                        ModelState.AddModelError(error.MemberNames.FirstOrDefault() ?? "", error.ErrorMessage);
                    }
                }
            }
            return Ok(createAndEditCase);
        }


        // GET: CaseController/Details/5
        [HttpGet]
        [Route("retrievecase/{id}")]
        public async Task<IActionResult> RetrieveCase(int id)
        {
            ViewBag.Id = id;

            _logger.LogError($"Id :{id} of Case not found");

            Case dbCase = await _asyncCaseRepository.FindById(id);

            if (dbCase == null)
            {
                return NotFound();
            }

            ViewBag.Message = dbCase.CaseTitle;

            _logger.LogInformation($"Details of Case: {ViewBag.Message}");



            var data = _imapper.Map<CreateAndEditCase>(dbCase);

            return Ok(data);
        }

        // PUT: CaseController/Edit/5
        [HttpPut]
        [Route("editcase")]
        public  IActionResult Edit(CreateAndEditCase createAndEditCase)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    using (_unitOfWorkFactory.Create())
                    {
                        Case dbCaseToUpdate =  _caseRepository.FindById(createAndEditCase.Id);
                 var editcase=    _imapper.Map(createAndEditCase, dbCaseToUpdate, typeof(CreateAndEditCase), typeof(Case));

                      

                        return Ok(editcase);
                    }
                }
                catch (ModelValidationException mvex)
                {
                    foreach (var error in mvex.ValidationErrors)
                    {
                        ModelState.AddModelError(error.MemberNames.FirstOrDefault() ?? "", error.ErrorMessage);
                    }
                }
            }
            return Ok(createAndEditCase);
        }

        

        // DELETE: CaseController/Delete/5
        [HttpDelete]
        [Route("deletecase/{id}")]
        public IActionResult Delete(int id)
        {
            Case dbCase= _caseRepository.FindById(id);
            using (_unitOfWorkFactory.Create())
            {
                _caseRepository.Remove(dbCase);
                
            }
            return Ok();
        }
    }
}
