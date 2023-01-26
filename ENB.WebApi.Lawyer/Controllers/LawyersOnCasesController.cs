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
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;


namespace ENB.WebApi.Lawyer.Controllers
{
    //public class LawyersOnCasesController : Controller
    //{

    //    // GET: Lawyer

    //    private readonly IAsyncLawyerRepository _asyncLawyerRepository ;
    //    private readonly IAsyncCaseRepository _asyncCaseRepository;
    //    private readonly IAsyncUnitOfWorkFactory _asyncUnitOfWorkFactory ;
    //    private readonly IMapper _imapper;
    //    private readonly ILogger<LawyersOnCasesController> _logger;
        

    //    /// <summary>
    //    /// Initializes a new instance of the LawyerOnCaseController class.
    //    /// </summary>
    //    /// 

    //    public LawyersOnCasesController(IAsyncLawyerRepository asyncLawyerRepository, IAsyncCaseRepository asyncCaseRepository,
    //                                 ILogger<LawyersOnCasesController> logger  ,IAsyncUnitOfWorkFactory asyncUnitOfWorkFactory, IMapper imapper)
    //    {
    //        _asyncLawyerRepository = asyncLawyerRepository;
    //        _asyncCaseRepository = asyncCaseRepository;
    //        _logger = logger;
    //        _asyncUnitOfWorkFactory = asyncUnitOfWorkFactory;
    //        _imapper = imapper;
            
    //    }
        

    //    public async Task<IActionResult> CasesperLawyerList(int lawyerId)
    //    {
    //        ViewBag.Lawyer_Id = lawyerId;

    //        var lwyr = await _asyncLawyerRepository.FindById(lawyerId);

    //        ViewBag.Message = lwyr.FullName;
    //        return View();
    //    }

    //    public IActionResult GetCasesperLawyerList(int lawyerId)

    //    {
    //        ViewBag.LawyerId = lawyerId;

    //        var lawyercases =  _asyncLawyerRepository.FindAll().Where(l => l.Id == lawyerId).SelectMany(l => l.LawyersOnCases)
    //                                                  .Join(_asyncCaseRepository.FindAll(),
    //                                                  lcs => lcs.Owner_CaseId,
    //                                                  cs => cs.Id,
    //                                                  (lawyercase, cse) => new DisplayLawyerOnCase
    //                                                  {
    //                                                      Id = lawyercase.Id,
    //                                                      Titlecase = cse.CaseTitle,
    //                                                      DateCreated = lawyercase.DateCreated,
    //                                                      Duration = lawyercase.Duration,
    //                                                      Case_status = lawyercase.Case_status,
    //                                                      Reference_role = lawyercase.Reference_role
    //                                                  });




    //        var Mpdata = _imapper.Map<List<DisplayLawyerOnCase>>(lawyercases);


    //        return Ok( Mpdata );

    //    }

        
    //    public IActionResult GetLawyersperCaseList(int caseId)

    //    {
    //        ViewBag.CaseId = caseId;

    //        var caseLawyers = _asyncCaseRepository.FindAll().Where(l => l.Id == caseId).SelectMany(l => l.LawyersOnCases)
    //                                                  .Join(_asyncLawyerRepository.FindAll(),
    //                                                  lcs => lcs.Owner_LawyerId,
    //                                                  cs => cs.Id,
    //                                                  (lawyercase, lwyr) => new DisplayLawyerOnCase
    //                                                  {
    //                                                      Id = lawyercase.Id,
    //                                                      NameLawyer = lwyr.FirstName + " " + lwyr.LastName,
    //                                                      DateCreated = lawyercase.DateCreated,
    //                                                      Duration = lawyercase.Duration,
    //                                                      Case_status = lawyercase.Case_status,
    //                                                      Reference_role = lawyercase.Reference_role,

    //                                                  });


           

    //        var Mpdata = _imapper.Map<List<DisplayLawyerOnCase>>(caseLawyers);

    //        return Ok( Mpdata );
    //    }

        


       

          

    //    [HttpPost]        
    //    public async Task<IActionResult> CasesperLawyerCreate(CreateAndEditLawyerOnCase createAndEditLawyerOnCase, int lawyerid)
    //    {
           
