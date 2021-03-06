//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OptimizePrime
{
    using System;
    using System.Collections.Generic;
    
    public partial class Applicant
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Applicant()
        {
            this.ApplicantExperiences = new HashSet<ApplicantExperience>();
            this.ApplicantStudies = new HashSet<ApplicantStudy>();
            this.AssessmentResults = new HashSet<AssessmentResult>();
            this.Applications = new HashSet<Application>();
        }
    
        public int ApplicantID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string EmailAddress { get; set; }
        public int ContactNumber { get; set; }
        public string PhysicalAddress { get; set; }
        public int StatusID { get; set; }
        public int UserID { get; set; }
        public int Age { get; set; }
        public string Nationality { get; set; }
        public string Citizenship { get; set; }
        public string ResidentialAddress { get; set; }
        public string Gender { get; set; }
        public string Race { get; set; }
        public string Disability { get; set; }
        public string LinkedInLink { get; set; }
        public string ApplicantIntroduction { get; set; }
        public string IDNumber { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ApplicantExperience> ApplicantExperiences { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ApplicantStudy> ApplicantStudies { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssessmentResult> AssessmentResults { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Application> Applications { get; set; }
        public virtual Status Status { get; set; }
        public virtual User User { get; set; }
    }
}
