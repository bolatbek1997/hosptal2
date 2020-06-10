namespace Hospital.Server.Models.AdminViewModels
{
    using DatabaseModels;
    using Infrastructure.Mapping;
    using System.Collections.Generic;
    using System.Web;
    using System.Web.Mvc;
    using AutoMapper;
    using System.ComponentModel.DataAnnotations;

    public class AddDoctorViewModel: IMapFrom<UserInfo>, IHaveCustomMappings
    {
        public int Id { get; set; }
        
        public string Name { get; set; }

        public int SpecialityId { get; set; }

        public IEnumerable<SelectListItem> Specialty { get; set; }
        public string DoctorId { get; set; }
        public IEnumerable<User> Doctor { get; set; }

        public HttpPostedFileBase ImageUpload { get; set; }
        
        public string Description { get; set; }

        public void CreateMappings(IConfiguration configuration)
        {
            configuration.CreateMap<UserInfo, AddDoctorViewModel>()
                .ForMember(x => x.SpecialityId, opt => opt.MapFrom(x => x.Specialty.Id))
                .ReverseMap();
        }
    }
}