    //        if (ModelState.IsValid)
    //        {
    //            try
    //            {
    //                using (_asyncUnitOfWorkFactory.Create())
    //                {
    //                     var lwyr = await _asyncLawyerRepository.FindById(lawyerid);


    //                    var lawyeroncase = new Lawyer_on_case();

                       

    //                  await  Billingprocess(createAndEditLawyerOnCase);

    //                    _imapper.Map(createAndEditLawyerOnCase, lawyeroncase);

    //                       lwyr.LawyersOnCases.Add(lawyeroncase);

                        

    //                    return Ok("Added Successfuly");
    //                }
    //            }
    //            catch (ModelValidationException mvex)
    //            {
    //                foreach (var error in mvex.ValidationErrors)
    //                {
    //                    ModelState.AddModelError(error.MemberNames.FirstOrDefault() ?? "", error.ErrorMessage);
    //                }
    //            }
    //        }
    //        return View();
    //    }

    //    [HttpPost]       
    //    public async Task<IActionResult> LawyersperCaseCreate(CreateAndEditLawyerOnCase createAndEditLawyerOnCase, int caseid)
    //    {
            
    //        if (ModelState.IsValid)
    //        {
    //            try
    //            {
    //                using (_asyncUnitOfWorkFactory.Create())
    //                {

    //                    var lcase = await _asyncCaseRepository.FindById(caseid);

    //                    var lawyeroncase = new Lawyer_on_case();

                       

    //                await  Billingprocess(createAndEditLawyerOnCase);

    //                    _imapper.Map(createAndEditLawyerOnCase, lawyeroncase);
    //                    lcase.LawyersOnCases.Add(lawyeroncase);

                       

    //                    return Ok("Added successfuly");
    //                }
    //            }
    //            catch (ModelValidationException mvex)
    //            {
    //                foreach (var error in mvex.ValidationErrors)
    //                {
    //                    ModelState.AddModelError(error.MemberNames.FirstOrDefault() ?? "", error.ErrorMessage);
    //                }
    //            }
    //        }
    //        return View();
    //    }

    //    public async Task<decimal> Billingprocess(CreateAndEditLawyerOnCase createAndEditLawyerOnCase)
    //    {
    //        decimal drt = Convert.ToDecimal(TimeSpan.Parse(createAndEditLawyerOnCase.Duration).TotalHours);
            
    //        var lawyr = await _asyncLawyerRepository.FindById((int)createAndEditLawyerOnCase.LawyerId);

    //        if (lawyr != null)
    //        {
    //            createAndEditLawyerOnCase.Billing_case =  lawyr.Hourly_rate * drt;

    //        }
            
    //        return createAndEditLawyerOnCase.Billing_case;


    //    }        
        

    //    [HttpPost]
    //    [ValidateAntiForgeryToken]
    //    public ActionResult CasesperLawyerEdit(CreateAndEditLawyerOnCase createAndEditLawyerOnCase, int lawyerid)
    //    {

    //        ViewBag.Lawyerid = lawyerid;
    //        if (ModelState.IsValid)
    //        {
    //            try
    //            {
    //                using (_asyncUnitOfWorkFactory.Create())
    //                {

    //                    var lawyercs = _asyncLawyerRepository.FindById(lawyerid, x => x.LawyersOnCases);
    //                    var caselawyer = lawyercs.LawyersOnCases.Single(x => x.Id == createAndEditLawyerOnCase.Id);

    //                    _imapper.Map(createAndEditLawyerOnCase, caselawyer);

                       

    //                    return RedirectToAction(nameof(CasesperLawyerList), new { lawyerid });
    //                }
    //            }
    //            catch (ModelValidationException mvex)
    //            {
    //                foreach (var error in mvex.ValidationErrors)
    //                {
    //                    ModelState.AddModelError(error.MemberNames.FirstOrDefault() ?? "", error.ErrorMessage);
    //                }
    //            }
    //        }
    //        return View();
    //    }


    //    [HttpPost]
    //    [ValidateAntiForgeryToken]
    //    public ActionResult LawyerspercaseEdit(CreateAndEditLawyerOnCase createAndEditLawyerOnCase, int caseid)
    //    {

    //        ViewBag.Caseid = caseid;
    //        if (ModelState.IsValid)
    //        {
    //            try
    //            {
    //                using (_unitOfWorkFactory.Create())
    //                {

