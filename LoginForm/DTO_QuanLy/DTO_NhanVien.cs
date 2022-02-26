using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{
    public class DTO_NhanVien
    {
        private int Id_role;
        private int Gender;
        private string Email;
        private string Address;
        private string Password;
        private string DayOfBirth;
        private int Id_employee;
        private string Name;
        private float Salary;
        public int ID_Role
        {
            get
            {
                return Id_role;
            }
            set
            {
                Id_role = value;
            }
        }
        public int GenDer
        {
            get
            {
                return Gender;
            }
            set
            {
                Gender = value;
            }
        }
        public string email
        {
            get
            {
                return Email;
            }
            set
            {
                Email = value;
            }
        }
        public string address
        {
            get
            {
                return Address;
            }
            set
            {
                Address = value;
            }
        }
        public string password
        {
            get
            {
                return Password;
            }
            set
            {
                Password = value;
            }
        }
        public string dayOfBirth
        {
            get
            {
                return DayOfBirth;
            }
            set
            {
                DayOfBirth = value;
            }
        }
        public int id_employee
        {
            get
            {
                return Id_employee;
            }
            set
            {
                Id_employee = value;
            }
        }
        public string name
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
            }
        }
        public float salary
        {
            get
            {
                return Salary;
            }
            set
            {
                Salary = value;
            }
        }
        public DTO_NhanVien(int id_role, string name, int gender, string email, string address, string dayofbrith, float salary,int id_employee)
        {
            this.Id_role = id_role;
            this.Id_employee = id_employee;
            this.Name = name;
            this.Gender = gender;
            this.Email = email;
            this.Address = address;
            this.DayOfBirth = dayofbrith;
            this.Salary = salary;
        }
        public DTO_NhanVien(int id_role, string name, int gender, string email, string address, string dayofbrith, float salary)
        {
            this.Id_role = id_role;
            this.Name = name;
            this.Gender = gender;
            this.Email = email;
            this.Address = address;
            this.DayOfBirth = dayofbrith;
            this.Salary = salary;
        }

        public DTO_NhanVien(int id_role)
        {
            this.ID_Role = id_role;
        }
        public DTO_NhanVien()
        {

        }
    }
}

