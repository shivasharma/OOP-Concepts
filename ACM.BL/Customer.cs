﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Acme.Common;

namespace ACM.BL
{
    public class Customer:EntityBase,ILoggable
    {
        public Customer():this(0)
        {
                
        }
        public Customer(int customerId)
        {
            this.CustomerId = customerId;
            AddressList=new List<Address>();
        }
        public List<Address> AddressList { get; set; }
        public int CustomerType { get; set; }
        public static  int InstanceCount { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public int CustomerId { get; private set; }
        public string FullName
        {
            get {
                return FirstName + ", " + LastName;
            }
        }
        public override bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            return isValid;

        }

        public override string ToString()
        {
            return FullName;
        }

        public string Log()
        {
            var logString = this.CustomerId + " : " + this.FullName + " " + "Email:" + this.EmailAddress + " " +
                            "Status:" + this.EntityState.ToString();
            return logString;
        }

       
    }
}
