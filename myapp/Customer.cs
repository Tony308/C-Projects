using System;

namespace myapp {
    class Customer {

        private string address;
        private int customerId;
        private static int customerValueForCustomerId;
    
        private string customerName;
        private string customerType;
        private DateTime dateOfBirth;
        private string emailId ;
        private Gender gender;
        private string password;

        static Customer() {
            customerValueForCustomerId = 1000;
        }   
        public Customer() {}
        public Customer(string address, int customerId, string customerName, 
        string customerType, DateTime dateOfBirth, string emailId, Gender gender, string password)
        {
            this.address = address;
            this.customerId = customerValueForCustomerId++;
            this.customerName = customerName;
            this.customerType = customerType;
            this.dateOfBirth = dateOfBirth;
            this.emailId = emailId;
            this.Gender = gender;
            this.password = password;
        }

        public int CustomerId { get => customerId; set => customerId = value; }
        public string Address { get => address; set => address = value; }
        public string CustomerName { get => customerName; set => customerName = value; }
        public string CustomerType { get => customerType; set => customerType = value; }
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public string EmailId { get => emailId; set => emailId = value; }
    
        public string Password { get => password; set => password = value; }
        internal Gender Gender { get => gender; set => gender = value; }

        public double GetDiscount() {

            if (this.customerType == "Privileged") {
                return 2.00;
            } else if (this.customerType == "Regular") {
                return 5.00;
            } else if (this.customerType == "Elite") {
                return 7.00;
            }
            return 0.00;
        }
    }    
}