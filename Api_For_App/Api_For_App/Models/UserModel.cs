using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api_For_App.Models
{
    public class UserModel
    {
        private int _ID;
        private string _name;
        private string _surname;
        private string _email;
        private string _password;
        private string _contact;
        private bool _active;
        private int _doctor;

        public int ID
        {
            get
            {
                return _ID;
            }

            set
            {
                _ID = value;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public string Surname
        {
            get
            {
                return _surname;
            }

            set
            {
                _surname = value;
            }
        }

        public string Email
        {
            get
            {
                return _email;
            }

            set
            {
                _email = value;
            }
        }

        public string Password
        {
            get
            {
                return _password;
            }

            set
            {
                _password = value;
            }
        }

        public string Contact
        {
            get
            {
                return _contact;
            }

            set
            {
                _contact = value;
            }
        }

        public bool Active
        {
            get
            {
                return _active;
            }

            set
            {
                _active = value;
            }
        }

        public int Doctor
        {
            get
            {
                return _doctor;
            }

            set
            {
                _doctor = value;
            }
        }
        public UserModel()
        {
            this.ID = 0;
            this.Name = string.Empty;
            this.Surname = string.Empty;
            this.Email = string.Empty;
            this.Password = string.Empty;
            this.Contact = string.Empty;
            this.Active = false;
            this.Doctor = 0;
        }
        public UserModel(int id, string name, string surname, string email, string password, string contact, bool active, int doctor)
        {
            this.ID = id;
            this.Name = name;
            this.Surname = surname;
            this.Email = email;
            this.Password =password;
            this.Contact = contact;
            this.Active =active;
            this.Doctor = doctor;
        }
    }
}