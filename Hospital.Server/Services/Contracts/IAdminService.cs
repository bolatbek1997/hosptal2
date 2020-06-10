namespace Hospital.Server.Services.Contracts
{
    using DatabaseModels;
    using Models.AdminViewModels;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Mvc;

    public interface IAdminService
    {
        List<ResultViewModel> GetAllResults();

        List<PatientViewModel> GetPatients(string role="user",string userId="");

        PDF GetPDF(AddResultViewModel result);

        Image GetImage(AddDoctorViewModel doctor);
        List<Send> GetMessage(string IsRead="ok");

        IQueryable<SelectListItem> GetSpecialty();
        UserInfo GetUserById(string id);
    }
}