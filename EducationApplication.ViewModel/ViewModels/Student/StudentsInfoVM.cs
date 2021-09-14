using EducationApplication.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationApplication.ViewModel.ViewModels.Student
{
    public class StudentsInfoVM
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Adress { get; set; }
        public string PINFL { get; set; }
        public string Email { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Phone { get; set; }
        public string Status { get; set; }

        public DateTime? CreateDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public int? ModifiedBy { get; set; }

        public StudentsInfoVM VMFromModel(User model)
        {
            StudentsInfoVM vm = new StudentsInfoVM
            {
                ID = model.Id,
                FirstName = model.FirstName,
                LastName = model.LastName,
                PINFL = model.UserInfoUsers.Count() != 0 ? model.UserInfoUsers.First().Pinfl : "no PINFL",
                Adress = model.UserInfoUsers.Count() != 0 ? model.UserInfoUsers.First().Adress : "no Adress",
                Phone = model.UserInfoUsers.Count() != 0 ? model.UserInfoUsers.First().Pinfl : "no PINFL",
                DateOfBirth= model.UserInfoUsers.Count() != 0 ? model.UserInfoUsers.First().DateofBirth :(DateTime?)null,
                Email=model.Email,
                // Status = model.Status,
                CreateDate = model.CreateDate,
                CreatedBy = model.CreatedBy,
                ModifiedBy = model.ModifiedBy,
                ModifyDate = model.ModifyDate
            };
            return vm;
        }

        public List<StudentsInfoVM> VMFromModelList(List<User> modelList)
        {
            List<StudentsInfoVM> lvm = new List<StudentsInfoVM>();
            foreach (var item in modelList)
            {
                StudentsInfoVM vm = this.VMFromModel(item);
                lvm.Add(vm);
            }
            return lvm;
        }
    }
}
