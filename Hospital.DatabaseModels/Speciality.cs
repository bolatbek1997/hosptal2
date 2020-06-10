namespace Hospital.DatabaseModels
{
    using System.Collections.Generic;

    public class Speciality
    {
        private ICollection<ClinicalTrial> clinicalTrials;
        private ICollection<UserInfo> doctors;

        public Speciality()
        {
            this.clinicalTrials = new HashSet<ClinicalTrial>();
            this.doctors = new HashSet<UserInfo>();
        }

        public int Id { get; set; }

        public string Description { get; set; } 

        public string Title { get; set; }

        public virtual ICollection<ClinicalTrial> ClinicalTrials
        {
            get { return this.clinicalTrials; }
            set { this.clinicalTrials = value; }
        }

        public virtual ICollection<UserInfo> Doctors
        {
            get { return this.doctors; }
            set { this.doctors = value; }
        }
    }
}
