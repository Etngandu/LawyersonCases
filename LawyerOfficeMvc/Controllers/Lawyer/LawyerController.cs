using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LawyerOffice.Entities;
using LawyerOffice.Infrastructure;
using LawyerOfficeMvc.Models;
using LawyerOffice.Entities.Repositories;
using AutoMapper;

namespace ENB.Mvc.Lawyer.Controllers.Lawyer
{
    public class LawyerController : Controller
    {
        // GET: LawyerController

        private readonly ILawyerRepository _lawyerRepository;
        private readonly IUnitOfWorkFactory _unitOfWorkFactory;
       // private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IMapper _imapper;


        public LawyerController(ILawyerRepository lawyerRepository, IUnitOfWorkFactory unitOfWorkFactory
            , IMapper imapper)
        {
            _lawyerRepository = lawyerRepository;
            _unitOfWorkFactory = unitOfWorkFactory;
          //  _httpContextAccessor = httpContextAccessor;
            _imapper = imapper;
        }
        public ActionResult Index()
        {
            return View();
        }

        public  ActionResult GetLawyerData()
        {
            IQueryable<LawyerOffice.Entities.Lawyer> allLawyers =  _lawyerRepository.FindAll();

             var Mpdata =   _imapper.Map<List<DisplayLawyer>>(allLawyers).ToList();
            return Json(new { data = Mpdata });
        }

        // GET: LawyerController/Details/5
        public ActionResult  Details(int id)
        {
            return  View();
        }

        // GET: LawyerController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LawyerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CreateAndEditLawyer createAndEditLawyer)
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

        // GET: LawyerController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LawyerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: LawyerController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LawyerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
