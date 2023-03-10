using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LawyerOffice.Entities;
using ENB.Mvc.Lawyer.Models;
using ENB.Mvc.Lawyer.Models.AppUser;

namespace ENB.Mvc.Lawyer
{
    public class LawyerProfile : Profile
    {
        public LawyerProfile()
        {
            #region Lawyer 
            CreateMap<LawyerOffice.Entities.Lawyer, DisplayLawyer>();

            CreateMap<CreateAndEditLawyer, LawyerOffice.Entities.Lawyer>()
              .ForMember(d => d.DateCreated, t => t.Ignore())
              .ForMember(d => d.DateModified, t => t.Ignore());
            CreateMap<LawyerOffice.Entities.Lawyer, CreateAndEditLawyer>();
            #endregion


            #region Case
            CreateMap<Case, DisplayCase>();

            CreateMap<CreateAndEditCase, Case>()
              .ForMember(d => d.DateCreated, t => t.Ignore())
              .ForMember(d => d.DateModified, t => t.Ignore());
            CreateMap<Case, CreateAndEditCase>();

            #endregion


            #region LawyerOnCase
            CreateMap<Lawyer_on_case, DisplayLawyerOnCase>()
             .ForMember(d => d.LawyerId, t => t.MapFrom(y => y.Owner_LawyerId))
             .ForMember(d => d.CaseId, t => t.MapFrom(y => y.Owner_CaseId));

            CreateMap<CreateAndEditLawyerOnCase, Lawyer_on_case>()
              .ForMember(d => d.Owner_CaseId, t => t.MapFrom(y => y.CaseId))
              .ForMember(d => d.Owner_LawyerId, t => t.MapFrom(y => y.LawyerId))
              .ForMember(d => d.DateCreated, t => t.Ignore())
              .ForMember(d => d.DateModified, t => t.Ignore())
              .ReverseMap();

            #endregion

            #region LawyerEvent
            CreateMap<LawyerEvent, DisplayLawyerEvent>()
             .ForMember(d => d.LawyerId, t => t.MapFrom(y => y.LawyerId));
             

            CreateMap<CreateAndEditLawyerEvent, LawyerEvent>()              
              .ForMember(d => d.LawyerId, t => t.MapFrom(y => y.LawyerId))
              .ForMember(d => d.DateCreated, t => t.Ignore())
              .ForMember(d => d.DateModified, t => t.Ignore())
              .ReverseMap();

            #endregion

            #region Identity
            CreateMap<UserRegistrationModel, ApplicationUser>()
            .ForMember(u => u.UserName, opt => opt.MapFrom(x => x.Email));
            #endregion

        }
    }
}
