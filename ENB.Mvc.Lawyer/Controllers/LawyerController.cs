using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LawyerOffice.Entities;
using LawyerOffice.Infrastructure;
using Microsoft.Extensions.Logging;
using ENB.Mvc.Lawyer.Models;
using LawyerOffice.Entities.Repositories;
using AutoMapper;
using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Authorization;

namespace ENB.Mvc.Lawyer.Controllers
{
    [Authorize]
    public class LawyerController : Controller
    {
        // GET: LawyerController

        private readonly ILawyerRepository _lawyerRepository;
        private readonly IUnitOfWorkFactory _unitOfWorkFactory;
        private readonly ILogger<LawyerController> _logger;
        private readonly IMapper _imapper;
        
        private readonly INotyfService _notifyService;


        public LawyerController(ILawyerRepository lawyerRepository, IUnitOfWorkFactory unitOfWorkFactory,
             ILogger<LawyerController> logger  , IMapper imapper, INotyfService notifyService)
        {
            _lawyerRepository = lawyerRepository;
            _unitOfWorkFactory = unitOfWorkFactory;
            _logger = logger;
            _imapper = imapper;
            _notifyService = notifyService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetLawyerData()
        {
            IQueryable<LawyerOffice.Entities.Lawyer> allLawyers = _lawyerRepository.FindAll();

            var Mpdata = _imapper.Map<List<DisplayLawyer>>(allLawyers).ToList();
            return Json(new { data = Mpdata });
        }

         

        // GET: LawyerController/Details/5
        public IActionResult Details(int id)
        {
            ViewBag.Id = id;

            _logger.LogError($"Id :{id} of lawyer not found");

            LawyerOffice.Entities.Lawyer dbLawyer = _lawyerRepository.FindById(id);

            ViewBag.Message = dbLawyer.FullName;

            _logger.LogInformation($"Details of lawyer: {ViewBag.Message}");

            if (dbLawyer == null)
            {
                return NotFound();
            }

            var data = _imapper.Map<DisplayLawyer>(dbLawyer);

            return View(data);
        }

        // GET: LawyerController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LawyerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
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

                        _imapper.Map(createAndEditLawyer, dbLawyer);
                        
                        _lawyerRepository.Add(dbLawyer);

                     _notifyService.Success("Lawyer Added  Successfully! ");

                        return RedirectToAction(nameof(Index));
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
            return View();
        }

        // GET: LawyerController/Edit/5
        public IActionResult Edit(int id)
        {

            _logger.LogError($"Lawyer {id} not found");

            LawyerOffice.Entities.Lawyer dbLawyer = _lawyerRepository.FindById(id);
            if (dbLawyer == null)
            {
                return NotFound();
            }
            var data = _imapper.Map<CreateAndEditLawyer>(dbLawyer);

            return View(data);
        }

        // POST: LawyerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(CreateAndEditLawyer createAndEditLawyer)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    using (_unitOfWorkFactory.Create())
                    {
                        LawyerOffice.Entities.Lawyer dbLawyerToUpdate = _lawyerRepository.FindById(createAndEditLawyer.Id);
                        _imapper.Map(createAndEditLawyer, dbLawyerToUpdate, typeof(CreateAndEditLawyer), typeof(LawyerOffice.Entities.Lawyer));

                        _notifyService.Success("Lawyer Update  Successfully! ");

                        return RedirectToAction(nameof(Index));
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
            return View();
        }

        // GET: LawyerController/Delete/5
        public IActionResult Delete(int id)
        {
            LawyerOffice.Entities.Lawyer dbLawyer = _lawyerRepository.FindById(id);
            ViewBag.Message = dbLawyer.FullName;
            if (dbLawyer == null)
            {
                return NotFound();
            }
            var data = _imapper.Map<DisplayLawyer>(dbLawyer);
            return View(data);
        }

        // POST: LawyerController/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            using (_unitOfWorkFactory.Create())
            {
                _lawyerRepository.Remove(id);

                _notifyService.Error("Lawyer Removed  Successfully! ");
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
