using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Model
{
    public class Doctor
    {
        private int _id;
        private string _name;
        private string _surname;
        private string _email;
        private string _password;
        private string _contact;
        private string _location;

        public int Id
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
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

        public string Location
        {
            get
            {
                return _location;
            }

            set
            {
                _location = value;
            }
        }

        public Doctor()
        {
            this.Id = 0;
            this.Name = string.Empty;
            this.Surname = string.Empty;
            this.Email = string.Empty;
            this.Password = string.Empty;
            this.Contact = string.Empty;
            this.Location = string.Empty;
        }
        public Doctor(int id, string name, string surname, string email, string password, string contact, string location)
        {
            this.Id = id;
            this.Name = name;
            this.Surname = surname;
            this.Email = email;
            this.Password = password;
            this.Contact = contact;
            this.Location = location;
        }
        public Doctor(IDataReader reader)
        {
            this.Id=reader.GetRecord<int>("ID_Doktor");
            this.Name = reader.GetRecord<string>("Ime");
            this.Surname = reader.GetRecord<string>("Prezime");
            this.Email = reader.GetRecord<string>("Email");
            this.Password = reader.GetRecord<string>("Lozinka");
            this.Contact = reader.GetRecord<string>("Kontakt");
           
        }
    }
}
