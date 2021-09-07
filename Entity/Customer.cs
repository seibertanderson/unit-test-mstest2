using System;

namespace Entity
{
    public class Customer
    {
        public int id;
        public string customerName;
        public DateTime dateOfBirth;
        public string password;

        public Customer(int id, string customerName, DateTime dateOfBirth, string password)
        {
            this.id = id;
            SetCustomerName(customerName);
            SetDateOfBirth(dateOfBirth);
            SetPassword(password);
        }

        private void SetDateOfBirth(DateTime birth)
        {
            if (birth > DateTime.Now)
            {
                throw new Exception("Invalid Date of Birth");
            }
            this.dateOfBirth = birth;
        }

        private void SetCustomerName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new Exception("Invalid name");
            }
            this.customerName = name;
        }

        private void SetPassword(string pass)
        {
            if (string.IsNullOrEmpty(pass))
            {
                throw new Exception("Invalid password");
            }
            this.password = pass;
        }
    }
}
