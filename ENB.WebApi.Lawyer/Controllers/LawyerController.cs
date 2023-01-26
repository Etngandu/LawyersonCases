using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LawyerOffice.Infrastructure;
using Microsoft.Extensions.Logging;
using ENB.WebApi.Lawyer.Models;
using LawyerOffice.Entities.Repositories;
using LawyerOffice.Entities;
using AutoMapper;

namespace ENB.WebApi.Lawyer.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LawyerController : Controller
    {
        // GET: LawyerController

        private readonly IAsyncLawyerRepository _asyncLawyerRepository;
        private readonly IAsyncUnitOfWorkFactory _asyncUnitOfWorkFactory;
        private readonly ILawyerRepository _lawyerRepository;
        private readonly IUnitOfWorkFactory _unitOfWorkFactory;
        private readonly ILogger<LawyerController> _logger;
        private readonly IMapper _imapper;




        public LawyerController(ILawyerRepository lawyerRepository, IUnitOfWorkFactory unitOfWorkFactory,
                ILogger<LawyerController> logger, IMapper imapper)
        {
            _lawyerRepository = lawyerRepository;
            _unitOfWorkFactory = unitOfWorkFactory;           
            _logger = logger;
            _imapper = imapper;
        }

       
        [HttpGet]
        public IActionResult GetLawyerData()
        {
            var allLawyers = _lawyerRepository.FindAll();


            var lawyers = _imapper.Map<List<DisplayLawyer>>(allLawyers).ToList();


            return Ok(lawyers);
        }



        // GET: LawyerController/Details/5
        [HttpGet]
        [Route("details/{id}")]
        public IActionResult Details(int id)
        {
            ViewBag.Id = id;

            _logger.LogError($"Id :{id} of lawyer not found");

            LawyerOffice.Entities.Lawyer dbLawyer =  _lawyerRepository.FindById(id);          

            if (dbLawyer == null)
            {
                return NotFound();
            }

            ViewBag.Message = dbLawyer.FullName;

            _logger.LogInformation($"Details of lawyer: {ViewBag.Message}");
            var data = _imapper.Map<DisplayLawyer>(dbLawyer);

            return Ok(data);
        }

        

        // POST: LawyerController/Create
        [HttpPost]
        [Route("createlawyer")]
        public IActionResult Create(CreateAndEditLawyer createAndEditLawyer)
        {
            var errors = ModelState.Values.SelectMany(v => v.Errors);
            if (ModelState.IsValid)
            {
                try
                {
                    using (_unitOfWorkFactory.Create())
                    {
                        LawyerOffice.Entities.Lawyer dbLawyer = new LawyerOffice.Entities.Lawyer();

                        var createdlawyer=  _imapper.Map(createAndEditLawyer, dbLawyer);

                        _lawyerRepository.Add(dbLawyer);



                       return Ok(createdlawyer);
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
            return Ok(createAndEditLawyer);
        }

        // GET: LawyerController/Details/5
        [HttpGet]
        [Route("retrievelawyer/{id}")]
        public IActionResult RetrieveLawyer(int id)
        {
            ViewBag.Id = id;

            _logger.LogError($"Id :{id} of lawyer not found");

            LawyerOffice.Entities.Lawyer dbLawyer = _lawyerRepository.FindById(id);

            if (dbLawyer == null)
            {
                return NotFound();
            }

            ViewBag.Message = dbLawyer.FullName;

            _logger.LogInformation($"Details of lawyer: {ViewBag.Message}");
            var data = _imapper.Map<CreateAndEditLawyer>(dbLawyer);

            return Ok(data);
        }

        // POST: LawyerController/Edit/5
        [HttpPut]
        [Route("editlawyer")]
        //[ValidateAntiForgeryToken]        
        public IActionResult Edit(CreateAndEditLawyer createAndEditLawyer)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    using (_unitOfWorkFactory.Create())
                    {
                        LawyerOffice.Entities.Lawyer dbLawyerToUpdate = _lawyerRepository.FindById(createAndEditLawyer.Id);
                        var updatedlawyer = _imapper.Map(createAndEditLawyer, dbLawyerToUpdate, typeof(CreateAndEditLawyer), typeof(LawyerOffice.Entities.Lawyer));
                       

                        return Ok(updatedlawyer);
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
            return Ok(createAndEditLawyer);
        }



        // POST: LawyerController/Delete/5
        [HttpDelete]
        [Route("deletelawyer/{id}")]
        public IActionResult DeleteConfirmed(int id)
        {

             LawyerOffice.Entities.Lawyer dbLawyer = _lawyerRepository.FindById(id);

            using (_unitOfWorkFactory.Create())
            {
                _lawyerRepository.Remove(dbLawyer);                
            }
            return Ok();
        }
    }
}