    //                    var caselwyers = _caseRepository.FindById(caseid, x => x.LawyersOnCases);
    //                    var lawyersc = caselwyers.LawyersOnCases.Single(x => x.Id == createAndEditLawyerOnCase.Id);

    //                    _imapper.Map(createAndEditLawyerOnCase, lawyersc);

                       

    //                    return RedirectToAction(nameof(LawyersperCaseList), new { caseid });
    //                }
    //            }
    //            catch (ModelValidationException mvex)
    //            {
    //                foreach (var error in mvex.ValidationErrors)
    //                {
    //                    ModelState.AddModelError(error.MemberNames.FirstOrDefault() ?? "", error.ErrorMessage);
    //                }
    //            }
    //        }
    //        return View();
    //    }

    //    public ActionResult CasesperLawyerDetails(int id, int lawyerid)
    //    {

    //        ViewBag.LawyerId = lawyerid;
    //        ViewBag.Id = id;

    //        var Lawyerscase = _lawyerRepository.FindById(lawyerid, x => x.LawyersOnCases);
    //        var Lawyerscasefil = Lawyerscase.LawyersOnCases
    //                                                 .Join(_caseRepository.FindAll(),
    //                                                 lcs => lcs.Owner_CaseId,
    //                                                 cs => cs.Id,
    //                                                 (lawycase, cse) => new DisplayLawyerOnCase
    //                                                 {
    //                                                     Id = lawycase.Id,
    //                                                     Titlecase = cse.CaseTitle,
    //                                                     Case_status = lawycase.Case_status,
    //                                                     Reference_role = lawycase.Reference_role,
    //                                                     StartTime = lawycase.StartTime,
    //                                                     EndTime = lawycase.EndTime,
    //                                                     Duration = lawycase.Duration,
    //                                                     // Billing_case = (lawycase.Hourly_rate) * decimal.Parse(stud.Duration),
    //                                                     DateCreated = lawycase.DateCreated,
    //                                                     DateModified = lawycase.DateModified
    //                                                 }).ToList();


    //        var Nlawyer = _lawyerRepository.FindById(lawyerid);

    //        ViewBag.Message = Nlawyer.FullName;

    //        var sgl = Lawyerscasefil.Single(x => x.Id == id);


    //        return View(sgl);
    //    }


    //    public ActionResult LawyersperCaseDetails(int id, int caseid)
    //    {

    //        ViewBag.CaseId = caseid;
    //        ViewBag.Id = id;

    //        var caselawyers = _caseRepository.FindById(caseid, l => l.LawyersOnCases);
    //        var caselawyersfil = caselawyers.LawyersOnCases
    //                                                  .Join(_lawyerRepository.FindAll(),
    //                                                  lcs => lcs.Owner_LawyerId,
    //                                                  cs => cs.Id,
    //                                                  (lawycase, stand) => new DisplayLawyerOnCase
    //                                                  {
    //                                                      Id = lawycase.Id,
    //                                                      NameLawyer = stand.FirstName + " " + stand.LastName,
    //                                                      Case_status = lawycase.Case_status,
    //                                                      Reference_role = lawycase.Reference_role,
    //                                                      StartTime = lawycase.StartTime,
    //                                                      EndTime = lawycase.EndTime,
    //                                                      Duration = lawycase.Duration,
    //                                                      Billing_case = lawycase.Billing_case,
    //                                                      DateCreated = lawycase.DateCreated,
    //                                                      DateModified = lawycase.DateModified
    //                                                  }).ToList();


    //        var Ncase = _caseRepository.FindById(caseid);

    //        ViewBag.Message = Ncase.CaseTitle;

    //        var sgl = caselawyersfil.Single(x => x.Id == id);


    //        return View(sgl);
    //    }

    //    public ActionResult DeleteCaseperLawyer(int id, int lawyerid)
    //    {

    //        ViewBag.LawyerId = lawyerid;
    //        ViewBag.Id = id;

