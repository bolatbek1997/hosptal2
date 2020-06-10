namespace Hospital.DatabaseModels
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System.Collections.Generic;
    using System.Security.Claims;
    using System.Threading.Tasks;

    public class User : IdentityUser
    {
        private ICollection<ClinicalResult> clinicalResults;
        private UserInfo doctor;

        public User()
        {
            this.clinicalResults = new HashSet<ClinicalResult>();
            doctor = new UserInfo();
        }

        public virtual ICollection<ClinicalResult> ClinicalResults
        {
            get { return this.clinicalResults; }
            set { this.clinicalResults = value; }
        }
        public int? DoctorId { get; set; }
        public int? UserInfoId { get; set; }
        public bool IsDelete { get; set; }
        public virtual UserInfo UserInfo
        {
            get;set;
        }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<User> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }
}
