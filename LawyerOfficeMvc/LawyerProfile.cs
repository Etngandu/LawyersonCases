using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LawyerOffice.Entities;
using LawyerOfficeMvc.Models;

namespace LawyerOfficeMvc
{
    public class LawyerProfile : Profile
    {
        public LawyerProfile()
        {
            #region Lawyer 
            CreateMap<Lawyer, DisplayLawyer>();

            CreateMap<CreateAndEditLawyer, Lawyer>()
              .ForMember(d => d.DateCreated, t => t.Ignore())
              .ForMember(d => d.DateModified, t => t.Ignore());
            CreateMap<Lawyer, CreateAndEditLawyer>();
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

        }
    }
}
