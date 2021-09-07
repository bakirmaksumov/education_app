using System;
using System.Collections.Generic;

#nullable disable

namespace EducationApplication.Model
{
    public partial class User
    {
        public User()
        {
            CertificateConfirmationCreatedByNavigations = new HashSet<CertificateConfirmation>();
            CertificateConfirmationUsers = new HashSet<CertificateConfirmation>();
            CertificateTemplateCreatedByNavigations = new HashSet<CertificateTemplate>();
            CertificateTemplateModifiedByNavigations = new HashSet<CertificateTemplate>();
            ContractStudentCreatedByNavigations = new HashSet<ContractStudent>();
            ContractStudentModifiedByNavigations = new HashSet<ContractStudent>();
            ContractStudentUsers = new HashSet<ContractStudent>();
            GrantConfirmationCreatedByNavigations = new HashSet<GrantConfirmation>();
            GrantConfirmationUsers = new HashSet<GrantConfirmation>();
            InverseCreatedByNavigation = new HashSet<User>();
            InverseModifiedByNavigation = new HashSet<User>();
            InvoiceCreatedByNavigations = new HashSet<Invoice>();
            InvoiceModifiedByNavigations = new HashSet<Invoice>();
            InvoiceTemplateCreatedByNavigations = new HashSet<InvoiceTemplate>();
            InvoiceTemplateModifiedByNavigations = new HashSet<InvoiceTemplate>();
            InvoiceUsers = new HashSet<Invoice>();
            SchoolPriceCreatedByNavigations = new HashSet<SchoolPrice>();
            SchoolPriceModifiedByNavigations = new HashSet<SchoolPrice>();
            StudentCertificateCreatedByNavigations = new HashSet<StudentCertificate>();
            StudentCertificateModifiedByNavigations = new HashSet<StudentCertificate>();
            StudentCertificateUsers = new HashSet<StudentCertificate>();
            StudentGrantModifiedByNavigations = new HashSet<StudentGrant>();
            StudentGrantUsers = new HashSet<StudentGrant>();
            UserInfoCreatedByNavigations = new HashSet<UserInfo>();
            UserInfoModifiedByNavigations = new HashSet<UserInfo>();
            UserInfoUsers = new HashSet<UserInfo>();
            UserRoles = new HashSet<UserRole>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime CreateDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual User CreatedByNavigation { get; set; }
        public virtual User ModifiedByNavigation { get; set; }
        public virtual ICollection<CertificateConfirmation> CertificateConfirmationCreatedByNavigations { get; set; }
        public virtual ICollection<CertificateConfirmation> CertificateConfirmationUsers { get; set; }
        public virtual ICollection<CertificateTemplate> CertificateTemplateCreatedByNavigations { get; set; }
        public virtual ICollection<CertificateTemplate> CertificateTemplateModifiedByNavigations { get; set; }
        public virtual ICollection<ContractStudent> ContractStudentCreatedByNavigations { get; set; }
        public virtual ICollection<ContractStudent> ContractStudentModifiedByNavigations { get; set; }
        public virtual ICollection<ContractStudent> ContractStudentUsers { get; set; }
        public virtual ICollection<GrantConfirmation> GrantConfirmationCreatedByNavigations { get; set; }
        public virtual ICollection<GrantConfirmation> GrantConfirmationUsers { get; set; }
        public virtual ICollection<User> InverseCreatedByNavigation { get; set; }
        public virtual ICollection<User> InverseModifiedByNavigation { get; set; }
        public virtual ICollection<Invoice> InvoiceCreatedByNavigations { get; set; }
        public virtual ICollection<Invoice> InvoiceModifiedByNavigations { get; set; }
        public virtual ICollection<InvoiceTemplate> InvoiceTemplateCreatedByNavigations { get; set; }
        public virtual ICollection<InvoiceTemplate> InvoiceTemplateModifiedByNavigations { get; set; }
        public virtual ICollection<Invoice> InvoiceUsers { get; set; }
        public virtual ICollection<SchoolPrice> SchoolPriceCreatedByNavigations { get; set; }
        public virtual ICollection<SchoolPrice> SchoolPriceModifiedByNavigations { get; set; }
        public virtual ICollection<StudentCertificate> StudentCertificateCreatedByNavigations { get; set; }
        public virtual ICollection<StudentCertificate> StudentCertificateModifiedByNavigations { get; set; }
        public virtual ICollection<StudentCertificate> StudentCertificateUsers { get; set; }
        public virtual ICollection<StudentGrant> StudentGrantModifiedByNavigations { get; set; }
        public virtual ICollection<StudentGrant> StudentGrantUsers { get; set; }
        public virtual ICollection<UserInfo> UserInfoCreatedByNavigations { get; set; }
        public virtual ICollection<UserInfo> UserInfoModifiedByNavigations { get; set; }
        public virtual ICollection<UserInfo> UserInfoUsers { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
