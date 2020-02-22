using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Book_Store
{
    public class Customer
    {
        private bool isAdmin;
        private int purchasesCounter;
        private int customerID;
        private string name;
        private string surname;
        private string address;
        private string email;
        private string username;
        private string password;

        public bool IsAdmin
        {
            get
            {
                return isAdmin;
            }
            set
            {
                isAdmin = value;
            }
        }
        public int PurchasesCounter
        {
            get
            {
                return purchasesCounter;
            }

            set
            {
                purchasesCounter = value;
            }
        }
        public int CustomerID
        {
            get
            {
                return customerID;
            }

            set
            {
                customerID = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
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
        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }
        public string Username
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
            }
        }
        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }
        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                surname = value;
            }
        }
        

        public Customer() { }

        public void printCustomerDetails(Customer customer)
        {
            UserProfileForm userForm = new UserProfileForm(customer);
            userForm.ShowDialog();
            userForm.Dispose();
        }

        public void saveCustomer(int customerID, string name, string surname, string address, string email, string username, string password)
        {
            this.customerID = customerID;
            this.name = name;
            this.surname = surname;
            this.address = address;
            this.email = email;
            this.username = username;
            this.password = password;
            this.isAdmin = false;
        }

        public void printCustomerPurchases()
        {

        }

    }


}
