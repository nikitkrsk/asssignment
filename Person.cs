using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
   public class Person
    {

        private string FirstName { get; set; }
        public String NAme
        {
            get
            {
                return FirstName;
            }
            set
            {

                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Put your Name");
                }
               FirstName = value;
            }
        }

        private string SecondName { get; set; }
        public String SecondNamE
        {
            get
            {
                return SecondName;
            }
            set
            {

                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Put your surname");
                }
                SecondName = value;
            }
        }
        public override string ToString()
        {
            return FirstName +" "+ SecondName;
        }
    }

}
