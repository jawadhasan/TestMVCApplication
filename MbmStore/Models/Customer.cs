using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MbmStore.Models
{
    public class Customer1
    {
        // fields
        string firstname;
        string lastname;
        int age;
        string address;
        string zip;
        string city;
        List<string> phoneNumbers;
        DateTime birthDate;

        // /////properties
        //Auto implemented property, in this case I won't need private string image url.
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        ///Calculate the age of the customer from the birthday
        public int Age {
            get {
                DateTime now = DateTime.Now;
                int age;

                age = now.Year - birthDate.Year;
                // calculate to see if the customer hasn’t had birthday yet 
                // subtract one year if that is so 
                if (now.Month < birthDate.Month || (now.Month == birthDate.Month && now.Day < birthDate.Day)) ;

                return age;
            }
        }

        public string Address { get; set; }
        public string Zip { get; set; }
        public string City { get; set; }

        public List<string> PhoneNumbers {
            get { return phoneNumbers; }
        }

        DateTime Birthdate { get; set; }
        // constructors 

        public Customer1(string firstname, string lastname, int age, string address, string zip, string city)
        {
            this.Firstname = firstname;
            this.Lastname = lastname;
            //this.Age = age;
            this.Address= address;
            this.Zip = zip;
            this.City = city;
        }
        /// method AddPhone
        public void addPhone(string phone)
        {
            //AddPhone.Add(phone);
        }
    }


    public class Customer
    {
        private DateTime birthDate; //backing field
        List<string> phoneNumbers;

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthdate
        {
            get { return birthDate; }
            set
            {
                birthDate = value;
                if (Age < 0 || Age > 120)
                {
                    throw new Exception("Age not accepted");
                }
            }
        }
        public int Age
        {
                get
                {
                    var now = DateTime.Now;
                    int age = now.Year - birthDate.Year;

                    //calculate to see if the customer hasn't had birthday yet
                    //subtract one year if that is so

                    if (now.Month < birthDate.Month || now.Month == birthDate.Month && now.Day < birthDate.Day)
                    {
                        age--;
                    }

                    return age;
                }
        }

        public string Address { get; set; }
        public string Zip { get; set; }
        public string City { get; set; }

        public List<string> PhoneNumbers
        {
            get { return phoneNumbers; }
        }

        //ctor
        public Customer()
        {
            phoneNumbers = new List<string>();
        }

        public Customer(string firstname, string lastname, string address, string zip, string city):this()
        {
            FirstName = firstname;
            LastName = lastname;
            Address = address;
            Zip = zip;
            City = city;
        }

        //Birthday parameter
        public Customer(string firstname, string lastname, string address, string zip, string city, DateTime birthDate) : this()
        {
            FirstName = firstname;
            LastName = lastname;
            Address = address;
            Zip = zip;
            City = city;
            Birthdate = birthDate;
        }


        public void AddPhone(string phone)
        {
            phoneNumbers.Add(phone);
        }


        public string CustomerInfo
        {
            get
            {
                var customerIntroduction = $"{FirstName} {LastName}";
                if (Birthdate != DateTime.MinValue)
                {
                    customerIntroduction = $"{customerIntroduction} is {Age} years old";
                }
                return customerIntroduction;
            }
        }
       
    }

}


