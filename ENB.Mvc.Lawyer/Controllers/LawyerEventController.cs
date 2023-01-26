using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LawyerOffice.Entities;
using LawyerOffice.Entities.Collections;
using LawyerOffice.Infrastructure;
using ENB.Mvc.Lawyer.Models;
using LawyerOffice.Entities.Repositories;
using AutoMapper;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using AspNetCoreHero.ToastNotification.Abstractions;


namespace ENB.Mvc.Lawyer.Controllers
{
    public class LawyerEventController : Controller
    {
        // GET: Lawyer

        private readonly ILawyerRepository _lawyerRepository;
        private readonly IUnitOfWorkFactory _unitOfWorkFactory;
        private readonly IMapper _imapper;
        private readonly ILogger<LawyerEventController> _logger;
        private readonly INotyfService _notifyService;

        /// <summary>
        /// Initializes a new instance of the LawyerEventController class.
        /// </summary>
        /// 

        public LawyerEventController(ILawyerRepository lawyerRepository, ILogger<LawyerEventController> logger,
                          IUnitOfWorkFactory unitOfWorkFactory, IMapper imapper, INotyfService notifyService)
        {
            _lawyerRepository = lawyerRepository;
            _logger = logger;
            _unitOfWorkFactory = unitOfWorkFactory;
            _imapper = imapper;
            _notifyService = notifyService;
        }
        public IActionResult Index(DateTime? eventDate)
        {
            ViewBag.EventDate = eventDate ?? DateTime.Now;
            return View();
        }

        [HttpGet]
        public IActionResult Create(string eventDate)
        {
            ViewBag.EventDate = eventDate;
            var data = new CreateAndEditLawyerEvent()
            {
                ListLawyers = _lawyerRepository.FindAll()
                       .Select(d => new SelectListItem
                       {
                           Text = d.FullName,
                           Value = d.Id.ToString(),
                           Selected = true

                       }).Distinct().ToList()


            };

            return View(data);
        }

        // POST: LawyerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CreateAndEditLawyerEvent createAndEditLawyerEvent)
        {
            var errors = ModelState.Values.SelectMany(v => v.Errors);
            if (ModelState.IsValid)
            {
                try
                {
                    using (_unitOfWorkFactory.Create())
                    {
                        var lawyer = _lawyerRepository.FindById(createAndEditLawyerEvent.LawyerId);
                        LawyerEvent evlawyer = new LawyerEvent();

                        _imapper.Map(createAndEditLawyerEvent, evlawyer);
                       
                        lawyer.LawyerEvents.Add(evlawyer);

                        _notifyService.Success("Lawyer event Added  Successfully! ");

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

        public JsonResult GetEvents()
        {

            var lwyrevents = (from lev in _lawyerRepository.FindAll().SelectMany(lwy => lwy.LawyerEvents)
                              join lwyt in _lawyerRepository.FindAll() on lev.LawyerId equals lwyt.Id
                              select new DisplayLawyerEvent
                              {
                                  Id = lev.Id,
                                  NameLawyer = lwyt.FullName,
                                  Title = lev.Title,
                                  LawyerId=lev.LawyerId,
                                  Start = lev.Start,
                                  End = lev.End,
                                  Description = lev.Description,
                                  Color =lev.Color,
                                  AllDay = lev.AllDay
                              }).ToArray();

            return Json(lwyrevents);


        }

        public IActionResult Edit(int lawyerId, int id)
        {

            var lwyrsgl = _lawyerRepository.FindById(lawyerId);
            ViewBag.Message = lwyrsgl.FullName;
            ViewBag.lawyerId = lawyerId;
            ViewBag.Id = id;

            var lwyrevt = _lawyerRepository.FindById(lawyerId, ev => ev.LawyerEvents);

            if (lwyrevt == null)
            {
                return NotFound();
            }

            var data = new CreateAndEditLawyerEvent()
            {
                ListLawyers = _lawyerRepository.FindAll()
                       .Select(d => new SelectListItem
                       {
                           Text = d.FullName,
                           Value = d.Id.ToString(),
                           Selected = true

                       }).Distinct().ToList()


            };

            _imapper.Map(lwyrevt.LawyerEvents.Single(x => x.Id == id), data);

            return View(data);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(CreateAndEditLawyerEvent createAndEditLawyerEvent, int lawyerId)
        {

            ViewBag.Lawyerid = lawyerId;
            if (ModelState.IsValid)
            {
                try
                {
                    using (_unitOfWorkFactory.Create())
                    {

                        var lawyerevt = _lawyerRepository.FindById(lawyerId, x => x.LawyerEvents);
                        var evt = lawyerevt.LawyerEvents.Single(x => x.Id == createAndEditLawyerEvent.Id);

                        _imapper.Map(createAndEditLawyerEvent, evt);

                        _notifyService.Success("Event related to Lawyer updated Successfully");

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

        public IActionResult Details(int lawyerId, int id)
        {

            var lwyrsgl = _lawyerRepository.FindById(lawyerId);
            ViewBag.Message = lwyrsgl.FullName;
            ViewBag.lawyerId = lawyerId;
            ViewBag.Id = id;

            var lwyrevt = _lawyerRepository.FindById(lawyerId, ev => ev.LawyerEvents);

            if (lwyrevt == null)
            {
                return NotFound();
            }
            var myevent = new DisplayLawyerEvent();

            var sglevent = _imapper.Map(lwyrevt.LawyerEvents.Single(x => x.Id == id),myevent);
            
            sglevent.Color = Enum.GetName(typeof(EventStatus), Int32.Parse(sglevent.Color));
            return View(sglevent);
        }

        // POST: LawyerEventController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(DisplayLawyerEvent displayLawyerEvent, int lawyerId)
        {
           // ViewBag.Case_Id = caseid;
            using (_unitOfWorkFactory.Create())
            {
                var lwyers = _lawyerRepository.FindById(lawyerId, x => x.LawyerEvents);
                var lwy_evts = lwyers.LawyerEvents.Single(x => x.Id == displayLawyerEvent.Id);

                    lwyers.LawyerEvents.Remove(lwy_evts);

                _notifyService.Error("Event related to Lawyer removed  Successfully");
            }
            return RedirectToAction(nameof(Index));
        }


    }
}
