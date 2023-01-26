using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LawyerOffice.Entities;
using LawyerOffice.Infrastructure;
using ENB.Mvc.Lawyer.Models;
using LawyerOffice.Entities.Repositories;
using AutoMapper;
using Microsoft.Extensions.Logging;
using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Authorization;

namespace ENB.Mvc.Lawyer.Controllers
{
    [Authorize]
    public class CasesController : Controller
    {
        // GET: CaseController

        private readonly ICaseRepository _caseRepository;
        private readonly IUnitOfWorkFactory _unitOfWorkFactory;
        private readonly IMapper _imapper;
        private readonly ILogger<CasesController> _logger;
        private readonly INotyfService _notifyService;

        /// <summary>
        /// Initializes a new instance of the CaseController class.
        /// </summary>
        public CasesController(ICaseRepository caseRepository, IUnitOfWorkFactory unitOfWorkFactory,
           ILogger<CasesController> logger   ,IMapper imapper, INotyfService notyfService)
        {
            _caseRepository = caseRepository;
            _unitOfWorkFactory = unitOfWorkFactory;
            _logger = logger;
            _imapper = imapper;
            _notifyService = notyfService;
        }
        public ActionResult Index()
        {
            return View();
        }

        public IActionResult GetCasesData()
        {
            IQueryable<Case> allcases = _caseRepository.FindAll();

            var Mpdata = _imapper.Map<List<DisplayCase>>(allcases).ToList();
            return Json(new { data = Mpdata });
        }

        // GET: CaseController/Details/5
        public IActionResult Details(int id)
        {
            ViewBag.Id = id;

            _logger.LogError($"Id :{id} of Case not found");

            Case dbCase = _caseRepository.FindById(id);

            ViewBag.Message = dbCase.CaseTitle;

            _logger.LogInformation($"Details of Case: {ViewBag.Message}");

            if (dbCase == null)
            {
                return NotFound();
            }

            var data = _imapper.Map<DisplayCase>(dbCase);

            return View(data);
        }

        // GET: CaseController/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CaseController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
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

                        _imapper.Map(createAndEditCase, dbCase);
                        _caseRepository.Add(dbCase);

                        _notifyService.Success("Case Added  Successfully! ");

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

        // GET: CaseController/Edit/5
        public IActionResult Edit(int id)
        {
            Case dbCase = _caseRepository.FindById(id);
            if (dbCase == null)
            {
                return NotFound();
            }
            var data = _imapper.Map<CreateAndEditCase>(dbCase);

            return View(data);
        }

        // POST: CaseController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(CreateAndEditCase createAndEditCase)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    using (_unitOfWorkFactory.Create())
                    {
                        Case dbCaseToUpdate = _caseRepository.FindById(createAndEditCase.Id);
                        _imapper.Map(createAndEditCase, dbCaseToUpdate, typeof(CreateAndEditCase), typeof(Case));

                        _notifyService.Success("Case Updated  Successfully! ");

                        return RedirectToAction("Index");
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

        // GET: CaseController/Delete/5
        public IActionResult Delete(int id)
        {
            Case dbCase = _caseRepository.FindById(id);
            ViewBag.Message = dbCase.CaseTitle;
            if (dbCase == null)
            {
                return NotFound();
            }
            var data = _imapper.Map<DisplayCase>(dbCase);
            return View(data);
        }

        // POST: CaseController/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            using (_unitOfWorkFactory.Create())
            {
                _caseRepository.Remove(id);
                _notifyService.Error("Case Removed  Successfully! ");
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
