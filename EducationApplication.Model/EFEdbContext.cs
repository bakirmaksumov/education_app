using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace EducationApplication.Model
{
    public partial class EFEdbContext : DbContext
    {
        public EFEdbContext()
        {
        }

        public EFEdbContext(DbContextOptions<EFEdbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CertificateConfirmation> CertificateConfirmations { get; set; }
        public virtual DbSet<CertificateTemplate> CertificateTemplates { get; set; }
        public virtual DbSet<CertificateType> CertificateTypes { get; set; }
        public virtual DbSet<ContractStudent> ContractStudents { get; set; }
        public virtual DbSet<ContractType> ContractTypes { get; set; }
        public virtual DbSet<GrantConfirmation> GrantConfirmations { get; set; }
        public virtual DbSet<GrantType> GrantTypes { get; set; }
        public virtual DbSet<Invoice> Invoices { get; set; }
        public virtual DbSet<InvoiceTemplate> InvoiceTemplates { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<SchoolPrice> SchoolPrices { get; set; }
        public virtual DbSet<StudentCertificate> StudentCertificates { get; set; }
        public virtual DbSet<StudentGrant> StudentGrants { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserInfo> UserInfos { get; set; }
        public virtual DbSet<UserRole> UserRoles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=hp-intranet.wiut.uz;Initial Catalog=EFEdb;Persist Security info=True;User Id=sa;Password=ujkjlytn`nrf");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<CertificateConfirmation>(entity =>
            {
                entity.ToTable("CertificateConfirmation");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CertificateId).HasColumnName("CertificateID");

                entity.Property(e => e.ConfirmationDate).HasColumnType("datetime");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Certificate)
                    .WithMany(p => p.CertificateConfirmations)
                    .HasForeignKey(d => d.CertificateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CertificateConfirmation_CertificateType");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.CertificateConfirmationCreatedByNavigations)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CertificateConfirmation_Users1");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.CertificateConfirmationUsers)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CertificateConfirmation_Users");
            });

            modelBuilder.Entity<CertificateTemplate>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CertificateTypeId).HasColumnName("CertificateTypeID");

                entity.Property(e => e.Cktext)
                    .IsRequired()
                    .HasColumnName("CKText");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.CertificateType)
                    .WithMany(p => p.CertificateTemplates)
                    .HasForeignKey(d => d.CertificateTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CertificateTemplates_CertificateType");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.CertificateTemplateCreatedByNavigations)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CertificateTemplates_Users");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.CertificateTemplateModifiedByNavigations)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_CertificateTemplates_Users1");
            });

            modelBuilder.Entity<CertificateType>(entity =>
            {
                entity.ToTable("CertificateType");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(200);
            });

            modelBuilder.Entity<ContractStudent>(entity =>
            {
                entity.ToTable("ContractStudent");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ContractTypeId).HasColumnName("ContractTypeID");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.SchoolId).HasColumnName("SchoolID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.ContractType)
                    .WithMany(p => p.ContractStudents)
                    .HasForeignKey(d => d.ContractTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ContractStudent_ContractType");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.ContractStudentCreatedByNavigations)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ContractStudent_Users1");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.ContractStudentModifiedByNavigations)
                    .HasForeignKey(d => d.ModifiedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ContractStudent_Users2");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ContractStudentUsers)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ContractStudent_Users");
            });

            modelBuilder.Entity<ContractType>(entity =>
            {
                entity.ToTable("ContractType");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<GrantConfirmation>(entity =>
            {
                entity.ToTable("GrantConfirmation");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ConfirmationDate).HasColumnType("datetime");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.GrantId).HasColumnName("GrantID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.GrantConfirmationCreatedByNavigations)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GrantConfirmation_Users1");

                entity.HasOne(d => d.Grant)
                    .WithMany(p => p.GrantConfirmations)
                    .HasForeignKey(d => d.GrantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GrantConfirmation_StudentGrants");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.GrantConfirmationUsers)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GrantConfirmation_Users");
            });

            modelBuilder.Entity<GrantType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<Invoice>(entity =>
            {
                entity.ToTable("Invoice");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.PayDate).HasColumnType("datetime");

                entity.Property(e => e.SchoolId).HasColumnName("SchoolID");

                entity.Property(e => e.Url).HasColumnName("URL");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.InvoiceCreatedByNavigations)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Invoice_Users1");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.InvoiceModifiedByNavigations)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_Invoice_Users2");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.InvoiceUsers)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Invoice_Users");
            });

            modelBuilder.Entity<InvoiceTemplate>(entity =>
            {
                entity.ToTable("InvoiceTemplate");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Cktext)
                    .IsRequired()
                    .HasColumnName("CKText");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.InvoiceTemplateCreatedByNavigations)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InvoiceTemplate_Users");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.InvoiceTemplateModifiedByNavigations)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_InvoiceTemplate_Users1");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<SchoolPrice>(entity =>
            {
                entity.ToTable("SchoolPrice");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ActiveFrom).HasColumnType("datetime");

                entity.Property(e => e.ActiveTo).HasColumnType("datetime");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.ShoolId).HasColumnName("ShoolID");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.SchoolPriceCreatedByNavigations)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SchoolPrice_Users");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.SchoolPriceModifiedByNavigations)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_SchoolPrice_Users1");
            });

            modelBuilder.Entity<StudentCertificate>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CertificateTypeId).HasColumnName("CertificateTypeID");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.Url).HasColumnName("URL");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.CertificateType)
                    .WithMany(p => p.StudentCertificates)
                    .HasForeignKey(d => d.CertificateTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StudentCertificates_CertificateType");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.StudentCertificateCreatedByNavigations)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StudentCertificates_Users1");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.StudentCertificateModifiedByNavigations)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_StudentCertificates_Users2");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.StudentCertificateUsers)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StudentCertificates_Users");
            });

            modelBuilder.Entity<StudentGrant>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.GrantTypeId).HasColumnName("GrantTypeID");

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.Url).HasColumnName("URL");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.InverseCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StudentGrants_StudentGrants");

                entity.HasOne(d => d.GrantType)
                    .WithMany(p => p.StudentGrants)
                    .HasForeignKey(d => d.GrantTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StudentGrants_GrantTypes");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.StudentGrantModifiedByNavigations)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_StudentGrants_Users1");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.StudentGrantUsers)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StudentGrants_Users");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.InverseCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Users_Users");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.InverseModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_Users_Users1");
            });

            modelBuilder.Entity<UserInfo>(entity =>
            {
                entity.ToTable("UserInfo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Adress)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.Pinfl)
                    .HasMaxLength(50)
                    .HasColumnName("PINFL");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.UserInfoCreatedByNavigations)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserInfo_Users");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.UserInfoModifiedByNavigations)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_UserInfo_Users1");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserInfoUsers)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserInfo_Users2");
            });

            modelBuilder.Entity<UserRole>(entity =>
            {
                entity.HasKey(e => new { e.RoleId, e.UserId });

                entity.ToTable("UserRole");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.UserRoles)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserRole_Roles");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserRoles)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserRole_Users");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
