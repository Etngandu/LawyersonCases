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


namespace ENB.WebApi.Lawyer.Controllers
{
    public class BillingController : Controller
    {
        // GET: Case
        private readonly ILawyerRepository _lawyerRepository;
        private readonly ICaseRepository _caseRepository;
        private readonly IUnitOfWorkFactory _unitOfWorkFactory;
        private readonly IMapper _imapper;
        const int PageSize = 10;


        /// <summary>
        /// Initializes a new instance of the BillingController class.
        /// </summary>
        /// 



        public BillingController(ILawyerRepository lawyerRepository, ICaseRepository caseRepository, IUnitOfWorkFactory unitOfWorkFactory, IMapper imapper)
        {
            _lawyerRepository = lawyerRepository;
            _caseRepository = caseRepository;
            _unitOfWorkFactory = unitOfWorkFactory;
            _imapper = imapper;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetCasesOnLawyerList()

        {     

            var lwycase = from l in _lawyerRepository.FindAll().SelectMany(lwc => lwc.LawyersOnCases)
                       join c in _caseRepository.FindAll() on l.Owner_CaseId equals c.Id
                       join lwy in _lawyerRepository.FindAll() on l.Owner_LawyerId equals lwy.Id
                       select new DisplayLawyerOnCase
                       {
                           Id = l.Id,
                           Titlecase = c.CaseTitle,
                           NameLawyer = lwy.FullName,
                           DateCreated = l.DateCreated,
                           Duration = l.Duration,
                           Case_status = l.Case_status,
                           Reference_role = l.Reference_role,
                           Billing_case = l.Billing_case
                       };



            var Mpdata = _imapper.Map<List<DisplayLawyerOnCase>>(lwycase);


            return Json(new { data = Mpdata });

        }

        
    }
}
