using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    class Address
    {
        private string Addres { get; set; }
        public String ADDREESS
        {
            get
            {
                return Addres;
            }
            set
            {
               
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Put your address"); 
                }
                Addres = value;
            }
        }

        private string Street { get; set; }
        public String STREET
        {
            get
            {
                return Street;
            }
            set
            {

                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Put your Street");
                }
                Street = value;
            }
        }
        private string City { get; set; }
        public String CitY
        {
            get
            {
                return City;
            }
            set
            {

                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Put your city");
                }
                City = value;
            }
        }
        private string Country { get; set; }
        public String CountrY
        {
            get
            {
                return Country;
            }
            set
            {

                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Put your Country");
                }
                Country = value;
            }
        }
        public override string ToString()
        {
            return Country + " " + City + " " + Street + " " + Addres;
        }
    }
}
