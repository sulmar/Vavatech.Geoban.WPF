using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geoban.WPF.Demo.Models
{
    public class Customer : Object
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public byte Age { get; set; }

        public Address HomeAddress { get; set; }

        public Address WorkAddress { get; set; }


        public bool IsAdult
        {
            get
            {
                return Age >= 18;
            }
        }

        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }


        // c# 6.0
        // public string FullName => $"{FirstName} {LastName}";


        //public override string ToString()
        //{
        //    return String.Format("{0} {1}", FirstName, LastName);
        //}


        // C# 6.0
        //public override string ToString()
        //{
        //    return $"{FirstName} {LastName}";
        //}

        public override string ToString() => FullName;

    }
}
