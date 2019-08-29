using System;

namespace Constructor_Chaining_Demo
{
    public class Customer
    {
        private static int count;
        private int customerId;        
        private string customerName;
        private string contactNumber;
        private string emailId;
        private string address;
        static Customer()
        {
            count = 1000;
        }
        public Customer()
        {
            CustomerId = ++count;
            Console.WriteLine("base class constructor..");
        }
        public Customer(string name, string contactNumber, string emailid, string 
                                                                          address) 
        :this()  // invoking default contructor to set auto incremented customer id
        {   
            this.CustomerName = name;
            this.ContactNumber = contactNumber;
            this.EmailId = emailid;
            this.Address = address;
        }
        public int CustomerId
        {
            get
            {
                return customerId;
            }
            set
            {
                customerId = value;
            }
        }
        public string CustomerName
        {
            get
            {
                return customerName;
            }
            set
            {
                customerName = value;
            }
        }
        public string ContactNumber
        {
            get
            {
                return contactNumber;
            }
            set
            {
                contactNumber = value;
            }
        }
        public string EmailId
        {
            get
            {
                return emailId;
            }
            set
            {
                emailId = value;
            }
        }
        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }      
      } 
 

}