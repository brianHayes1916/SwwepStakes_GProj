﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweepstakes
{
    public class Contestant
    {
        public string firstName;
        public string lastName;
        public string emailAddress;
        public int registrationNumber;

        public Contestant(string fname, string lname, string email, int number)
        {
            firstName = fname;
            lastName = lname;
            emailAddress = email;
            registrationNumber = number;
        }

    }
}
