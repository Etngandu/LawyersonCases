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
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using AspNetCoreHero.ToastNotification.Abstractions;

namespace ENB.Mvc.Lawyer.Controllers
{
    public class LawyersOnCasesController : Controller
    {

        // GET: Lawyer

        private readonly ILawyerRepository _lawyerRepository;
        private readonly ICaseRepository _caseRepository;
        private readonly IUnitOfWorkFactory _unitOfWorkFactory;
        private readonly IMapper _imapper;
        private readonly ILogger<LawyersOnCasesController> _logger;
        private readonly INotyfService _notifyService;

        /// <summary>
        /// Initializes a new instance of the LawyerOnCaseController class.
        /// </summary>
        /// 

        public LawyersOnCasesController(ILawyerRepository lawyerRepository, ICaseRepository caseRepository,
                                     ILogger<LawyersOnCasesController> logger  ,IUnitOfWorkFactory unitOfWorkFactory, IMapper imapper, INotyfService notifyService)
        {
            _lawyerRepository = lawyerRepository;
            _caseRepository = caseRepository;
            _logger = logger;
            _unitOfWorkFactory = unitOfWorkFactory;
            _imapper = imapper;
            _notifyService = notifyService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CasesperLawyerList(int lawyerId)
        {
            ViewBag.Lawyer_Id = lawyerId;
            var Nlawyer = _lawyerRepository.FindById(lawyerId);

            ViewBag.Message = Nlawyer.FullName;
            return View();
        }

        public IActionResult GetCasesperLawyerList(int lawyerId)

        {
            ViewBag.LawyerId = lawyerId;

            var lawyercases = _lawyerRepository.FindAll().Where(l => l.Id == lawyerId).SelectMany(l => l.LawyersOnCases)
                                                      .Join(_caseRepository.FindAll(),
                                                      lcs => lcs.Owner_CaseId,
                                                      cs => cs.Id,
                                                      (lawyercase, cse) => new DisplayLawyerOnCase
                                                      {
                                                          Id = lawyercase.Id,
                                                          Titlecase = cse.CaseTitle,
                                                          DateCreated = lawyercase.DateCreated,
                                                          Duration = lawyercase.Duration,
                                                          Case_status = lawyercase.Case_status,
                                                          Reference_role = lawyercase.Reference_role
                                                      });




            var Mpdata = _imapper.Map<List<DisplayLawyerOnCase>>(lawyercases);


            return Json(new { data = Mpdata });

        }

        public IActionResult LawyersperCaseList(int caseId)
        {
            ViewBag.Case_Id = caseId;
            var Ncase = _caseRepository.FindById(caseId);

            ViewBag.Message = Ncase.CaseTitle;
            return View();
        }
        public IActionResult GetLawyersperCaseList(int caseId)

        {
            ViewBag.CaseId = caseId;

            var caseLawyers = _caseRepository.FindAll().Where(l => l.Id == caseId).SelectMany(l => l.LawyersOnCases)
                                                      .Join(_lawyerRepository.FindAll(),
                                                      lcs => lcs.Owner_LawyerId,
                                                      cs => cs.Id,
                                                      (lawyercase, lwyr) => new DisplayLawyerOnCase
                                                      {
                                                          Id = lawyercase.Id,
                                                          NameLawyer = lwyr.FirstName + " " + lwyr.LastName,
                                                          DateCreated = lawyercase.DateCreated,
                                                          Duration = lawyercase.Duration,
                                                          Case_status = lawyercase.Case_status,
                                                          Reference_role = lawyercase.Reference_role,

                                                      });


            var NCase = _caseRepository.FindById(caseId);

            ViewBag.Message = NCase.CaseTitle;

            var Mpdata = _imapper.Map<List<DisplayLawyerOnCase>>(caseLawyers);

            return Json(new { data = Mpdata });
        }

        [HttpGet]
        public IActionResult CasesperLawyerCreate(int lawyerId)
        {
            ViewBag.Lawyer_Id = lawyerId;

            var data = new CreateAndEditLawyerOnCase()
            {
                ListCases = _caseRepository.FindAll()
                        .Select(d => new SelectListItem
                        {
                            Text = d.CaseTitle,
                            Value = d.Id.ToString(),
                            Selected = true

                        }).Distinct().ToList()



            };

            var Nlawyer = _lawyerRepository.FindById(lawyerId);

            ViewBag.Message = Nlawyer.FullName;

            return View(data);
        }


        public IActionResult LawyersperCaseCreate(int caseId)
        {
            ViewBag.CaseId = caseId;
            var data = new CreateAndEditLawyerOnCase()
            {
                ListLawyers = _lawyerRepository.FindAll()
                       .Select(d => new SelectListItem
                       {
                           Text = d.FullName,
                           Value = d.Id.ToString(),
                           Selected = true

                       }).Distinct().ToList()


            };

            var NCase = _caseRepository.FindById(caseId);

            ViewBag.Message = NCase.CaseTitle;

            return View(data);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CasesperLawyerCreate(CreateAndEditLawyerOnCase createAndEditLawyerOnCase, int lawyerid)
        {
            ViewBag.LawyerId = lawyerid;
            if (ModelState.IsValid)
            {
                try
                {
                    using (_unitOfWorkFactory.Create())
                    {
                        var lawyer = _lawyerRepository.FindById(lawyerid);


                        var lawyeroncase = new Lawyer_on_case();

                        ViewBag.Message = lawyer.FullName;

                        Billingprocess(createAndEditLawyerOnCase);

                        _imapper.Map(createAndEditLawyerOnCase, lawyeroncase);
                        lawyer.LawyersOnCases.Add(lawyeroncase);

                        _notifyService.Success($"Case related to lawyer {ViewBag.Message} Successfully ");

                        return RedirectToAction(nameof(CasesperLawyerList), new { lawyerid });
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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult LawyersperCaseCreate(CreateAndEditLawyerOnCase createAndEditLawyerOnCase, int caseid)
        {
            ViewBag.CaseId = caseid;
            if (ModelState.IsValid)
            {
                try
                {
                    using (_unitOfWorkFactory.Create())
                    {

                        var lcase = _caseRepository.FindById(caseid);

                        var lawyeroncase = new Lawyer_on_case();

                        ViewBag.Message = lcase.CaseTitle;

                        Billingprocess(createAndEditLawyerOnCase);

                        _imapper.Map(createAndEditLawyerOnCase, lawyeroncase);
                        lcase.LawyersOnCases.Add(lawyeroncase);

                        _notifyService.Success($"Lawyer related to case {ViewBag.Message}  Successfully");

                        return RedirectToAction("LawyersperCaseList", new { caseid });
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

        public decimal Billingprocess(CreateAndEditLawyerOnCase createAndEditLawyerOnCase)
        {
            decimal drt = Convert.ToDecimal(TimeSpan.Parse(createAndEditLawyerOnCase.Duration).TotalHours);
            
            var lawyr = _lawyerRepository.FindById((int)createAndEditLawyerOnCase.LawyerId);

            if (lawyr != null)
            {
                createAndEditLawyerOnCase.Billing_case = lawyr.Hourly_rate * drt;

            }
            
            return createAndEditLawyerOnCase.Billing_case;


        }
        public ActionResult CasesperLawyerEdit(int lawyerid, int id)
        {
            ViewBag.LawyerId = lawyerid;
            ViewBag.Id = id;

            var lawyersgl = _lawyerRepository.FindById(lawyerid);
            ViewBag.Message = lawyersgl.FullName;

            var lawyers = _lawyerRepository.FindById(lawyerid, x => x.LawyersOnCases);
            if (lawyers == null)
            {
                return NotFound();
            }

            var data = new CreateAndEditLawyerOnCase()
            {

                ListCases = _caseRepository.FindAll()
                        .Select(d => new SelectListItem
                        {
                            Text = d.CaseTitle,
                            Value = d.Id.ToString(),
                            Selected = true

                        }).Distinct().ToList()


            };

            _imapper.Map(lawyers.LawyersOnCases.Single(x => x.Id == id), data);

            return View(data);
        }

        public ActionResult LawyerspercaseEdit(int caseid, int id)
        {
            ViewBag.CaseId = caseid;
            ViewBag.Id = id;

            var casesgl = _caseRepository.FindById(caseid);
            ViewBag.Message = casesgl.CaseTitle;

            var casesl = _caseRepository.FindById(caseid, x => x.LawyersOnCases);

            if (casesl == null)
            {
                return NotFound();
            }


            var data = new CreateAndEditLawyerOnCase()
            {
                ListLawyers = _lawyerRepository.FindAll()
                       .Select(d => new SelectListItem
                       {
                           Text = d.FullName,
                           Value = d.Id.ToString(),
                           Selected = true

                       }).Distinct().ToList()




            };
            _imapper.Map(casesl.LawyersOnCases.Single(x => x.Id == id), data);




            return View(data);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CasesperLawyerEdit(CreateAndEditLawyerOnCase createAndEditLawyerOnCase, int lawyerid)
        {

            ViewBag.Lawyerid = lawyerid;
            if (ModelState.IsValid)
            {
                try
                {
                    using (_unitOfWorkFactory.Create())
                    {

                        var lawyercs = _lawyerRepository.FindById(lawyerid, x => x.LawyersOnCases);
                        var caselawyer = lawyercs.LawyersOnCases.Single(x => x.Id == createAndEditLawyerOnCase.Id);

                        _imapper.Map(createAndEditLawyerOnCase, caselawyer);

                        _notifyService.Success("Case related to Lawyer  updated Successfully");

                        return RedirectToAction(nameof(CasesperLawyerList), new { lawyerid });
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


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LawyerspercaseEdit(CreateAndEditLawyerOnCase createAndEditLawyerOnCase, int caseid)
        {

            ViewBag.Caseid = caseid;
            if (ModelState.IsValid)
            {
                try
                {
                    using (_unitOfWorkFactory.Create())
                    {

                        var caselwyers = _caseRepository.FindById(caseid, x => x.LawyersOnCases);
                        var lawyersc = caselwyers.LawyersOnCases.Single(x => x.Id == createAndEditLawyerOnCase.Id);

                        _imapper.Map(createAndEditLawyerOnCase, lawyersc);

                        _notifyService.Success("Lawyer related to case update Successfully");

                        return RedirectToAction(nameof(LawyersperCaseList), new { caseid });
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

        public ActionResult CasesperLawyerDetails(int id, int lawyerid)
        {

            ViewBag.LawyerId = lawyerid;
            ViewBag.Id = id;

            var Lawyerscase = _lawyerRepository.FindById(lawyerid, x => x.LawyersOnCases);
            var Lawyerscasefil = Lawyerscase.LawyersOnCases
                                                     .Join(_caseRepository.FindAll(),
                                                     lcs => lcs.Owner_CaseId,
                                                     cs => cs.Id,
                                                     (lawycase, cse) => new DisplayLawyerOnCase
                                                     {
                                                         Id = lawycase.Id,
                                                         Titlecase = cse.CaseTitle,
                                                         Case_status = lawycase.Case_status,
                                                         Reference_role = lawycase.Reference_role,
                                                         StartTime = lawycase.StartTime,
                                                         EndTime = lawycase.EndTime,
                                                         Duration = lawycase.Duration,
                                                         // Billing_case = (lawycase.Hourly_rate) * decimal.Parse(stud.Duration),
                                                         DateCreated = lawycase.DateCreated,
                                                         DateModified = lawycase.DateModified
                                                     }).ToList();


            var Nlawyer = _lawyerRepository.FindById(lawyerid);

            ViewBag.Message = Nlawyer.FullName;

            var sgl = Lawyerscasefil.Single(x => x.Id == id);


            return View(sgl);
        }


        public ActionResult LawyersperCaseDetails(int id, int caseid)
        {

            ViewBag.CaseId = caseid;
            ViewBag.Id = id;

            var caselawyers = _caseRepository.FindById(caseid, l => l.LawyersOnCases);
            var caselawyersfil = caselawyers.LawyersOnCases
                                                      .Join(_lawyerRepository.FindAll(),
                                                      lcs => lcs.Owner_LawyerId,
                                                      cs => cs.Id,
                                                      (lawycase, stand) => new DisplayLawyerOnCase
                                                      {
                                                          Id = lawycase.Id,
                                                          NameLawyer = stand.FirstName + " " + stand.LastName,
                                                          Case_status = lawycase.Case_status,
                                                          Reference_role = lawycase.Reference_role,
                                                          StartTime = lawycase.StartTime,
                                                          EndTime = lawycase.EndTime,
                                                          Duration = lawycase.Duration,
                                                          Billing_case = lawycase.Billing_case,
                                                          DateCreated = lawycase.DateCreated,
                                                          DateModified = lawycase.DateModified
                                                      }).ToList();


            var Ncase = _caseRepository.FindById(caseid);

            ViewBag.Message = Ncase.CaseTitle;

            var sgl = caselawyersfil.Single(x => x.Id == id);


            return View(sgl);
        }

        public ActionResult DeleteCaseperLawyer(int id, int lawyerid)
        {

            ViewBag.LawyerId = lawyerid;
            ViewBag.Id = id;

            var Lawyerscase = _lawyerRepository.FindById(lawyerid, x => x.LawyersOnCases);
            var Lawyerscasefil = Lawyerscase.LawyersOnCases
                                                     .Join(_caseRepository.FindAll(),
                                                     lcs => lcs.Owner_CaseId,
                                                     cs => cs.Id,
                                                     (lawycase, cse) => new DisplayLawyerOnCase
                                                     {
                                                         Id = lawycase.Id,
                                                         Titlecase = cse.CaseTitle,
                                                         Case_status = lawycase.Case_status,
                                                         Reference_role = lawycase.Reference_role,
                                                         StartTime = lawycase.StartTime,
                                                         EndTime = lawycase.EndTime,
                                                         Duration = lawycase.Duration,
                                                         // Billing_case = (lawycase.Hourly_rate) * decimal.Parse(stud.Duration),
                                                         DateCreated = lawycase.DateCreated,
                                                         DateModified = lawycase.DateModified
                                                     }).ToList();


            var Nlawyer = _lawyerRepository.FindById(lawyerid);

            ViewBag.Message = Nlawyer.FullName;

            var sgl = Lawyerscasefil.Single(x => x.Id == id);


            return View(sgl);
        }

        public ActionResult DeleteLawyerperCase(int id, int caseid)
        {

            ViewBag.CaseId = caseid;
            ViewBag.Id = id;

            var caselawyers = _caseRepository.FindById(caseid, l => l.LawyersOnCases);
            var caselawyersfil = caselawyers.LawyersOnCases
                                                      .Join(_lawyerRepository.FindAll(),
                                                      lcs => lcs.Owner_LawyerId,
                                                      cs => cs.Id,
                                                      (lawycase, stand) => new DisplayLawyerOnCase
                                                      {
                                                          Id = lawycase.Id,
                                                          NameLawyer = stand.FirstName + " " + stand.LastName,
                                                          Case_status = lawycase.Case_status,
                                                          Reference_role = lawycase.Reference_role,
                                                          StartTime = lawycase.StartTime,
                                                          EndTime = lawycase.EndTime,
                                                          Duration = lawycase.Duration,
                                                          Billing_case = lawycase.Billing_case,
                                                          DateCreated = lawycase.DateCreated,
                                                          DateModified = lawycase.DateModified
                                                      }).ToList();


            var Ncase = _caseRepository.FindById(caseid);

            ViewBag.Message = Ncase.CaseTitle;

            var sgl = caselawyersfil.Single(x => x.Id == id);


            return View(sgl);
        }
        // POST: LawyersOnCasesController/Delete/5
        [HttpPost, ActionName("DeleteL")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteCaseperLawyerConfirmed(DisplayLawyerOnCase displayLawyerOnCase, int lawyerid)
        {
            ViewBag.Lawyer_Id = lawyerid;

            using (_unitOfWorkFactory.Create())
            {
                var lawyer = _lawyerRepository.FindById(lawyerid, x => x.LawyersOnCases);
                var lwy_cas = lawyer.LawyersOnCases.Single(x => x.Id == displayLawyerOnCase.Id);
                lawyer.LawyersOnCases.Remove(lwy_cas);

               _notifyService.Error("Case related to Lawyer removed  Successfully");
            }
            return RedirectToAction(nameof(CasesperLawyerList), new { lawyerid });
        }

        // POST: LawyersOnCasesController/Delete/5
        [HttpPost, ActionName("DeleteC")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteLawyerperCaseConfirmed(DisplayLawyerOnCase displayLawyerOnCase, int caseid)
        {
            ViewBag.Case_Id = caseid;
            using (_unitOfWorkFactory.Create())
            {
                var cse = _caseRepository.FindById(caseid, x => x.LawyersOnCases);
                var lwy_cas = cse.LawyersOnCases.Single(x => x.Id == displayLawyerOnCase.Id);
                cse.LawyersOnCases.Remove(lwy_cas);

                _notifyService.Error("Lawyer related to Case removed  Successfully");
            }
            return RedirectToAction(nameof(LawyersperCaseList), new { caseid });
        }
    }
}