    //        var Lawyerscase = _lawyerRepository.FindById(lawyerid, x => x.LawyersOnCases);
    //        var Lawyerscasefil = Lawyerscase.LawyersOnCases
    //                                                 .Join(_caseRepository.FindAll(),
    //                                                 lcs => lcs.Owner_CaseId,
    //                                                 cs => cs.Id,
    //                                                 (lawycase, cse) => new DisplayLawyerOnCase
    //                                                 {
    //                                                     Id = lawycase.Id,
    //                                                     Titlecase = cse.CaseTitle,
    //                                                     Case_status = lawycase.Case_status,
    //                                                     Reference_role = lawycase.Reference_role,
    //                                                     StartTime = lawycase.StartTime,
    //                                                     EndTime = lawycase.EndTime,
    //                                                     Duration = lawycase.Duration,
    //                                                     // Billing_case = (lawycase.Hourly_rate) * decimal.Parse(stud.Duration),
    //                                                     DateCreated = lawycase.DateCreated,
    //                                                     DateModified = lawycase.DateModified
    //                                                 }).ToList();


    //        var Nlawyer = _lawyerRepository.FindById(lawyerid);

    //        ViewBag.Message = Nlawyer.FullName;

    //        var sgl = Lawyerscasefil.Single(x => x.Id == id);


    //        return View(sgl);
    //    }

    //    public ActionResult DeleteLawyerperCase(int id, int caseid)
    //    {

    //        ViewBag.CaseId = caseid;
    //        ViewBag.Id = id;

    //        var caselawyers = _caseRepository.FindById(caseid, l => l.LawyersOnCases);
    //        var caselawyersfil = caselawyers.LawyersOnCases
    //                                                  .Join(_lawyerRepository.FindAll(),
    //                                                  lcs => lcs.Owner_LawyerId,
    //                                                  cs => cs.Id,
    //                                                  (lawycase, stand) => new DisplayLawyerOnCase
    //                                                  {
    //                                                      Id = lawycase.Id,
    //                                                      NameLawyer = stand.FirstName + " " + stand.LastName,
    //                                                      Case_status = lawycase.Case_status,
    //                                                      Reference_role = lawycase.Reference_role,
    //                                                      StartTime = lawycase.StartTime,
    //                                                      EndTime = lawycase.EndTime,
    //                                                      Duration = lawycase.Duration,
    //                                                      Billing_case = lawycase.Billing_case,
    //                                                      DateCreated = lawycase.DateCreated,
    //                                                      DateModified = lawycase.DateModified
    //                                                  }).ToList();


    //        var Ncase = _caseRepository.FindById(caseid);

    //        ViewBag.Message = Ncase.CaseTitle;

    //        var sgl = caselawyersfil.Single(x => x.Id == id);


    //        return View(sgl);
    //    }
    //    // POST: LawyersOnCasesController/Delete/5
    //    [HttpPost, ActionName("DeleteL")]
    //    [ValidateAntiForgeryToken]
    //    public ActionResult DeleteCaseperLawyerConfirmed(DisplayLawyerOnCase displayLawyerOnCase, int lawyerid)
    //    {
    //        ViewBag.Lawyer_Id = lawyerid;

    //        using (_unitOfWorkFactory.Create())
    //        {
    //            var lawyer = _lawyerRepository.FindById(lawyerid, x => x.LawyersOnCases);
    //            var lwy_cas = lawyer.LawyersOnCases.Single(x => x.Id == displayLawyerOnCase.Id);
    //            lawyer.LawyersOnCases.Remove(lwy_cas);

              
    //        }
    //        return RedirectToAction(nameof(CasesperLawyerList), new { lawyerid });
    //    }

    //    // POST: LawyersOnCasesController/Delete/5
    //    [HttpPost, ActionName("DeleteC")]
    //    [ValidateAntiForgeryToken]
    //    public ActionResult DeleteLawyerperCaseConfirmed(DisplayLawyerOnCase displayLawyerOnCase, int caseid)
    //    {
    //        ViewBag.Case_Id = caseid;
    //        using (_unitOfWorkFactory.Create())
    //        {
    //            var cse = _caseRepository.FindById(caseid, x => x.LawyersOnCases);
    //            var lwy_cas = cse.LawyersOnCases.Single(x => x.Id == displayLawyerOnCase.Id);
    //            cse.LawyersOnCases.Remove(lwy_cas);

               
    //        }
    //        return RedirectToAction(nameof(LawyersperCaseList), new { caseid });
    //    }
    //}
}